using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romeinse_getallen
{
    public partial class Form1 
    {

        private void button1_Click(object sender, EventArgs e)
        {
            GetBox().Add("I1");
            UpdateBoxes();
        }

        //T1
        private void button2_Click(object sender, EventArgs e)
        {
            GetBox().Add("V1");
            UpdateBoxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetBox().Add("X1");
            UpdateBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetBox().Add("L1");
            UpdateBoxes();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetBox().Add("C1");
            UpdateBoxes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetBox().Add("D1");
            UpdateBoxes();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetBox().Add("M1");
            UpdateBoxes();
        }

        //T2
        private void button17_Click(object sender, EventArgs e)
        {
            GetBox().Add("V2");
            UpdateBoxes();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            GetBox().Add("X2");
            UpdateBoxes();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetBox().Add("L2");
            UpdateBoxes();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetBox().Add("C2");
            UpdateBoxes();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetBox().Add("D2");
            UpdateBoxes();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetBox().Add("M2");
            UpdateBoxes();
        }


        //T3
        private void button23_Click(object sender, EventArgs e)
        {
            GetBox().Add("V3");
            UpdateBoxes();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            GetBox().Add("X3");
            UpdateBoxes();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            GetBox().Add("L3");
            UpdateBoxes();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            GetBox().Add("C3");
            UpdateBoxes();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GetBox().Add("M3");
            UpdateBoxes();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            GetBox().Add("D3");
            UpdateBoxes();
        }

        //T4

        private void button29_Click(object sender, EventArgs e)
        {
            GetBox().Add("V4");
            UpdateBoxes();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            GetBox().Add("X4");
            UpdateBoxes();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            GetBox().Add("L4");
            UpdateBoxes();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            GetBox().Add("C4");
            UpdateBoxes();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            GetBox().Add("D4");
            UpdateBoxes();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            GetBox().Add("M4");
            UpdateBoxes();
        }


        private void button30_Click(object sender, EventArgs e)
        {
            currentBox = 1;
            button31.BackColor = System.Drawing.SystemColors.Window;
            button30.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            currentBox = 2;
            button31.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button30.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mathOperator = '-';
            UpdateBoxes();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mathOperator = '÷';
            UpdateBoxes();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mathOperator = '×';
            UpdateBoxes();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mathOperator = '+';
            UpdateBoxes();
        }
    }
}
