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
        bool percentIsClicked, fractionIsClicked, sqrtIsClicked = false;

        
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
            if (input1 != 0)
            {
                equals_Btn.PerformClick();
                operatorUse = add_Sign.Text;
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
                equals_Btn.PerformClick();
                operatorUse = sub_Sign.Text;
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
                equals_Btn.PerformClick();
                operatorUse = mul_Sign.Text;
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
                equals_Btn.PerformClick();
                operatorUse = div_Sign.Text;
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

        private void ce_btn_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = "0";
            lbl_View.Text = input1.ToString();
        }

        private void equals_Btn_Click(object sender, EventArgs e)
        {

            double answer;


            try
            {
                input2 = Double.Parse(txtbxOutput.Text);
            }
            catch(System.FormatException)
            {
                input2 = 1;
            }
            finally
            {

                switch (operatorUse)
                {

                    case "+":
                        if (percentIsClicked == false)
                        {
                            answer = input1 + input2;
                            lbl_View.Text = answer.ToString();
                            input1 = answer;
                            txtbxOutput.Text = "0";
                            break;
                        }
                        else
                        {
                            double percent;
                            percent = (input2 / 100) * input1;

                            answer = input1 + percent;
                            lbl_View.Text = answer.ToString();
                            input1 = answer;
                            txtbxOutput.Text = "0";
                            break;
                        }
                  

                    case "-":
                        if (percentIsClicked == false)
                        {
                            answer = (input1 - input2);
                            lbl_View.Text = answer.ToString();
                            input1 = answer;
                            txtbxOutput.Text = "0";
                            break;
                        }
                        else
                        {
                            double percent;
                            percent = (input2 / 100) * input1;

                            answer = input1 - percent;
                            lbl_View.Text = answer.ToString();
                            input1 = answer;
                            txtbxOutput.Text = "0";
                            break;
                        }
                       
                    case "*":
                        if (percentIsClicked == false)
                        {
                            answer = (input1 * input2);
                            lbl_View.Text = answer.ToString();
                            input1 = answer;
                            txtbxOutput.Text = "0";
                            break;
                        }
                        else
                        {
                            double percent;
                            percent = (input2 / 100);

                            answer = input1 * percent;
                            lbl_View.Text = answer.ToString();
                            input1 = answer;
                            txtbxOutput.Text = "0";
                            break;
                        }
                            
                    case "/":
                        if (input2 != 0)
                        {
                            if (percentIsClicked == false)
                            {
                                answer = (input1 / input2);
                                lbl_View.Text = answer.ToString();
                                input1 = answer;
                                txtbxOutput.Clear();
                            }
                            else
                            {
                                double percent;
                                percent = (input2 / 100);

                                answer = input1 / percent;
                                lbl_View.Text = answer.ToString();
                                input1 = answer;
                                txtbxOutput.Clear();
                            }
                                
                        }
                        else
                        {
                            MessageBox.Show("Divide by 0 Error. Please enter a nonzero number.");
                            txtbxOutput.Clear();
                            txtbxOutput.Text = "0";
                            input1 = 0;
                            lbl_View.Text = txtbxOutput.Text;
                        }
                        break;
                }
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

        private void btn_Percent_Click(object sender, EventArgs e)
        {
            percentIsClicked = true;
        }

        private void btn_PM_Click(object sender, EventArgs e)
        {
            double input5;
            double answer;
       
            input5 = Double.Parse(txtbxOutput.Text);


            if (txtbxOutput.Text.Contains("-"))
            {
                answer = Math.Abs(input5);
                txtbxOutput.Text = answer.ToString();
                lbl_View.Text = answer.ToString();
                
                answer = input1;
            }
            else if (input5 == 0)
            {
                txtbxOutput.Text = "0";
                lbl_View.Text = txtbxOutput.Text;

                answer = input1;
            }
            else
            {
                answer = input5 * -1;
                txtbxOutput.Text = answer.ToString();
                lbl_View.Text = answer.ToString();

                answer = input1;
            }
        }

        private void btn_MS_Click(object sender, EventArgs e)
        {
            lstbox_Memory.Items.Add(txtbxOutput.Text);
            txtbxOutput.Clear();
            lbl_View.Text = txtbxOutput.Text;
        }


        private void btn_MC_Click(object sender, EventArgs e)
        {
            lstbox_Memory.Items.Clear();
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
            if (lstbox_Memory.SelectedIndex != -1)
            {
                int j = lstbox_Memory.SelectedIndex;
                string item_Selected = lstbox_Memory.Items[j].ToString();
                txtbxOutput.Text = item_Selected;
                lbl_View.Text = txtbxOutput.Text;
            }
            else
            {
                string input = lstbox_Memory.Items.ToString();
                List<string> saved = new List<string> {input};

                //int i = lstbox_Memory.Count 
                //string input = lstbox_Memory.Items[i].ToString();
                //txtbxOutput.Text = input;
                //lbl_View.Text = txtbxOutput.Text;
            }
        }

        private void btn_Mplus_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            sqrtIsClicked = true;
            lbl_View.Text = "";
            double input4;
            double answer;
            input4 = Double.Parse(txtbxOutput.Text);

            if (input4 < 0 && sqrtIsClicked == true)
            {
                MessageBox.Show("Math error. Imaginary number. Please input a real number.");
                txtbxOutput.Clear();
                txtbxOutput.Text = "0";
                input1 = 0;
            }
            else if(input4 >= 0 && sqrtIsClicked == true)
            {
                answer = Math.Sqrt(input4);
                lbl_View.Text = "√" + input4;
                txtbxOutput.Text = answer.ToString();
            }
        }

        private void btn_Frac_Click(object sender, EventArgs e)
        {
            fractionIsClicked = true;
            
            double input3;
            input3 = Double.Parse(txtbxOutput.Text);

            if (fractionIsClicked == true)
            {
                double answer;
                answer = (1 / input3);
                lbl_View.Text = "(1/" + input3 + ")";
                txtbxOutput.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("Divide by 0 Error. Please enter a nonzero number.");
                txtbxOutput.Clear();
                txtbxOutput.Text = "0";
                input1 = 0;
                lbl_View.Text = txtbxOutput.Text;
            }
        }
    }
}
