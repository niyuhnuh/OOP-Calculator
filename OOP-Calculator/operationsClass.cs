using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Calculator
{
    class operationsClass
    {
        public string txtbx_Output, lbl_View;
        public double input1 = 0;
        public double input2, answer;
        public bool percentIsClicked, sqrtIsClicked = false;

        public void Addition()
        {
            if (percentIsClicked == false)
            {
                answer = input1 + Double.Parse(txtbx_Output);
                input1 = answer;
                txtbx_Output = answer.ToString();
            }
            else
            {
                double percent;
                percent = (Double.Parse(txtbx_Output) / 100) * input1;

                answer = input1 + percent;
                input1 = answer;
                txtbx_Output = answer.ToString();
                lbl_View = lbl_View + "[" + percent + "]";
            }
        }

        public void Subtraction()
        {
            if (percentIsClicked == false)
            {
                answer = (input1 - input2);
                input1 = answer;
                txtbx_Output = answer.ToString();
            }
            else
            {
                double percent;
                percent = (input2 / 100) * input1;

                answer = input1 - percent;
                input1 = answer;
                txtbx_Output = answer.ToString();
                lbl_View = lbl_View + "[" + percent + "]";
            }
        }

        public void Multiplication()
        {
            if (percentIsClicked == false)
            {
                answer = (input1 * input2);
                input1 = answer;
                txtbx_Output = answer.ToString();
            }
            else
            {
                double percent;
                percent = (input2 / 100);

                answer = input1 * percent;
                input1 = answer;
                txtbx_Output = answer.ToString();
                lbl_View = lbl_View + "[" + percent + "]";
            }
        }

        public void Division()
        {
            if (input2 != 0)
            {
                if (percentIsClicked == false)
                {
                    answer = (input1 / input2);
                    input1 = answer;
                    txtbx_Output = answer.ToString();
                }

                else
                {
                    double percent;
                    percent = (input2 / 100);

                    answer = (input1 / percent);
                    input1 = answer;
                    txtbx_Output = answer.ToString();
                    lbl_View = lbl_View + "[" + percent + "]";
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Divide by 0 Error. Please enter a nonzero number.");
                txtbx_Output = "0";
                input1 = 0;
                lbl_View = "Divide by 0 Error";
            }
        }
    }
}
