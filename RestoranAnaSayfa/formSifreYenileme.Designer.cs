﻿namespace RestoranAnaSayfa
{
    partial class formSifreYenileme
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
            this.tbxFMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbxFMail
            // 
            this.tbxFMail.Location = new System.Drawing.Point(299, 183);
            this.tbxFMail.Multiline = true;
            this.tbxFMail.Name = "tbxFMail";
            this.tbxFMail.Size = new System.Drawing.Size(235, 49);
            this.tbxFMail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen Mail Adresinizi Giriniz";
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(410, 307);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(124, 39);
            this.btnCode.TabIndex = 3;
            this.btnCode.Text = "button1";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // formSifreYenileme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFMail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formSifreYenileme";
            this.Text = "formSifreYenileme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxFMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCode;
    }
}