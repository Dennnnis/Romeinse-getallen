using System;
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romeinse_getallen
{
    public partial class Form1
    {
        //List to readable string
        string Ltos(List<string> l)
        {
            string r = string.Empty;
            foreach (string s in l)
            {
                r += Readable(s);
            }
            return r;
        }

        //Convert numbers to normal readable roman
        string Readable(string romanCode)
        {
            switch (romanCode)
            {
                case "I1": return "I";

                case "V1": return "V";
                case "V2": return "V̅";
                case "V3": return "V̿";
                case "V4": return "|V̿|";

                case "X1": return "X";
                case "X2": return "X̅";
                case "X3": return "X̿";
                case "X4": return "|X̿|";

                case "L1": return "L";
                case "L2": return "L̅";
                case "L3": return "L̿";
                case "L4": return "|L̿|";

                case "C1": return "C";
                case "C2": return "C̅";
                case "C3": return "C̿";
                case "C4": return "|C̿|";

                case "D1": return "D";
                case "D2": return "D̅";
                case "D3": return "D̿";
                case "D4": return "|D̿|";

                case "M1": return "M";
                case "M2": return "M̅";
                case "M3": return "M̿";
                case "M4": return "|M̿|";

            }

            return romanCode;
        }

        //Interger to roman
        private List<string> IntToRoman(BigInteger number)
        {
            List<string> final = new List<string>();
            while (number > 0)
            {
                BigInteger b = BiggestFit(number, out string r, out string e);
                final.Add(r);
                if (e != string.Empty)
                    final.Add(e);

                number -= b;

                if (b == 0)
                {
                    MessageBox.Show("Error too big");
                    break;
                }
            }
            return final;
        }

        //Finds the biggest value that fits inside the table
        private BigInteger BiggestFit(BigInteger number, out string roman, out string romanE)
        {
            for (int i = dictonary.Count - 1; i >= 0; i--)
            {
                if (dictonary[i].i <= number)
                {
                    roman = dictonary[i].r;
                    romanE = dictonary[i].e;
                    return dictonary[i].i;
                }
            }

            //The given number was too big
            roman = string.Empty;
            romanE = string.Empty;
            return 0;
        }

        //Convert roman char to interger
        private BigInteger RomanCharToInt(string c)
        {
            foreach(Key k in dictonary)
            {
                if (k.e == string.Empty)
                {
                    if (c == k.r)
                    {
                        return k.i;
                    }
                }
            }
            return 0;
        }

        //Convert roman to interger
        private BigInteger RomanToInt(List<string> Roman)
        {
            BigInteger final = 0;

            for (int i = 0; i < Roman.Count; i++)
            {
                BigInteger c = RomanCharToInt(Roman[i]);
                
                if (Roman.Count > i+1)
                {
                    BigInteger c2 = RomanCharToInt(Roman[i + 1]);

                    if (c >= c2)
                    {
                        final += c;
                    }
                    else
                    {
                        final += (c2 - c);
                        i++;
                    }

                }
                else
                {
                    final += c;
                    i++;
                }


            }
            return final;
        }
        
        //Do math
        private BigInteger DoMath(BigInteger a,BigInteger b,char op)
        {
            switch(op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '÷': return a / (b == 0 ? 1 : b);
                case '×': return a * b;
                default : return a;
            }
        }
    }
}
