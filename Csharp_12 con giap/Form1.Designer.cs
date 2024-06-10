namespace Csharp_12_con_giap
{
    partial class Form1
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
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.lbltinh = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblnam = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(203, 97);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 20);
            this.txtnam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(203, 231);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 2;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lbltinh
            // 
            this.lbltinh.AutoSize = true;
            this.lbltinh.Location = new System.Drawing.Point(94, 104);
            this.lbltinh.Name = "lbltinh";
            this.lbltinh.Size = new System.Drawing.Size(33, 13);
            this.lbltinh.TabIndex = 3;
            this.lbltinh.Text = "TÍNH";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(203, 154);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(375, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 173);
            this.listBox1.TabIndex = 5;
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Location = new System.Drawing.Point(94, 161);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(29, 13);
            this.lblnam.TabIndex = 6;
            this.lblnam.Text = "Năm";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(203, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblnam);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lbltinh);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label lbltinh;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

