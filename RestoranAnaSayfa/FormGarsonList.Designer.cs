namespace RestoranAnaSayfa
{
    partial class FormGarsonList
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
            this.dgwGarsonList = new System.Windows.Forms.DataGridView();
            this.btnGrsnDel = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGarsonList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGarsonList
            // 
            this.dgwGarsonList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwGarsonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGarsonList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwGarsonList.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgwGarsonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGarsonList.Location = new System.Drawing.Point(12, 45);
            this.dgwGarsonList.Name = "dgwGarsonList";
            this.dgwGarsonList.Size = new System.Drawing.Size(776, 323);
            this.dgwGarsonList.TabIndex = 0;
            this.dgwGarsonList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGarsonList_CellContentClick);
            this.dgwGarsonList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGarsonList_CellContentClick);
            // 
            // btnGrsnDel
            // 
            this.btnGrsnDel.Location = new System.Drawing.Point(679, 374);
            this.btnGrsnDel.Name = "btnGrsnDel";
            this.btnGrsnDel.Size = new System.Drawing.Size(109, 64);
            this.btnGrsnDel.TabIndex = 1;
            this.btnGrsnDel.Text = "DELETE";
            this.btnGrsnDel.UseVisualStyleBackColor = true;
            this.btnGrsnDel.Click += new System.EventHandler(this.btnGrsnDel_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(29, 23);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // garsonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnGrsnDel);
            this.Controls.Add(this.dgwGarsonList);
            this.Name = "garsonList";
            this.Text = "garsonList";
            this.Load += new System.EventHandler(this.garsonList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGarsonList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGarsonList;
        private System.Windows.Forms.Button btnGrsnDel;
        private System.Windows.Forms.Button btnGeri;
    }
}