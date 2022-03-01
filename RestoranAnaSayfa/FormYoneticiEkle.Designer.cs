namespace RestoranAnaSayfa
{
    partial class FormYoneticiEkle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxGUser = new System.Windows.Forms.TextBox();
            this.txtGPassword = new System.Windows.Forms.TextBox();
            this.btnGYoneticiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(23, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbxGUser
            // 
            this.tbxGUser.Location = new System.Drawing.Point(225, 135);
            this.tbxGUser.Multiline = true;
            this.tbxGUser.Name = "tbxGUser";
            this.tbxGUser.Size = new System.Drawing.Size(178, 32);
            this.tbxGUser.TabIndex = 2;
            // 
            // txtGPassword
            // 
            this.txtGPassword.Location = new System.Drawing.Point(225, 184);
            this.txtGPassword.Multiline = true;
            this.txtGPassword.Name = "txtGPassword";
            this.txtGPassword.Size = new System.Drawing.Size(178, 32);
            this.txtGPassword.TabIndex = 3;
            // 
            // btnGYoneticiEkle
            // 
            this.btnGYoneticiEkle.Location = new System.Drawing.Point(328, 269);
            this.btnGYoneticiEkle.Name = "btnGYoneticiEkle";
            this.btnGYoneticiEkle.Size = new System.Drawing.Size(75, 45);
            this.btnGYoneticiEkle.TabIndex = 4;
            this.btnGYoneticiEkle.Text = "GİRİŞ";
            this.btnGYoneticiEkle.UseVisualStyleBackColor = true;
            this.btnGYoneticiEkle.Click += new System.EventHandler(this.btnGYoneticiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öncelikle Kullanıcı Adınızı ve Şifrenizi Giriniz";
            // 
            // FormYoneticiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGYoneticiEkle);
            this.Controls.Add(this.txtGPassword);
            this.Controls.Add(this.tbxGUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormYoneticiEkle";
            this.Text = "FormYoneticiEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbxGUser;
        private System.Windows.Forms.TextBox txtGPassword;
        private System.Windows.Forms.Button btnGYoneticiEkle;
        private System.Windows.Forms.Label label1;
    }
}