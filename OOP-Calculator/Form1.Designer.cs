
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
            this.percentbtn = new System.Windows.Forms.Button();
            this.clearentrybtn = new System.Windows.Forms.Button();
            this.clearallbtn = new System.Windows.Forms.Button();
            this.backspacebtn = new System.Windows.Forms.Button();
            this.dividebtn = new System.Windows.Forms.Button();
            this.rootbtn = new System.Windows.Forms.Button();
            this.squarebtn = new System.Windows.Forms.Button();
            this.fractionbtn = new System.Windows.Forms.Button();
            this.multiplybtn = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.subtractbtn = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.additionbtn = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.decimalbtn = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.signbtn = new System.Windows.Forms.Button();
            this.txtbxOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.equalsbtn = new System.Windows.Forms.Button();
            this.divbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // percentbtn
            // 
            this.percentbtn.BackColor = System.Drawing.SystemColors.Control;
            this.percentbtn.Location = new System.Drawing.Point(12, 146);
            this.percentbtn.Name = "percentbtn";
            this.percentbtn.Size = new System.Drawing.Size(119, 61);
            this.percentbtn.TabIndex = 0;
            this.percentbtn.Text = "%";
            this.percentbtn.UseVisualStyleBackColor = false;
            // 
            // clearentrybtn
            // 
            this.clearentrybtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearentrybtn.Location = new System.Drawing.Point(137, 146);
            this.clearentrybtn.Name = "clearentrybtn";
            this.clearentrybtn.Size = new System.Drawing.Size(119, 61);
            this.clearentrybtn.TabIndex = 1;
            this.clearentrybtn.Text = "CE";
            this.clearentrybtn.UseVisualStyleBackColor = false;
            this.clearentrybtn.Click += new System.EventHandler(this.clearentrybtn_Click);
            // 
            // clearallbtn
            // 
            this.clearallbtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearallbtn.Location = new System.Drawing.Point(262, 146);
            this.clearallbtn.Name = "clearallbtn";
            this.clearallbtn.Size = new System.Drawing.Size(119, 61);
            this.clearallbtn.TabIndex = 2;
            this.clearallbtn.Text = "C";
            this.clearallbtn.UseVisualStyleBackColor = false;
            this.clearallbtn.Click += new System.EventHandler(this.clearallbtn_Click);
            // 
            // backspacebtn
            // 
            this.backspacebtn.BackColor = System.Drawing.SystemColors.Control;
            this.backspacebtn.Location = new System.Drawing.Point(387, 146);
            this.backspacebtn.Name = "backspacebtn";
            this.backspacebtn.Size = new System.Drawing.Size(119, 61);
            this.backspacebtn.TabIndex = 3;
            this.backspacebtn.Text = "<-";
            this.backspacebtn.UseVisualStyleBackColor = false;
            this.backspacebtn.Click += new System.EventHandler(this.button4_Click);
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
            this.dividebtn.Click += new System.EventHandler(this.dividebtn_Click);
            // 
            // rootbtn
            // 
            this.rootbtn.BackColor = System.Drawing.SystemColors.Control;
            this.rootbtn.Location = new System.Drawing.Point(262, 213);
            this.rootbtn.Name = "rootbtn";
            this.rootbtn.Size = new System.Drawing.Size(119, 61);
            this.rootbtn.TabIndex = 6;
            this.rootbtn.Text = "sqrt()";
            this.rootbtn.UseVisualStyleBackColor = false;
            // 
            // squarebtn
            // 
            this.squarebtn.BackColor = System.Drawing.SystemColors.Control;
            this.squarebtn.Location = new System.Drawing.Point(137, 213);
            this.squarebtn.Name = "squarebtn";
            this.squarebtn.Size = new System.Drawing.Size(119, 61);
            this.squarebtn.TabIndex = 5;
            this.squarebtn.Text = "𝑥^2";
            this.squarebtn.UseVisualStyleBackColor = false;
            this.squarebtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // fractionbtn
            // 
            this.fractionbtn.BackColor = System.Drawing.SystemColors.Control;
            this.fractionbtn.Location = new System.Drawing.Point(12, 213);
            this.fractionbtn.Name = "fractionbtn";
            this.fractionbtn.Size = new System.Drawing.Size(119, 61);
            this.fractionbtn.TabIndex = 4;
            this.fractionbtn.Text = "1/𝑥";
            this.fractionbtn.UseVisualStyleBackColor = false;
            // 
            // multiplybtn
            // 
            this.multiplybtn.BackColor = System.Drawing.SystemColors.Control;
            this.multiplybtn.Location = new System.Drawing.Point(387, 280);
            this.multiplybtn.Name = "multiplybtn";
            this.multiplybtn.Size = new System.Drawing.Size(119, 61);
            this.multiplybtn.TabIndex = 11;
            this.multiplybtn.Text = "*";
            this.multiplybtn.UseVisualStyleBackColor = false;
            this.multiplybtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Location = new System.Drawing.Point(262, 280);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(119, 61);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Location = new System.Drawing.Point(137, 280);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(119, 61);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Location = new System.Drawing.Point(12, 280);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(119, 61);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // subtractbtn
            // 
            this.subtractbtn.BackColor = System.Drawing.SystemColors.Control;
            this.subtractbtn.Location = new System.Drawing.Point(387, 347);
            this.subtractbtn.Name = "subtractbtn";
            this.subtractbtn.Size = new System.Drawing.Size(119, 61);
            this.subtractbtn.TabIndex = 15;
            this.subtractbtn.Text = "-";
            this.subtractbtn.UseVisualStyleBackColor = false;
            this.subtractbtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Location = new System.Drawing.Point(262, 347);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(119, 61);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(137, 347);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(119, 61);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Location = new System.Drawing.Point(12, 347);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(119, 61);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // additionbtn
            // 
            this.additionbtn.BackColor = System.Drawing.SystemColors.Control;
            this.additionbtn.Location = new System.Drawing.Point(387, 414);
            this.additionbtn.Name = "additionbtn";
            this.additionbtn.Size = new System.Drawing.Size(119, 61);
            this.additionbtn.TabIndex = 19;
            this.additionbtn.Text = "+";
            this.additionbtn.UseVisualStyleBackColor = false;
            this.additionbtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Location = new System.Drawing.Point(262, 414);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(119, 61);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(137, 414);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(119, 61);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(12, 414);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(119, 61);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // decimalbtn
            // 
            this.decimalbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalbtn.Location = new System.Drawing.Point(262, 481);
            this.decimalbtn.Name = "decimalbtn";
            this.decimalbtn.Size = new System.Drawing.Size(119, 61);
            this.decimalbtn.TabIndex = 22;
            this.decimalbtn.Text = ".";
            this.decimalbtn.UseVisualStyleBackColor = false;
            this.decimalbtn.Click += new System.EventHandler(this.decimalbtn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Location = new System.Drawing.Point(137, 481);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(119, 61);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.BackColorChanged += new System.EventHandler(this.btn0_Click);
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // signbtn
            // 
            this.signbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.signbtn.Location = new System.Drawing.Point(12, 481);
            this.signbtn.Name = "signbtn";
            this.signbtn.Size = new System.Drawing.Size(119, 61);
            this.signbtn.TabIndex = 20;
            this.signbtn.Text = "+/-";
            this.signbtn.UseVisualStyleBackColor = false;
            this.signbtn.Click += new System.EventHandler(this.signbtn_Click);
            // 
            // txtbxOutput
            // 
            this.txtbxOutput.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxOutput.Location = new System.Drawing.Point(12, 94);
            this.txtbxOutput.Name = "txtbxOutput";
            this.txtbxOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbxOutput.Size = new System.Drawing.Size(494, 46);
            this.txtbxOutput.TabIndex = 24;
            this.txtbxOutput.Text = "0";
            this.txtbxOutput.TextChanged += new System.EventHandler(this.txtbxOutput_TextChanged);
            this.txtbxOutput.MouseHover += new System.EventHandler(this.btn0_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblOutput.Location = new System.Drawing.Point(12, 48);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(25, 43);
            this.lblOutput.TabIndex = 25;
            this.lblOutput.Text = "0";
            this.lblOutput.UseCompatibleTextRendering = true;
            // 
            // equalsbtn
            // 
            this.equalsbtn.Location = new System.Drawing.Point(387, 481);
            this.equalsbtn.Name = "equalsbtn";
            this.equalsbtn.Size = new System.Drawing.Size(119, 61);
            this.equalsbtn.TabIndex = 26;
            this.equalsbtn.Text = "=";
            this.equalsbtn.UseVisualStyleBackColor = true;
            this.equalsbtn.Click += new System.EventHandler(this.equalsbtn_Click);
            // 
            // divbtn
            // 
            this.divbtn.BackColor = System.Drawing.SystemColors.Control;
            this.divbtn.Location = new System.Drawing.Point(387, 213);
            this.divbtn.Name = "divbtn";
            this.divbtn.Size = new System.Drawing.Size(119, 61);
            this.divbtn.TabIndex = 27;
            this.divbtn.Text = "/";
            this.divbtn.UseVisualStyleBackColor = false;
            this.divbtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 572);
            this.Controls.Add(this.divbtn);
            this.Controls.Add(this.equalsbtn);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtbxOutput);
            this.Controls.Add(this.decimalbtn);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.signbtn);
            this.Controls.Add(this.additionbtn);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.subtractbtn);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.multiplybtn);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.dividebtn);
            this.Controls.Add(this.rootbtn);
            this.Controls.Add(this.squarebtn);
            this.Controls.Add(this.fractionbtn);
            this.Controls.Add(this.backspacebtn);
            this.Controls.Add(this.clearallbtn);
            this.Controls.Add(this.clearentrybtn);
            this.Controls.Add(this.percentbtn);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button percentbtn;
        private System.Windows.Forms.Button clearentrybtn;
        private System.Windows.Forms.Button clearallbtn;
        private System.Windows.Forms.Button backspacebtn;
        private System.Windows.Forms.Button dividebtn;
        private System.Windows.Forms.Button rootbtn;
        private System.Windows.Forms.Button squarebtn;
        private System.Windows.Forms.Button fractionbtn;
        private System.Windows.Forms.Button multiplybtn;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button subtractbtn;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button additionbtn;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button decimalbtn;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button signbtn;
        private System.Windows.Forms.TextBox txtbxOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button equalsbtn;
        private System.Windows.Forms.Button divbtn;
    }
}

