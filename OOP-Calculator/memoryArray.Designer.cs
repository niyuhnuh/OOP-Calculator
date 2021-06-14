
namespace OOP_Calculator
{
    partial class memoryArray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_SavedMemory = new System.Windows.Forms.DataGridView();
            this.savedMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SavedMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SavedMemory
            // 
            this.dgv_SavedMemory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.savedMemory});
            this.dgv_SavedMemory.Location = new System.Drawing.Point(12, 12);
            this.dgv_SavedMemory.Name = "dgv_SavedMemory";
            this.dgv_SavedMemory.RowTemplate.Height = 25;
            this.dgv_SavedMemory.Size = new System.Drawing.Size(213, 374);
            this.dgv_SavedMemory.TabIndex = 0;
            // 
            // savedMemory
            // 
            this.savedMemory.Frozen = true;
            this.savedMemory.HeaderText = "Memory";
            this.savedMemory.Name = "savedMemory";
            this.savedMemory.ReadOnly = true;
            // 
            // memoryArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 398);
            this.Controls.Add(this.dgv_SavedMemory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "memoryArray";
            this.Text = "memoryArray";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SavedMemory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SavedMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn savedMemory;
    }
}