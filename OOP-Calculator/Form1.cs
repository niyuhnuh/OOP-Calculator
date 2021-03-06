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
        Double input1 = 0; 
        Double input2;     
        String operatorUse = ""; 
        bool percentIsClicked, fractionIsClicked, sqrtIsClicked, retrieved = false; 

        public Form1()
        {
            InitializeComponent();
        }
        operationsClass operation = new operationsClass();
        private void clear_Btn_Click(object sender, EventArgs e)
        {
            var sequence = lbl_View.Text;
            var final = txtbxOutput.Text;
            rtxtbx_History.SelectAll();
            rtxtbx_History.SelectionAlignment = HorizontalAlignment.Right;

            if (rtxtbx_History.Text == "")
            {
                rtxtbx_History.Text = sequence + " =" + "\n" + final;
            }
            else
            {
                rtxtbx_History.AppendText("\n \n" + sequence + " =" + "\n" + final);
            }

            txtbxOutput.Clear();
            txtbxOutput.Text = "0";
            input1 = 0;
            lbl_View.Text = "";
            operatorUse = "";
            btn_MC.Enabled = false;
            btn_MR.Enabled = false;
            btn_Mplus.Enabled = false;
            btn_Mminus.Enabled = false;
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            int len = txtbxOutput.TextLength - 1;
            string val = txtbxOutput.Text;
            txtbxOutput.Clear();

            for (int i = 0; i < len; i++)
            {
                txtbxOutput.Text = txtbxOutput.Text + val[i];
                lbl_View.Text = lbl_View.Text + val[i];
            }

            if (len < 1)
                txtbxOutput.Text = "0";
                lbl_View.Text = "";             
        }

        private void ce_btn_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = "0";
        }

        private void decBtn_click(object sender, EventArgs e)
        {
            if (!txtbxOutput.Text.Contains("."))
            {
                txtbxOutput.Text = txtbxOutput.Text + dec_Btn.Text;
                lbl_View.Text = lbl_View.Text + dec_Btn.Text;
            }
            else if (txtbxOutput.Text.Contains(".")) 
            {
                txtbxOutput.Text = txtbxOutput.Text;
                lbl_View.Text = lbl_View.Text + dec_Btn.Text;
            }
        }

        private void numBtn_click(object sender, EventArgs e)
        {    
            if (txtbxOutput.Text == "0")
            {
                txtbxOutput.Clear();
                lbl_View.Text = "";
            }
 
            Button button = (Button)sender;
            txtbxOutput.Text = txtbxOutput.Text + button.Text;
            lbl_View.Text = lbl_View.Text + button.Text;
        }

        private void add_Sign_Click(object sender, EventArgs e)
        {
            if (input1 != 0)
            {
                double answer;
                answer = input1 + Double.Parse(txtbxOutput.Text);
                input1 = answer;
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + add_Sign.Text;                
            }
            else
            {
                operatorUse = add_Sign.Text;
                input1 = Double.Parse(txtbxOutput.Text);
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + add_Sign.Text;
            }
        }

        private void sub_Sign_Click(object sender, EventArgs e)
        {
            if (input1 != 0)
            {
                double answer;
                answer = input1 - Double.Parse(txtbxOutput.Text);
                input1 = answer;
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + sub_Sign.Text;
            }
            else
            {
                operatorUse = sub_Sign.Text;
                input1 = Double.Parse(txtbxOutput.Text);
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + sub_Sign.Text;
            }
        }

        private void mul_Sign_Click(object sender, EventArgs e)
        {
            if (input1 != 0)
            {
                double answer;
                answer = input1 * Double.Parse(txtbxOutput.Text);
                input1 = answer;
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + mul_Sign.Text;
            }
            else
            {
                operatorUse = mul_Sign.Text;
                input1 = Double.Parse(txtbxOutput.Text);
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + mul_Sign.Text;
            }
        }

        private void div_Sign_Click(object sender, EventArgs e)
        {
            if (input1 != 0)
            {
                double answer;
                answer = input1 / Double.Parse(txtbxOutput.Text);
                input1 = answer;
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + div_Sign.Text;
            }
            else
            {
                operatorUse = div_Sign.Text;
                input1 = Double.Parse(txtbxOutput.Text);
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + div_Sign.Text;
            }
        }
 
        private void equals_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                input2 = Double.Parse(txtbxOutput.Text);
                operation.input1 = input1;
                operation.input2 = input2;
            }
            catch(System.FormatException)
            {
                input2 = 1;
            }
            finally
            {
                switch (operatorUse)
                {
                    case "+": //Addition
                        operation.percentIsClicked = percentIsClicked;
                        operation.sqrtIsClicked = sqrtIsClicked;
                        operation.txtbx_Output = txtbxOutput.Text;
                        operation.lbl_View = lbl_View.Text;
                        operation.Addition();
                        lbl_View.Text = operation.lbl_View;
                        txtbxOutput.Text = operation.txtbx_Output;
                        break;
                    case "-"://Subtraction
                        operation.percentIsClicked = percentIsClicked;
                        operation.txtbx_Output = txtbxOutput.Text;
                        operation.lbl_View = lbl_View.Text;
                        operation.Subtraction();
                        lbl_View.Text = operation.lbl_View;
                        txtbxOutput.Text = operation.txtbx_Output;
                        break;
                    case "*"://Multiplication
                        operation.percentIsClicked = percentIsClicked;
                        operation.txtbx_Output = txtbxOutput.Text;
                        operation.lbl_View = lbl_View.Text;
                        operation.Multiplication();
                        lbl_View.Text = operation.lbl_View;
                        txtbxOutput.Text = operation.txtbx_Output;
                        break;
                    case "/": //Division
                        operation.percentIsClicked = percentIsClicked;
                        operation.txtbx_Output = txtbxOutput.Text;
                        operation.lbl_View = lbl_View.Text;
                        operation.Division();
                        lbl_View.Text = operation.lbl_View;
                        txtbxOutput.Text = operation.txtbx_Output;
                        break;
                }
            }
        }

        private void btn_Percent_Click(object sender, EventArgs e)
        {
            percentIsClicked = true;
        }

        private void btn_PM_Click(object sender, EventArgs e)
        {
            double input2;
            double answer;
            input2 = Double.Parse(txtbxOutput.Text);

            if (txtbxOutput.Text.Contains("-"))
            {
                answer = Math.Abs(input2);
                txtbxOutput.Text = answer.ToString();
                lbl_View.Text = lbl_View.Text + "[" + answer + "]";
                answer = input1;
            }
            else if (input2 == 0)
            {
                txtbxOutput.Text = "0";
                lbl_View.Text = "";
                answer = input1;
            }
            else
            {
                answer = input2 * -1;
                txtbxOutput.Text = answer.ToString();
                lbl_View.Text = lbl_View.Text + "[" + answer + "]";
                answer = input1;
            }
        }

        private void btn_MS_Click(object sender, EventArgs e)
        {
            lst_Memory.Items.Add(txtbxOutput.Text);
            txtbxOutput.Text = "0";
            lbl_View.Text = "";
            retrieved = true;
            btn_Mminus.Enabled = true;
            btn_Mplus.Enabled = true;
            btn_MR.Enabled = true;
            btn_MC.Enabled = true;
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            lst_Memory.Items.Clear();
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
            if (retrieved == true)
            {
                txtbxOutput.Clear();
                string recall = lst_Memory.SelectedItem.ToString();
                txtbxOutput.Text = txtbxOutput.Text + double.Parse(recall).ToString();
                lbl_View.Text = lbl_View.Text + double.Parse(recall).ToString();
                retrieved = false;
            }
        }

        private void btn_Mplus_Click(object sender, EventArgs e)
        {
            double input = double.Parse(lst_Memory.SelectedItem.ToString());
            double answer;
            answer = (Double.Parse(txtbxOutput.Text) + input);
            txtbxOutput.Text = answer.ToString();
            lbl_View.Text = lbl_View.Text + add_Sign.Text + lst_Memory.SelectedItem;
        }

        private void btn_Mminus_Click(object sender, EventArgs e)
        {
            double input = Double.Parse(lst_Memory.SelectedItem.ToString());
            double answer;
            answer = (Double.Parse(txtbxOutput.Text) - input);
            txtbxOutput.Text = answer.ToString();
            lbl_View.Text = lbl_View.Text + sub_Sign.Text + lst_Memory.SelectedItem;
        }

        private void txtbxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbl_View.Text = txtbxOutput.Text;
            }
        }

        private void txtbxOutput_Click(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            lbl_View.Text = txtbxOutput.Text;
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            sqrtIsClicked = true;
            lbl_View.Text = "";
            double input4;
            double answer;
            input4 = Double.Parse(txtbxOutput.Text);

            if (input4 >= 0 && sqrtIsClicked == true && !(operatorUse == ""))
            {
                lbl_View.Text = "";
                answer = Math.Sqrt(input4);
                lbl_View.Text = lbl_View.Text + "√" + input4 + operatorUse;
                input1 = answer;
                txtbxOutput.Text = answer.ToString();
            }
            if (input4 < 0 && sqrtIsClicked == true)
            {
                MessageBox.Show("Math error. Imaginary number. Please input a real number.");
                txtbxOutput.Clear();
                txtbxOutput.Text = "0";
                input1 = 0;
            }
            else if (input4 >= 0 && sqrtIsClicked == true)
            {
                answer = Math.Sqrt(input4);
                lbl_View.Text = lbl_View.Text + "√" + input4;
                txtbxOutput.Text = answer.ToString();
            }
        }

        private void btn_Frac_Click(object sender, EventArgs e)
        {
            fractionIsClicked = true;
            lbl_View.Text = "";
            double answer;
            double input3 = Double.Parse(txtbxOutput.Text);
            answer = (1 / input3);
            lbl_View.Text = lbl_View.Text + answer;
            txtbxOutput.Text = answer.ToString();

            if (fractionIsClicked == true && operatorUse == "+")
            {       
                add_Sign.PerformClick();
                fractionIsClicked = false;
                input1 = answer;
            }
            if (fractionIsClicked == true && operatorUse == "-")
            {
                sub_Sign.PerformClick();
                fractionIsClicked = false;
                input1 = answer;
            }
            if (fractionIsClicked == true && operatorUse == "*")
            {
                mul_Sign.PerformClick();
                fractionIsClicked = false;
                input1 = answer;
            }
            if (fractionIsClicked == true && operatorUse == "/")
            {
                div_Sign.PerformClick();
                fractionIsClicked = false;
                input1 = answer;
            }

        }
    }
}
