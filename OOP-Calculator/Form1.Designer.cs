
namespace OOP_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dividebtn = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtbxOutput = new System.Windows.Forms.TextBox();
            this.clear_Btn = new System.Windows.Forms.Button();
            this.ce_btn = new System.Windows.Forms.Button();
            this.add_Sign = new System.Windows.Forms.Button();
            this.sub_Sign = new System.Windows.Forms.Button();
            this.mul_Sign = new System.Windows.Forms.Button();
            this.div_Sign = new System.Windows.Forms.Button();
            this.equals_Btn = new System.Windows.Forms.Button();
            this.back_Btn = new System.Windows.Forms.Button();
            this.dec_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dividebtn
            // 
            this.dividebtn.BackColor = System.Drawing.SystemColors.Control;
            this.dividebtn.Location = new System.Drawing.Point(874, 514);
            this.dividebtn.Name = "dividebtn";
            this.dividebtn.Size = new System.Drawing.Size(119, 61);
            this.dividebtn.TabIndex = 7;
            this.dividebtn.Text = "/";
            this.dividebtn.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(122, 218);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 47);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(67, 218);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 47);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 218);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 47);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(67, 170);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(49, 47);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 170);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 47);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(122, 170);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 47);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(67, 122);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 47);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 122);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 47);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(122, 122);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 47);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 267);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 48);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numBtn_click);
            // 
            // txtbxOutput
            // 
            this.txtbxOutput.Location = new System.Drawing.Point(12, 46);
            this.txtbxOutput.Name = "txtbxOutput";
            this.txtbxOutput.Size = new System.Drawing.Size(214, 23);
            this.txtbxOutput.TabIndex = 19;
            this.txtbxOutput.Text = "0";
            this.txtbxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clear_Btn
            // 
            this.clear_Btn.Location = new System.Drawing.Point(67, 73);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(49, 47);
            this.clear_Btn.TabIndex = 22;
            this.clear_Btn.Text = "C";
            this.clear_Btn.UseVisualStyleBackColor = true;
            this.clear_Btn.Click += new System.EventHandler(this.clear_Btn_Click);
            // 
            // ce_btn
            // 
            this.ce_btn.Location = new System.Drawing.Point(12, 73);
            this.ce_btn.Name = "ce_btn";
            this.ce_btn.Size = new System.Drawing.Size(49, 47);
            this.ce_btn.TabIndex = 21;
            this.ce_btn.Text = "CE";
            this.ce_btn.UseVisualStyleBackColor = true;
            this.ce_btn.Click += new System.EventHandler(this.ce_btn_Click);
            // 
            // add_Sign
            // 
            this.add_Sign.Location = new System.Drawing.Point(176, 268);
            this.add_Sign.Name = "add_Sign";
            this.add_Sign.Size = new System.Drawing.Size(49, 47);
            this.add_Sign.TabIndex = 20;
            this.add_Sign.Text = "+";
            this.add_Sign.UseVisualStyleBackColor = true;
            this.add_Sign.Click += new System.EventHandler(this.add_Sign_Click);
            // 
            // sub_Sign
            // 
            this.sub_Sign.Location = new System.Drawing.Point(176, 218);
            this.sub_Sign.Name = "sub_Sign";
            this.sub_Sign.Size = new System.Drawing.Size(49, 47);
            this.sub_Sign.TabIndex = 23;
            this.sub_Sign.Text = "-";
            this.sub_Sign.UseVisualStyleBackColor = true;
            this.sub_Sign.Click += new System.EventHandler(this.sub_Sign_Click);
            // 
            // mul_Sign
            // 
            this.mul_Sign.Location = new System.Drawing.Point(176, 170);
            this.mul_Sign.Name = "mul_Sign";
            this.mul_Sign.Size = new System.Drawing.Size(49, 47);
            this.mul_Sign.TabIndex = 24;
            this.mul_Sign.Text = "*";
            this.mul_Sign.UseVisualStyleBackColor = true;
            this.mul_Sign.Click += new System.EventHandler(this.mul_Sign_Click);
            // 
            // div_Sign
            // 
            this.div_Sign.Location = new System.Drawing.Point(176, 122);
            this.div_Sign.Name = "div_Sign";
            this.div_Sign.Size = new System.Drawing.Size(49, 47);
            this.div_Sign.TabIndex = 25;
            this.div_Sign.Text = "/";
            this.div_Sign.UseVisualStyleBackColor = true;
            this.div_Sign.Click += new System.EventHandler(this.div_Sign_Click);
            // 
            // equals_Btn
            // 
            this.equals_Btn.Location = new System.Drawing.Point(68, 268);
            this.equals_Btn.Name = "equals_Btn";
            this.equals_Btn.Size = new System.Drawing.Size(103, 47);
            this.equals_Btn.TabIndex = 26;
            this.equals_Btn.Text = "=";
            this.equals_Btn.UseVisualStyleBackColor = true;
            this.equals_Btn.Click += new System.EventHandler(this.equals_Btn_Click);
            // 
            // back_Btn
            // 
            this.back_Btn.Location = new System.Drawing.Point(176, 73);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(49, 47);
            this.back_Btn.TabIndex = 27;
            this.back_Btn.Text = "<-";
            this.back_Btn.UseVisualStyleBackColor = true;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // dec_Btn
            // 
            this.dec_Btn.Location = new System.Drawing.Point(122, 73);
            this.dec_Btn.Name = "dec_Btn";
            this.dec_Btn.Size = new System.Drawing.Size(49, 47);
            this.dec_Btn.TabIndex = 28;
            this.dec_Btn.Text = ".";
            this.dec_Btn.UseVisualStyleBackColor = true;
            this.dec_Btn.Click += new System.EventHandler(this.decBtn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dec_Btn);
            this.Controls.Add(this.back_Btn);
            this.Controls.Add(this.equals_Btn);
            this.Controls.Add(this.div_Sign);
            this.Controls.Add(this.mul_Sign);
            this.Controls.Add(this.sub_Sign);
            this.Controls.Add(this.clear_Btn);
            this.Controls.Add(this.ce_btn);
            this.Controls.Add(this.add_Sign);
            this.Controls.Add(this.txtbxOutput);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.dividebtn);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dividebtn;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtbxOutput;
        private System.Windows.Forms.Button clear_Btn;
        private System.Windows.Forms.Button ce_btn;
        private System.Windows.Forms.Button add_Sign;
        private System.Windows.Forms.Button sub_Sign;
        private System.Windows.Forms.Button mul_Sign;
        private System.Windows.Forms.Button div_Sign;
        private System.Windows.Forms.Button equals_Btn;
        private System.Windows.Forms.Button back_Btn;
        private System.Windows.Forms.Button dec_Btn;
        private System.Windows.Forms.Label label1;
    }
}

