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
            this.btnRicardo = new System.Windows.Forms.Button();
            this.Jeroen = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnRicardo
            // 
            this.btnRicardo.Location = new System.Drawing.Point(12, 128);
            this.btnRicardo.Name = "btnRicardo";
            this.btnRicardo.Size = new System.Drawing.Size(75, 23);
            this.btnRicardo.TabIndex = 1;
            this.btnRicardo.Text = "Ricardo";
            this.btnRicardo.UseVisualStyleBackColor = true;
            this.btnRicardo.Click += new System.EventHandler(this.btnRicardo_Click);
            // 
            // Jeroen
            // 
            this.Jeroen.Location = new System.Drawing.Point(12, 63);
            this.Jeroen.Name = "Jeroen";
            this.Jeroen.Size = new System.Drawing.Size(75, 23);
            this.Jeroen.TabIndex = 1;
            this.Jeroen.Text = "Jeroen";
            this.Jeroen.UseVisualStyleBackColor = true;
            this.Jeroen.Click += new System.EventHandler(this.Jeroen_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 157);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(317, 132);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(286, 32);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 97);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 295);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRicardo);
            this.Controls.Add(this.Jeroen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRicardo;
        private System.Windows.Forms.Button Jeroen;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
    }
}

