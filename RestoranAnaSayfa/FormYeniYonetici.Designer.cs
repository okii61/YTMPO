namespace RestoranAnaSayfa
{
    partial class FormYeniYonetici
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
            this.tbxYName = new System.Windows.Forms.TextBox();
            this.tbxYSurname = new System.Windows.Forms.TextBox();
            this.tbxYUser = new System.Windows.Forms.TextBox();
            this.tbxYMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxYPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxYName
            // 
            this.tbxYName.Location = new System.Drawing.Point(234, 119);
            this.tbxYName.Multiline = true;
            this.tbxYName.Name = "tbxYName";
            this.tbxYName.Size = new System.Drawing.Size(173, 37);
            this.tbxYName.TabIndex = 0;
            // 
            // tbxYSurname
            // 
            this.tbxYSurname.Location = new System.Drawing.Point(234, 180);
            this.tbxYSurname.Multiline = true;
            this.tbxYSurname.Name = "tbxYSurname";
            this.tbxYSurname.Size = new System.Drawing.Size(173, 37);
            this.tbxYSurname.TabIndex = 1;
            // 
            // tbxYUser
            // 
            this.tbxYUser.Location = new System.Drawing.Point(234, 247);
            this.tbxYUser.Multiline = true;
            this.tbxYUser.Name = "tbxYUser";
            this.tbxYUser.Size = new System.Drawing.Size(173, 37);
            this.tbxYUser.TabIndex = 2;
            // 
            // tbxYMail
            // 
            this.tbxYMail.Location = new System.Drawing.Point(234, 310);
            this.tbxYMail.Multiline = true;
            this.tbxYMail.Name = "tbxYMail";
            this.tbxYMail.Size = new System.Drawing.Size(173, 37);
            this.tbxYMail.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxYPass
            // 
            this.tbxYPass.Location = new System.Drawing.Point(234, 373);
            this.tbxYPass.Multiline = true;
            this.tbxYPass.Name = "tbxYPass";
            this.tbxYPass.Size = new System.Drawing.Size(173, 37);
            this.tbxYPass.TabIndex = 5;
            // 
            // FormYeniYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxYPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxYMail);
            this.Controls.Add(this.tbxYUser);
            this.Controls.Add(this.tbxYSurname);
            this.Controls.Add(this.tbxYName);
            this.Name = "FormYeniYonetici";
            this.Text = "FormYeniYonetici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxYName;
        private System.Windows.Forms.TextBox tbxYSurname;
        private System.Windows.Forms.TextBox tbxYUser;
        private System.Windows.Forms.TextBox tbxYMail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxYPass;
    }
}