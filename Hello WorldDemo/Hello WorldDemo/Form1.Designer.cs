namespace Hello_WorldDemo
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
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btnRicardo = new System.Windows.Forms.Button();
=======
            this.Jeroen = new System.Windows.Forms.Button();
>>>>>>> origin/master
            this.SuspendLayout();
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(12, 99);
=======
            this.button1.Location = new System.Drawing.Point(12, 12);
>>>>>>> origin/master
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
<<<<<<< HEAD
            // btnRicardo
            // 
            this.btnRicardo.Location = new System.Drawing.Point(12, 128);
            this.btnRicardo.Name = "btnRicardo";
            this.btnRicardo.Size = new System.Drawing.Size(75, 23);
            this.btnRicardo.TabIndex = 1;
            this.btnRicardo.Text = "Ricardo";
            this.btnRicardo.UseVisualStyleBackColor = true;
            this.btnRicardo.Click += new System.EventHandler(this.btnRicardo_Click);
=======
            // Jeroen
            // 
            this.Jeroen.Location = new System.Drawing.Point(12, 63);
            this.Jeroen.Name = "Jeroen";
            this.Jeroen.Size = new System.Drawing.Size(75, 23);
            this.Jeroen.TabIndex = 1;
            this.Jeroen.Text = "Jeroen";
            this.Jeroen.UseVisualStyleBackColor = true;
            this.Jeroen.Click += new System.EventHandler(this.Jeroen_Click);
>>>>>>> origin/master
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRicardo);
=======
            this.ClientSize = new System.Drawing.Size(776, 295);
            this.Controls.Add(this.Jeroen);
>>>>>>> origin/master
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnRicardo;
=======
        private System.Windows.Forms.Button Jeroen;
>>>>>>> origin/master
    }
}

