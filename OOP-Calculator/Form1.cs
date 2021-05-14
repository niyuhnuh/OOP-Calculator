using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Calculator
{
    public partial class Form1 : Form
    {
        Double inputValue = 0;
        Double inputValue2 = 0; 
        String operation = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.TextLength > 0)
                txtbxOutput.Text = txtbxOutput.Text.Remove(txtbxOutput.TextLength - 1, 1);

            if (txtbxOutput.Text == "")
                txtbxOutput.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            txtbxOutput.Text = txtbxOutput.Text + "8";
        }

        private void button21_Click(object sender, EventArgs e)
        {
               
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            txtbxOutput.Text = txtbxOutput.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            txtbxOutput.Text = txtbxOutput.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            txtbxOutput.Text = txtbxOutput.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            txtbxOutput.Text = txtbxOutput.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            txtbxOutput.Text = txtbxOutput.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            txtbxOutput.Text = txtbxOutput.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear(); 

            txtbxOutput.Text = txtbxOutput.Text + "7";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            txtbxOutput.Text = txtbxOutput.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = txtbxOutput.Text + "0";
        }

        private void txtbxOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void decimalbtn_Click(object sender, EventArgs e)
        {
           
           txtbxOutput.Text = txtbxOutput.Text + ".";

        }

        private void additionbtn_Click(object sender, EventArgs e)
        {
            operation = "+";
            inputValue = Double.Parse(txtbxOutput.Text);

        }

        private void clearentrybtn_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = "0";
        }

        private void clearallbtn_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = "0";
            inputValue = 0;
        }

        private void subtractbtn_Click(object sender, EventArgs e)
        {
            operation = "-";
            inputValue = Double.Parse(txtbxOutput.Text);
        }

        private void multiplybtn_Click(object sender, EventArgs e)
        {
            operation = "*";
            inputValue = Double.Parse(txtbxOutput.Text);
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            operation = "/";
            inputValue = Double.Parse(txtbxOutput.Text);
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text.Contains("-"))
                txtbxOutput.Text = txtbxOutput.Text.Remove(0, 1);
            else
                txtbxOutput.Text = "-" + txtbxOutput.Text;
        }

        private void equalsbtn_Click(object sender, EventArgs e)
        {
            inputValue2 = Double.Parse(txtbxOutput.Text);

            switch (operation)
            {
                case "+":
                    txtbxOutput.Text = Convert.ToString(inputValue + inputValue2);
                    break;

                case "-":
                    txtbxOutput.Text = Convert.ToString(inputValue - inputValue2);
                    break;

                case "*":
                    txtbxOutput.Text = Convert.ToString(inputValue * inputValue2);
                    break;

                case "/":
                    txtbxOutput.Text = Convert.ToString(inputValue / inputValue2);
                    break;

                default:
                    break;



            }


        }
    }
}
