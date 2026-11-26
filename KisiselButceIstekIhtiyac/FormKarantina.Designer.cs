namespace KisiselButceIstekIhtiyac
{
    partial class FormKarantina
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKarantina = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarantina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karantinada Bekleyen Ürünler";
            // 
            // dgvKarantina
            // 
            this.dgvKarantina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dgvKarantina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarantina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvKarantina.Location = new System.Drawing.Point(40, 70);
            this.dgvKarantina.Name = "dgvKarantina";
            this.dgvKarantina.Size = new System.Drawing.Size(600, 220);
            this.dgvKarantina.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fiyat";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Karantina Bitiş Tarihi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kalan Süre";
            this.Column4.Name = "Column4";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.btnSatinAl.FlatAppearance.BorderSize = 0;
            this.btnSatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatinAl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.ForeColor = System.Drawing.Color.White;
            this.btnSatinAl.Location = new System.Drawing.Point(140, 330);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(180, 45);
            this.btnSatinAl.TabIndex = 2;
            this.btnSatinAl.Text = "Süresi Doldu - Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Brown;
            this.btnVazgec.FlatAppearance.BorderSize = 0;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(360, 330);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(180, 45);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.Text = "Fikrim Değişti - Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            // 
            // FormKarantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.dgvKarantina);
            this.Controls.Add(this.label1);
            this.Name = "FormKarantina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soğuma Karantinası (3 Gün Kuralı)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarantina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKarantina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Button btnVazgec;
    }
}