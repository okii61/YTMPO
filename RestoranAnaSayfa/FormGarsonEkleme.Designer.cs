namespace RestoranAnaSayfa
{
    partial class FormGarsonEkleme
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxSeriNo = new System.Windows.Forms.TextBox();
            this.btnGarsonAdd = new System.Windows.Forms.Button();
            this.btnGeri4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(192, 137);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(159, 39);
            this.tbxName.TabIndex = 0;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(192, 226);
            this.tbxSurname.Multiline = true;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(159, 39);
            this.tbxSurname.TabIndex = 1;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(192, 311);
            this.tbxAge.Multiline = true;
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(159, 39);
            this.tbxAge.TabIndex = 2;
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(574, 137);
            this.tbxMail.Multiline = true;
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(159, 39);
            this.tbxMail.TabIndex = 3;
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(574, 226);
            this.tbxSalary.Multiline = true;
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(159, 39);
            this.tbxSalary.TabIndex = 4;
            // 
            // tbxSeriNo
            // 
            this.tbxSeriNo.Location = new System.Drawing.Point(574, 311);
            this.tbxSeriNo.Multiline = true;
            this.tbxSeriNo.Name = "tbxSeriNo";
            this.tbxSeriNo.Size = new System.Drawing.Size(159, 39);
            this.tbxSeriNo.TabIndex = 5;
            // 
            // btnGarsonAdd
            // 
            this.btnGarsonAdd.Location = new System.Drawing.Point(669, 380);
            this.btnGarsonAdd.Name = "btnGarsonAdd";
            this.btnGarsonAdd.Size = new System.Drawing.Size(119, 58);
            this.btnGarsonAdd.TabIndex = 0;
            this.btnGarsonAdd.Text = "Garson Ekle";
            this.btnGarsonAdd.Click += new System.EventHandler(this.btnGarsonAdd_Click);
            // 
            // btnGeri4
            // 
            this.btnGeri4.Location = new System.Drawing.Point(12, 12);
            this.btnGeri4.Name = "btnGeri4";
            this.btnGeri4.Size = new System.Drawing.Size(26, 23);
            this.btnGeri4.TabIndex = 6;
            this.btnGeri4.Text = "button1";
            this.btnGeri4.UseVisualStyleBackColor = true;
            this.btnGeri4.Click += new System.EventHandler(this.btnGeri4_Click);
            // 
            // garsonEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri4);
            this.Controls.Add(this.btnGarsonAdd);
            this.Controls.Add(this.tbxSeriNo);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxName);
            this.Name = "garsonEkleme";
            this.Text = "garsonEkleme";
            this.Load += new System.EventHandler(this.garsonEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.TextBox tbxSeriNo;
        private System.Windows.Forms.Button btnGarsonAdd;
        private System.Windows.Forms.Button btnGeri4;
    }
}