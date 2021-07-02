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
        Double input1 = 0; //Assigning a double variable for storing the first input 
        Double input2;     //Assigning a double variable for storing the second input
        String operatorUse = ""; //Assigning an empty string for operators to be use in arithmetic operations 
        bool percentIsClicked, fractionIsClicked, sqrtIsClicked = false; //Boolean variables to perform specific operations

        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            txtbxOutput.Text = "0";
            input1 = 0;
            lbl_View.Text = "";
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

        //Start of clear entry button function code
        private void ce_btn_Click(object sender, EventArgs e)
        {
            //Clears the current entry
            txtbxOutput.Text = "0";
            lbl_View.Text = input1.ToString();
        }
        //End of clear entry button function code

        //Start of decimal button function code
        private void decBtn_click(object sender, EventArgs e)
        {
            //This if-else statement checks if the current input already has a decimal in it
            if (!txtbxOutput.Text.Contains("."))
            {
                txtbxOutput.Text = txtbxOutput.Text + dec_Btn.Text;
                lbl_View.Text = txtbxOutput.Text;
            }
            //If it does, the current text would remain
            else if (txtbxOutput.Text.Contains(".")) 
            {
                txtbxOutput.Text = txtbxOutput.Text;
                lbl_View.Text = txtbxOutput.Text;
            }
        }
        //End of decimal button function code

        private void numBtn_click(object sender, EventArgs e)
        {
            //This if statement prevents an excess of zeroes appearing 
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear(); //Clears the zero when a number button is pressed
            //This bit of code sets all the numbers of the buttons
            Button button = (Button)sender;
            txtbxOutput.Text = txtbxOutput.Text + button.Text;
            lbl_View.Text = lbl_View.Text + button.Text;
        }

        //Start of addition operation code
        private void add_Sign_Click(object sender, EventArgs e)
        {
            //This if statement takes care of the successive addition of numbers without pressing the equals button
            if (input1 != 0)
            {
                equals_Btn.PerformClick(); //Calls the code when equals button is pressed
                operatorUse = add_Sign.Text; //Identifies which case to execute in the switch
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + add_Sign.Text;
            }
            else
            {
                //Follows the regular addition syntax
                operatorUse = add_Sign.Text;
                input1 = Double.Parse(txtbxOutput.Text);
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + add_Sign.Text;
            }
        }
        //End of addition operation code

        //Start of subtraction operation code
        private void sub_Sign_Click(object sender, EventArgs e)
        {
            //This if statement takes care of the successive subtraction of numbers without pressing the equals button
            if (input1 != 0)
            {
                equals_Btn.PerformClick(); //Calls the code when equals button is pressed
                operatorUse = sub_Sign.Text; //Identifies which case to execute in the switch
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + sub_Sign.Text;
            }          
            else
            {
                //Follows the regular subtraction syntax
                operatorUse = sub_Sign.Text;
                input1 = Double.Parse(txtbxOutput.Text);
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + sub_Sign.Text;
            }
        }
        //End of subtraction operation code

        //Start of multiplication operation code
        private void mul_Sign_Click(object sender, EventArgs e)
        {
            //This if statement takes care of the successive multiplication of numbers without pressing the equals button
            if (input1 != 0)
            {
                equals_Btn.PerformClick(); //Calls the code when equals button is pressed
                operatorUse = mul_Sign.Text; //Identifies which case to execute in the switch
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + mul_Sign.Text;
            }
         
            else
            {
                //Follows the regular multiplication syntax
                operatorUse = mul_Sign.Text;
                input1 = Double.Parse(txtbxOutput.Text);
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + mul_Sign.Text;
            }
        }
        //End of multiplication operation code

        //Start of division operation code
        private void div_Sign_Click(object sender, EventArgs e)
        {
            //This if statement takes care of the successive division of numbers without pressing the equals button
            if (input1 != 0)
            {
                equals_Btn.PerformClick(); //Calls the code when equals button is pressed
                operatorUse = div_Sign.Text; //Identifies which case to execute in the switch
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + div_Sign.Text;
            }
          
            else
            {
                //Follows the regular division syntax
                operatorUse = div_Sign.Text;
                input1 = Double.Parse(txtbxOutput.Text);
                txtbxOutput.Clear();
                lbl_View.Text = lbl_View.Text + div_Sign.Text;
            }
        }
        //End of division operation code

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

                    case "+": //Addition
                        if (percentIsClicked == false)
                        {
                            answer = input1 + input2;
                            input1 = answer;
                            txtbxOutput.Text = answer.ToString();
                            break;
                        }
                        else
                        {
                            double percent;
                            percent = (input2 / 100) * input1;

                            answer = input1 + percent;
                            input1 = answer;
                            txtbxOutput.Text = answer.ToString();
                            break;
                        }
                  
                    case "-"://Subtraction
                        if (percentIsClicked == false)
                        {
                            answer = (input1 - input2);
                            input1 = answer;
                            txtbxOutput.Text = answer.ToString();
                            break;
                        }
                        else
                        {
                            double percent;
                            percent = (input2 / 100) * input1;

                            answer = input1 - percent;
                            input1 = answer;
                            txtbxOutput.Text = answer.ToString();
                            break;
                        }
                       
                    case "*"://Multiplication
                        if (percentIsClicked == false)
                        {
                            answer = (input1 * input2);
                            input1 = answer;
                            txtbxOutput.Text = answer.ToString();
                            break;
                        }
                        else
                        {
                            double percent;
                            percent = (input2 / 100);

                            answer = input1 * percent; 
                            input1 = answer;
                            txtbxOutput.Text = answer.ToString();
                            break;
                        }
                            
                    case "/": //Division
                        if (input2 != 0)
                        {
                            if (percentIsClicked == false)
                            {
                                answer = (input1 / input2);
                                input1 = answer;
                                txtbxOutput.Text = answer.ToString();
                            }

                            else
                            {
                                double percent;
                                percent = (input2 / 100);

                                answer = (input1 / percent);
                                input1 = answer;
                                txtbxOutput.Text = answer.ToString();
                            }
                                
                        }
                        else
                        {
                            MessageBox.Show("Divide by 0 Error. Please enter a nonzero number.");
                            txtbxOutput.Clear();
                            txtbxOutput.Text = "0";
                            input1 = 0;
                            lbl_View.Text = "Divide by 0 Error";
                        }
                        break;
                }
            }
        }

        private void btn_Percent_Click(object sender, EventArgs e)
        {
            //A boolean variable used to execute the method
            percentIsClicked = true;
        }
        //End of percent button function code


        //Start of positive/negative button function code
        private void btn_PM_Click(object sender, EventArgs e)
        {
            double input5;
            double answer;
            input5 = Double.Parse(txtbxOutput.Text);
            // This if-statement checks if the input is already negative
            if (txtbxOutput.Text.Contains("-"))
            {
                answer = Math.Abs(input5);
                txtbxOutput.Text = answer.ToString();
                lbl_View.Text = answer.ToString();
                
                answer = input1;
            }
            //This checks if the input is 0 and thus cannot be positive nor negative
            else if (input5 == 0)
            {
                txtbxOutput.Text = "0";
                lbl_View.Text = txtbxOutput.Text;

                answer = input1;
            }
            //This is run when the input is positive and will be turned negative
            else
            {
                answer = input5 * -1;
                txtbxOutput.Text = answer.ToString();
                lbl_View.Text = answer.ToString();

                answer = input1;
            }
        }
        //End of positive/negative button function code

        //Start of memory save button function code
        private void btn_MS_Click(object sender, EventArgs e)
        {
            txtbx_Saved1.Visible = true;
            txtbx_Saved1.Text = txtbxOutput.Text;
            txtbxOutput.Text = "0";
            lbl_View.Text = txtbxOutput.Text;
        }
        //End of memory save button function code

        //Start of memory clear button function code
        private void btn_MC_Click(object sender, EventArgs e)
        {
            txtbx_Saved1.Clear();
        }
        //End of memory clear button function code

        //Start of memory recall button function code
        private void btn_MR_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = txtbx_Saved1.Text;
            lbl_View.Text = txtbxOutput.Text;
        }
        //End of memory recall button function code

        //Start of memory plus button function code
        private void btn_Mplus_Click(object sender, EventArgs e)
        {
            double input5 = Double.Parse(txtbx_Saved1.Text);
            double answer;
            answer = Double.Parse(lbl_View.Text) + input5;
            txtbxOutput.Text = answer.ToString();
            lbl_View.Text = txtbxOutput.Text;
        }
        //End of memory plus button function code

        //Start of memory minus button function code
        private void btn_Mminus_Click(object sender, EventArgs e)
        {  
            double input5 = Double.Parse(txtbx_Saved1.Text);
            double answer;
            answer = (Double.Parse(lbl_View.Text) - input5);
            txtbxOutput.Text = answer.ToString();
            lbl_View.Text = txtbxOutput.Text;
        }
        //End of memory minus button function code

        //Start of memory save textbox function code
        private void txtbx_Saved1_TextChanged(object sender, EventArgs e)
        { 
             btn_Mminus.Enabled = true;
             btn_Mplus.Enabled = true;
             btn_MR.Enabled = true;
             btn_MC.Enabled = true;     
        }
        //End of memory save textbox function code

        //Start of Keypress event
        private void txtbxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Checks if the key pressed is a digit and a control
            //Does not need to check if its a number from the top of the keyboard or from the numpad
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbl_View.Text = txtbxOutput.Text;
 
            }
        }
        //End of Keypress event

        //Start of txtbxOutput Click event
        private void txtbxOutput_Click(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            lbl_View.Text = txtbxOutput.Text;
        }
        //End of txtbxOutput Click event


        //Start of square root function code
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
        //End of square root function code

        //Start of fractiom function code
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
        //End of fractiom function code
    }
}
