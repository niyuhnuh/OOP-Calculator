﻿using System;
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
        Double input1 = 0;
        String operatorUse = ""; 
        
        public Form1()
        {
            InitializeComponent();
        }


        private void clear_Btn_Click(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            txtbxOutput.Text = "0";
            input1 = 0;
            lbl_View.Text = "0";
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            int len = txtbxOutput.TextLength - 1;
            string val = txtbxOutput.Text;
            txtbxOutput.Clear();
            for (int i = 0; i < len; i++)
                txtbxOutput.Text = txtbxOutput.Text + val[i];
                lbl_View.Text = txtbxOutput.Text;

            if (len < 1)
                txtbxOutput.Text = "0";
                lbl_View.Text = "0";
               
        }

        private void numBtn_click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            Button button = (Button)sender;
            txtbxOutput.Text = txtbxOutput.Text + button.Text;
            lbl_View.Text = txtbxOutput.Text;

        }

        private void add_Sign_Click(object sender, EventArgs e)
        {
            operatorUse = add_Sign.Text;
            input1 = Double.Parse(txtbxOutput.Text);
            txtbxOutput.Clear();
            lbl_View.Text = lbl_View.Text + add_Sign.Text;
        }

        private void sub_Sign_Click(object sender, EventArgs e)
        {

            operatorUse = sub_Sign.Text;
            input1 = Double.Parse(txtbxOutput.Text);
            txtbxOutput.Text = "0";
            lbl_View.Text = lbl_View.Text + sub_Sign.Text;
        }

        private void mul_Sign_Click(object sender, EventArgs e)
        {
            operatorUse = mul_Sign.Text;
            input1 = Double.Parse(txtbxOutput.Text);
            txtbxOutput.Text = "0";
            lbl_View.Text = lbl_View.Text + mul_Sign.Text;
        }

        private void div_Sign_Click(object sender, EventArgs e)
        {
            operatorUse = div_Sign.Text;
            input1 = Double.Parse(txtbxOutput.Text);
            txtbxOutput.Text = "0";
            lbl_View.Text = lbl_View.Text + div_Sign.Text;
        }

        private void ce_btn_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = "0";
        }

        private void equals_Btn_Click(object sender, EventArgs e)
        {
            double input2;
            double answer;

            input2 = Double.Parse(txtbxOutput.Text);
            lbl_View.Text = lbl_View.Text + input2;

            switch(operatorUse)
            {
                case "+":
                    answer = (input1 + input2);
                    txtbxOutput.Text = answer.ToString();
                    input1 = answer;
                    lbl_View.Text = txtbxOutput.Text;
                    break;
                case "-":
                    answer = (input1 - input2);
                    txtbxOutput.Text = answer.ToString();
                    input1 = answer;
                    lbl_View.Text = txtbxOutput.Text;
                    break;
                case "*":
                    answer = (input1 * input2);
                    txtbxOutput.Text = answer.ToString();
                    input1 = answer;
                    lbl_View.Text = txtbxOutput.Text;
                    break;
                case "/":
                    if (input2 == 0)
                    {
                        MessageBox.Show("Divide by 0 Error. Please enter a nonzero number.");
                        txtbxOutput.Clear();
                        txtbxOutput.Text = "0";
                        input1 = 0;
                        lbl_View.Text = txtbxOutput.Text;
                    }
                    else
                    {
                        answer = (input1 / input2);
                        txtbxOutput.Text = answer.ToString();
                        input1 = answer;
                        lbl_View.Text = txtbxOutput.Text;
                    }
                    break;

            }
        }

        private void decBtn_click(object sender, EventArgs e)
        {
            if (!txtbxOutput.Text.Contains("."))
            {
                txtbxOutput.Text = txtbxOutput.Text + dec_Btn.Text;
                lbl_View.Text = txtbxOutput.Text;
            }
            else if (txtbxOutput.Text.Contains("."))
            {
                txtbxOutput.Text = txtbxOutput.Text;
                lbl_View.Text = txtbxOutput.Text;
            }

        }
    }
}
