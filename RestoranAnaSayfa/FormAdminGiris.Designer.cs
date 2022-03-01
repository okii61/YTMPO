namespace RestoranAnaSayfa
{
    partial class adminGiris
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
            this.tbxadmin = new System.Windows.Forms.TextBox();
            this.tbxpass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGİR = new System.Windows.Forms.Button();
            this.btnGeri2 = new System.Windows.Forms.Button();
            this.btnForgot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxadmin
            // 
            this.tbxadmin.Location = new System.Drawing.Point(230, 177);
            this.tbxadmin.Multiline = true;
            this.tbxadmin.Name = "tbxadmin";
            this.tbxadmin.Size = new System.Drawing.Size(158, 45);
            this.tbxadmin.TabIndex = 0;
            // 
            // tbxpass
            // 
            this.tbxpass.Location = new System.Drawing.Point(230, 250);
            this.tbxpass.Multiline = true;
            this.tbxpass.Name = "tbxpass";
            this.tbxpass.Size = new System.Drawing.Size(158, 45);
            this.tbxpass.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(27, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 45);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnGİR
            // 
            this.btnGİR.Location = new System.Drawing.Point(377, 337);
            this.btnGİR.Name = "btnGİR";
            this.btnGİR.Size = new System.Drawing.Size(99, 56);
            this.btnGİR.TabIndex = 6;
            this.btnGİR.Text = "GİRİŞ";
            this.btnGİR.Click += new System.EventHandler(this.btnGİR_Click);
            // 
            // btnGeri2
            // 
            this.btnGeri2.Location = new System.Drawing.Point(13, 13);
            this.btnGeri2.Name = "btnGeri2";
            this.btnGeri2.Size = new System.Drawing.Size(30, 23);
            this.btnGeri2.TabIndex = 5;
            this.btnGeri2.Text = "geri";
            this.btnGeri2.UseVisualStyleBackColor = true;
            this.btnGeri2.Click += new System.EventHandler(this.btnGeri2_Click);
            // 
            // btnForgot
            // 
            this.btnForgot.Location = new System.Drawing.Point(114, 337);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(164, 23);
            this.btnForgot.TabIndex = 7;
            this.btnForgot.Text = "Şifreni mi Unuttun";
            this.btnForgot.UseVisualStyleBackColor = true;
            this.btnForgot.Click += new System.EventHandler(this.btnForgot_Click);
            // 
            // adminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 420);
            this.Controls.Add(this.btnForgot);
            this.Controls.Add(this.btnGeri2);
            this.Controls.Add(this.btnGİR);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxpass);
            this.Controls.Add(this.tbxadmin);
            this.Name = "adminGiris";
            this.Text = "adminGiris";
            this.Load += new System.EventHandler(this.adminGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxadmin;
        private System.Windows.Forms.TextBox tbxpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGİR;
        private System.Windows.Forms.Button btnGeri2;
        private System.Windows.Forms.Button btnForgot;
    }
}