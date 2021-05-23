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
        Double value = 0;  
        
        public Form1()
        {
            InitializeComponent();
        }


        private void clear_Btn_Click(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            txtbxOutput.Text = "0";
            value = 0; 
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            int len = txtbxOutput.TextLength - 1;
            string val = txtbxOutput.Text;
            txtbxOutput.Clear();
            for (int i = 0; i < len; i++)
                txtbxOutput.Text = txtbxOutput.Text + val[i];

            if (len < 1)
                txtbxOutput.Text = "0";
               
        }

        private void numBtn_click(object sender, EventArgs e)
        {
            if (txtbxOutput.Text == "0")
                txtbxOutput.Clear();

            Button button = (Button)sender;
            txtbxOutput.Text = txtbxOutput.Text + button.Text;

        }

        private void add_Sign_Click(object sender, EventArgs e)
        {

        }

        private void sub_Sign_Click(object sender, EventArgs e)
        {

        }

        private void mul_Sign_Click(object sender, EventArgs e)
        {

        }

        private void div_Sign_Click(object sender, EventArgs e)
        {

        }
    }
}
