using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator_hw
{
    public partial class Form1 : Form
    {
        public static double act;
        public static double pos;
        public static double ans;
        public static string active="";

        public static string postive = "";

        public static string answer = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button8.Text = "0";
            button1.Text = "7";
            button2.Text = "4";
            button3.Text = "1";
            button4.Text = "off";
            button5.Text = "8";
            button6.Text = "5";
            button7.Text = "2";
            button9.Text = "9";
            button10.Text = "6";
            button11.Text = "3";
            button12.Text = ".";
            button13.Text = "+";
            button14.Text = "-";
            button15.Text = "x";
            button16.Text = "/";
            button17.Text = "AC";
            button18.Text = "=";
            label4.Text = "你好我是計算機";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                label1.Text = button13.Text;
                label2.Text = label3.Text;
                label3.Text = "";
                active = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
                if (label3.Text != "")
                {
                    label1.Text = button14.Text;
                    label2.Text = label3.Text;
                    label3.Text = "";
                    active = "";
                }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                label1.Text = button15.Text;
                label2.Text = label3.Text;
                label3.Text = "";
                active = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                label1.Text = button16.Text;
                label2.Text = label3.Text;
                label3.Text = "";
                active = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {   
            active = active + button8.Text;
            label3.Text = active;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            active = active + button3.Text;
            label3.Text = active;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            active = active + button7.Text;
            label3.Text = active;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            active = active + button11.Text;
            label3.Text = active;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            active = active + button2.Text;
            label3.Text = active;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            active = active + button6.Text;
            label3.Text = active;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            active = active + button10.Text;
            label3.Text = active;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            active = active + button1.Text;
            label3.Text = active;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            active = active + button5.Text;
            label3.Text = active;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            active = active + button9.Text;
            label3.Text = active;
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
            act = Convert.ToDouble(label2.Text);
            pos = Convert.ToDouble(label3.Text);
            
            //        label1.Text
            switch (label1.Text)
            {
                case "+":
                    ans = act + pos;
                    break;
                case "-":
                    ans = act - pos;
                    break;
                case "x":
                    ans = pos * act;
                    break;
                case "/":
                    ans = act / pos;
                    break;
            }
            label2.Text = label2.Text + " " + label1.Text + " " + label3.Text + " = " + ans.ToString() ;
            label1.Text = "";
            label3.Text = "";
            active = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            active = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            active = active + button12.Text;
            label3.Text = active;
        }
    }
}
