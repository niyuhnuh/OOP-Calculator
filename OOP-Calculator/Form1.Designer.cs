
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
            this.lbl_View = new System.Windows.Forms.Label();
            this.btn_Percent = new System.Windows.Forms.Button();
            this.btn_MS = new System.Windows.Forms.Button();
            this.btn_Mplus = new System.Windows.Forms.Button();
            this.btn_Frac = new System.Windows.Forms.Button();
            this.btn_Mminus = new System.Windows.Forms.Button();
            this.btn_MC = new System.Windows.Forms.Button();
            this.btn_Sqrt = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.btn_PM = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtbx_Saved1 = new System.Windows.Forms.TextBox();
            this.tb_HistoryMem = new System.Windows.Forms.TabControl();
            this.tbp_History = new System.Windows.Forms.TabPage();
            this.rtxtbx_History = new System.Windows.Forms.RichTextBox();
            this.tbp_Memory = new System.Windows.Forms.TabPage();
            this.lst_Memory = new System.Windows.Forms.ListBox();
            this.tb_HistoryMem.SuspendLayout();
            this.tbp_History.SuspendLayout();
            this.tbp_Memory.SuspendLayout();
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
            this.btn3.Location = new System.Drawing.Point(122, 290);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 47);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(67, 290);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 47);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 290);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 47);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(67, 242);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(49, 47);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 242);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 47);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(122, 242);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 47);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(67, 194);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 47);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 194);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 47);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(122, 194);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 47);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(67, 339);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 48);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numBtn_click);
            // 
            // txtbxOutput
            // 
            this.txtbxOutput.Location = new System.Drawing.Point(11, 50);
            this.txtbxOutput.Name = "txtbxOutput";
            this.txtbxOutput.Size = new System.Drawing.Size(214, 23);
            this.txtbxOutput.TabIndex = 19;
            this.txtbxOutput.Text = "0";
            this.txtbxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbxOutput.Click += new System.EventHandler(this.txtbxOutput_Click);
            this.txtbxOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxOutput_KeyPress);
            // 
            // clear_Btn
            // 
            this.clear_Btn.Location = new System.Drawing.Point(67, 145);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(49, 47);
            this.clear_Btn.TabIndex = 22;
            this.clear_Btn.Text = "C";
            this.clear_Btn.UseVisualStyleBackColor = true;
            this.clear_Btn.Click += new System.EventHandler(this.clear_Btn_Click);
            // 
            // ce_btn
            // 
            this.ce_btn.Location = new System.Drawing.Point(12, 145);
            this.ce_btn.Name = "ce_btn";
            this.ce_btn.Size = new System.Drawing.Size(49, 47);
            this.ce_btn.TabIndex = 21;
            this.ce_btn.Text = "CE";
            this.ce_btn.UseVisualStyleBackColor = true;
            this.ce_btn.Click += new System.EventHandler(this.ce_btn_Click);
            // 
            // add_Sign
            // 
            this.add_Sign.Location = new System.Drawing.Point(176, 340);
            this.add_Sign.Name = "add_Sign";
            this.add_Sign.Size = new System.Drawing.Size(49, 47);
            this.add_Sign.TabIndex = 20;
            this.add_Sign.Text = "+";
            this.add_Sign.UseVisualStyleBackColor = true;
            this.add_Sign.Click += new System.EventHandler(this.add_Sign_Click);
            // 
            // sub_Sign
            // 
            this.sub_Sign.Location = new System.Drawing.Point(176, 290);
            this.sub_Sign.Name = "sub_Sign";
            this.sub_Sign.Size = new System.Drawing.Size(49, 47);
            this.sub_Sign.TabIndex = 23;
            this.sub_Sign.Text = "-";
            this.sub_Sign.UseVisualStyleBackColor = true;
            this.sub_Sign.Click += new System.EventHandler(this.sub_Sign_Click);
            // 
            // mul_Sign
            // 
            this.mul_Sign.Location = new System.Drawing.Point(176, 242);
            this.mul_Sign.Name = "mul_Sign";
            this.mul_Sign.Size = new System.Drawing.Size(49, 47);
            this.mul_Sign.TabIndex = 24;
            this.mul_Sign.Text = "*";
            this.mul_Sign.UseVisualStyleBackColor = true;
            this.mul_Sign.Click += new System.EventHandler(this.mul_Sign_Click);
            // 
            // div_Sign
            // 
            this.div_Sign.Location = new System.Drawing.Point(176, 194);
            this.div_Sign.Name = "div_Sign";
            this.div_Sign.Size = new System.Drawing.Size(49, 47);
            this.div_Sign.TabIndex = 25;
            this.div_Sign.Text = "/";
            this.div_Sign.UseVisualStyleBackColor = true;
            this.div_Sign.Click += new System.EventHandler(this.div_Sign_Click);
            // 
            // equals_Btn
            // 
            this.equals_Btn.Location = new System.Drawing.Point(123, 339);
            this.equals_Btn.Name = "equals_Btn";
            this.equals_Btn.Size = new System.Drawing.Size(48, 47);
            this.equals_Btn.TabIndex = 26;
            this.equals_Btn.Text = "=";
            this.equals_Btn.UseVisualStyleBackColor = true;
            this.equals_Btn.Click += new System.EventHandler(this.equals_Btn_Click);
            // 
            // back_Btn
            // 
            this.back_Btn.Location = new System.Drawing.Point(176, 145);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(49, 47);
            this.back_Btn.TabIndex = 27;
            this.back_Btn.Text = "<-";
            this.back_Btn.UseVisualStyleBackColor = true;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // dec_Btn
            // 
            this.dec_Btn.Location = new System.Drawing.Point(122, 145);
            this.dec_Btn.Name = "dec_Btn";
            this.dec_Btn.Size = new System.Drawing.Size(49, 47);
            this.dec_Btn.TabIndex = 28;
            this.dec_Btn.Text = ".";
            this.dec_Btn.UseVisualStyleBackColor = true;
            this.dec_Btn.Click += new System.EventHandler(this.decBtn_click);
            // 
            // lbl_View
            // 
            this.lbl_View.AutoSize = true;
            this.lbl_View.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_View.Location = new System.Drawing.Point(14, 28);
            this.lbl_View.Name = "lbl_View";
            this.lbl_View.Size = new System.Drawing.Size(0, 15);
            this.lbl_View.TabIndex = 29;
            // 
            // btn_Percent
            // 
            this.btn_Percent.Location = new System.Drawing.Point(12, 84);
            this.btn_Percent.Name = "btn_Percent";
            this.btn_Percent.Size = new System.Drawing.Size(49, 26);
            this.btn_Percent.TabIndex = 30;
            this.btn_Percent.Text = "%";
            this.btn_Percent.UseVisualStyleBackColor = true;
            this.btn_Percent.Click += new System.EventHandler(this.btn_Percent_Click);
            // 
            // btn_MS
            // 
            this.btn_MS.Location = new System.Drawing.Point(67, 113);
            this.btn_MS.Name = "btn_MS";
            this.btn_MS.Size = new System.Drawing.Size(49, 26);
            this.btn_MS.TabIndex = 31;
            this.btn_MS.Text = "MS";
            this.btn_MS.UseVisualStyleBackColor = true;
            this.btn_MS.Click += new System.EventHandler(this.btn_MS_Click);
            // 
            // btn_Mplus
            // 
            this.btn_Mplus.Enabled = false;
            this.btn_Mplus.Location = new System.Drawing.Point(122, 113);
            this.btn_Mplus.Name = "btn_Mplus";
            this.btn_Mplus.Size = new System.Drawing.Size(49, 26);
            this.btn_Mplus.TabIndex = 33;
            this.btn_Mplus.Text = "M+";
            this.btn_Mplus.UseVisualStyleBackColor = true;
            this.btn_Mplus.Click += new System.EventHandler(this.btn_Mplus_Click);
            // 
            // btn_Frac
            // 
            this.btn_Frac.Location = new System.Drawing.Point(67, 84);
            this.btn_Frac.Name = "btn_Frac";
            this.btn_Frac.Size = new System.Drawing.Size(49, 26);
            this.btn_Frac.TabIndex = 32;
            this.btn_Frac.Text = "1/x";
            this.btn_Frac.UseVisualStyleBackColor = true;
            this.btn_Frac.Click += new System.EventHandler(this.btn_Frac_Click);
            // 
            // btn_Mminus
            // 
            this.btn_Mminus.Enabled = false;
            this.btn_Mminus.Location = new System.Drawing.Point(176, 113);
            this.btn_Mminus.Name = "btn_Mminus";
            this.btn_Mminus.Size = new System.Drawing.Size(49, 26);
            this.btn_Mminus.TabIndex = 37;
            this.btn_Mminus.Text = "M-";
            this.btn_Mminus.UseVisualStyleBackColor = true;
            this.btn_Mminus.Click += new System.EventHandler(this.btn_Mminus_Click);
            // 
            // btn_MC
            // 
            this.btn_MC.Enabled = false;
            this.btn_MC.Location = new System.Drawing.Point(177, 84);
            this.btn_MC.Name = "btn_MC";
            this.btn_MC.Size = new System.Drawing.Size(49, 26);
            this.btn_MC.TabIndex = 36;
            this.btn_MC.Text = "MC";
            this.btn_MC.UseVisualStyleBackColor = true;
            this.btn_MC.Click += new System.EventHandler(this.btn_MC_Click);
            // 
            // btn_Sqrt
            // 
            this.btn_Sqrt.Location = new System.Drawing.Point(122, 84);
            this.btn_Sqrt.Name = "btn_Sqrt";
            this.btn_Sqrt.Size = new System.Drawing.Size(49, 26);
            this.btn_Sqrt.TabIndex = 35;
            this.btn_Sqrt.Text = "sqrt()";
            this.btn_Sqrt.UseVisualStyleBackColor = true;
            this.btn_Sqrt.Click += new System.EventHandler(this.btn_Sqrt_Click);
            // 
            // btn_MR
            // 
            this.btn_MR.Enabled = false;
            this.btn_MR.Location = new System.Drawing.Point(12, 113);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(49, 26);
            this.btn_MR.TabIndex = 34;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = true;
            this.btn_MR.Click += new System.EventHandler(this.btn_MR_Click);
            // 
            // btn_PM
            // 
            this.btn_PM.Location = new System.Drawing.Point(12, 338);
            this.btn_PM.Name = "btn_PM";
            this.btn_PM.Size = new System.Drawing.Size(49, 48);
            this.btn_PM.TabIndex = 38;
            this.btn_PM.Text = "+/-";
            this.btn_PM.UseVisualStyleBackColor = true;
            this.btn_PM.Click += new System.EventHandler(this.btn_PM_Click);
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(-73, 3);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(49, 23);
            this.btn_View.TabIndex = 41;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtbx_Saved1
            // 
            this.txtbx_Saved1.Location = new System.Drawing.Point(263, 50);
            this.txtbx_Saved1.Name = "txtbx_Saved1";
            this.txtbx_Saved1.Size = new System.Drawing.Size(100, 23);
            this.txtbx_Saved1.TabIndex = 45;
            this.txtbx_Saved1.TextChanged += new System.EventHandler(this.txtbx_Saved1_TextChanged);
            // 
            // tb_HistoryMem
            // 
            this.tb_HistoryMem.Controls.Add(this.tbp_History);
            this.tb_HistoryMem.Controls.Add(this.tbp_Memory);
            this.tb_HistoryMem.Location = new System.Drawing.Point(232, 84);
            this.tb_HistoryMem.Name = "tb_HistoryMem";
            this.tb_HistoryMem.SelectedIndex = 0;
            this.tb_HistoryMem.Size = new System.Drawing.Size(200, 303);
            this.tb_HistoryMem.TabIndex = 46;
            // 
            // tbp_History
            // 
            this.tbp_History.Controls.Add(this.rtxtbx_History);
            this.tbp_History.Location = new System.Drawing.Point(4, 24);
            this.tbp_History.Name = "tbp_History";
            this.tbp_History.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_History.Size = new System.Drawing.Size(192, 275);
            this.tbp_History.TabIndex = 0;
            this.tbp_History.Text = "History";
            this.tbp_History.UseVisualStyleBackColor = true;
            // 
            // rtxtbx_History
            // 
            this.rtxtbx_History.Location = new System.Drawing.Point(3, 3);
            this.rtxtbx_History.Name = "rtxtbx_History";
            this.rtxtbx_History.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtxtbx_History.Size = new System.Drawing.Size(185, 269);
            this.rtxtbx_History.TabIndex = 0;
            this.rtxtbx_History.Text = "";
            // 
            // tbp_Memory
            // 
            this.tbp_Memory.Controls.Add(this.lst_Memory);
            this.tbp_Memory.Location = new System.Drawing.Point(4, 24);
            this.tbp_Memory.Name = "tbp_Memory";
            this.tbp_Memory.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Memory.Size = new System.Drawing.Size(192, 275);
            this.tbp_Memory.TabIndex = 1;
            this.tbp_Memory.Text = "Memory";
            this.tbp_Memory.UseVisualStyleBackColor = true;
            // 
            // lst_Memory
            // 
            this.lst_Memory.FormattingEnabled = true;
            this.lst_Memory.ItemHeight = 15;
            this.lst_Memory.Location = new System.Drawing.Point(3, 0);
            this.lst_Memory.Name = "lst_Memory";
            this.lst_Memory.Size = new System.Drawing.Size(185, 274);
            this.lst_Memory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 399);
            this.Controls.Add(this.tb_HistoryMem);
            this.Controls.Add(this.txtbx_Saved1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_PM);
            this.Controls.Add(this.btn_Mminus);
            this.Controls.Add(this.btn_MC);
            this.Controls.Add(this.btn_Sqrt);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_Mplus);
            this.Controls.Add(this.btn_Frac);
            this.Controls.Add(this.btn_MS);
            this.Controls.Add(this.btn_Percent);
            this.Controls.Add(this.lbl_View);
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
            this.tb_HistoryMem.ResumeLayout(false);
            this.tbp_History.ResumeLayout(false);
            this.tbp_Memory.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_View;
        private System.Windows.Forms.Button btn_Percent;
        private System.Windows.Forms.Button btn_MS;
        private System.Windows.Forms.Button btn_Mplus;
        private System.Windows.Forms.Button btn_Frac;
        private System.Windows.Forms.Button btn_Mminus;
        private System.Windows.Forms.Button btn_MC;
        private System.Windows.Forms.Button btn_Sqrt;
        private System.Windows.Forms.Button btn_MR;
        private System.Windows.Forms.Button btn_PM;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtbx_Saved1;
        private System.Windows.Forms.TabControl tb_HistoryMem;
        private System.Windows.Forms.TabPage tbp_History;
        private System.Windows.Forms.RichTextBox rtxtbx_History;
        private System.Windows.Forms.TabPage tbp_Memory;
        private System.Windows.Forms.ListBox lst_Memory;
    }
}

