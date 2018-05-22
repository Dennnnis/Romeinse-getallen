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
    public partial class Form1 : Form
    {
        //Key to make searching easier
        class Key
        {
            public Key(string roman,BigInteger interger)
            {
                r = roman;
                i = interger;
            }

            public Key(string roman,string extra, BigInteger interger)
            {
                r = roman;
                i = interger;
                e = extra;
            }

            public string r = string.Empty;
            public string e = string.Empty; 
            public BigInteger i = 0; 
        }

        //Info
        char mathOperator = '+';
        int currentBox = 1;

        //Top box
        List<string> box1 = new List<string>();

        //Bottom box
        List<string> box2 = new List<string>();

        //Anwser box (can't be current box for obvious reasons)
        List<string> box3 = new List<string>(); 
        
        //List of keys
        List<Key> dictonary = new List<Key>();

        public Form1()
        {
            InitializeComponent();

            //Create a roman table
            dictonary.Add(new Key("I1", 1)); dictonary.Add(new Key("I1", "V1", 4));
            dictonary.Add(new Key("V1", 5)); dictonary.Add(new Key("I1", "X1", 9));

            for (int i = 1; i < 1000; i++)
            {
                //M is the multiplier of the current iterator
                //I is the current iterator
                //N is the next iterator
                //T is the multiplier of the next iterator

                int n = i + 1;
                BigInteger m = System.Numerics.BigInteger.Pow(1000, i-1);
                BigInteger t = System.Numerics.BigInteger.Pow(1000, n-1);

                dictonary.Add(new Key("X" + i.ToString() , 10   * m)); dictonary.Add(new Key("X" + i.ToString(), "L" + i.ToString(), 40   * m));
                dictonary.Add(new Key("L" + i.ToString() , 50   * m)); dictonary.Add(new Key("X" + i.ToString(), "C" + i.ToString(), 90   * m));
                dictonary.Add(new Key("C" + i.ToString() , 100  * m)); dictonary.Add(new Key("C" + i.ToString(), "D" + i.ToString(), 400  * m));
                dictonary.Add(new Key("D" + i.ToString() , 500  * m)); dictonary.Add(new Key("C" + i.ToString(), "M" + i.ToString(), 900  * m));
                dictonary.Add(new Key("M" + i.ToString() , 1000 * m)); dictonary.Add(new Key("M" + i.ToString(), "V" + n.ToString(), 4000 * m));

                dictonary.Add(new Key("V" + n.ToString() , 5    * t)); dictonary.Add(new Key("M" + i.ToString(), "X" + n.ToString(), 9000 * m));
            }
        }

        //Gets the current box
        ref List<string> GetBox()
        {
            if (currentBox == 1)
            {
                return ref box1;
            }
            else
            {
                return ref box2;
            }
        }

        //Update boxes
        void UpdateBoxes()
        {
            //Calculate box3
            box3 = IntToRoman(DoMath(RomanToInt(box1), RomanToInt(box2), mathOperator));

            label5.Text = mathOperator.ToString();

            label2.Text = RomanToInt(box1).ToString() == "0" ? string.Empty : RomanToInt(box1).ToString();
            label3.Text = RomanToInt(box2).ToString() == "0" ? string.Empty : RomanToInt(box2).ToString();
            label4.Text = RomanToInt(box3).ToString() == "0" ? string.Empty : RomanToInt(box3).ToString();

            textBox1.Text = string.Empty;
            foreach (string s in box1)
            {
                textBox1.Text += Readable(s);
            }

            textBox2.Text = string.Empty;
            foreach (string s in box2)
            {
                textBox2.Text += Readable(s);
            }

            textBox3.Text = string.Empty;
            foreach (string s in box3)
            {
                textBox3.Text += Readable(s);
            }
        }

        //Text converter
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 0 && textBox5.Text.All(char.IsDigit))
            {
                BigInteger i = BigInteger.Parse(textBox5.Text);
                textBox1.Text = Ltos(IntToRoman(i));
                GetBox() = IntToRoman(i);
                UpdateBoxes();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            GetBox().Clear();
            UpdateBoxes();
        }
    }
}
