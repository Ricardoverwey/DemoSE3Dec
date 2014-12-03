namespace Exceptions
{
    partial class ExeptionForm
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
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.btDelen = new System.Windows.Forms.Button();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.lblBericht = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(39, 54);
            this.tbGetal1.Margin = new System.Windows.Forms.Padding(6);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(180, 29);
            this.tbGetal1.TabIndex = 0;
            // 
            // btDelen
            // 
            this.btDelen.Location = new System.Drawing.Point(228, 46);
            this.btDelen.Name = "btDelen";
            this.btDelen.Size = new System.Drawing.Size(106, 46);
            this.btDelen.TabIndex = 1;
            this.btDelen.Text = "Delen";
            this.btDelen.UseVisualStyleBackColor = true;
            this.btDelen.Click += new System.EventHandler(this.btDelen_Click);
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(343, 54);
            this.tbGetal2.Margin = new System.Windows.Forms.Padding(6);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(180, 29);
            this.tbGetal2.TabIndex = 2;
            // 
            // lblBericht
            // 
            this.lblBericht.AutoSize = true;
            this.lblBericht.Location = new System.Drawing.Point(44, 166);
            this.lblBericht.Name = "lblBericht";
            this.lblBericht.Size = new System.Drawing.Size(35, 24);
            this.lblBericht.TabIndex = 3;
            this.lblBericht.Text = ".....";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDelen);
            this.groupBox1.Controls.Add(this.lblBericht);
            this.groupBox1.Controls.Add(this.tbGetal1);
            this.groupBox1.Controls.Add(this.tbGetal2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exceptions";
            // 
            // ExeptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 283);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ExeptionForm";
            this.Text = "Exceptions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.Button btDelen;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.Label lblBericht;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

