namespace KisiselButceIstekIhtiyac
{
    partial class FormAna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuOzet = new System.Windows.Forms.Button();
            this.btnYeniIstek = new System.Windows.Forms.Button();
            this.btnKarantina = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblButce = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKarantinaTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGider = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSonHarcamalar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZorunluGider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonHarcamalar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnZorunluGider);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnKarantina);
            this.panel1.Controls.Add(this.btnYeniIstek);
            this.panel1.Controls.Add(this.btnMenuOzet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 541);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "KARAR ASİSTANI";
            // 
            // btnMenuOzet
            // 
            this.btnMenuOzet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnMenuOzet.FlatAppearance.BorderSize = 0;
            this.btnMenuOzet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOzet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuOzet.ForeColor = System.Drawing.Color.White;
            this.btnMenuOzet.Location = new System.Drawing.Point(0, 100);
            this.btnMenuOzet.Name = "btnMenuOzet";
            this.btnMenuOzet.Size = new System.Drawing.Size(220, 48);
            this.btnMenuOzet.TabIndex = 1;
            this.btnMenuOzet.Text = "Genel Bakış";
            this.btnMenuOzet.UseVisualStyleBackColor = false;
            // 
            // btnYeniIstek
            // 
            this.btnYeniIstek.FlatAppearance.BorderSize = 0;
            this.btnYeniIstek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniIstek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniIstek.ForeColor = System.Drawing.Color.White;
            this.btnYeniIstek.Location = new System.Drawing.Point(0, 150);
            this.btnYeniIstek.Name = "btnYeniIstek";
            this.btnYeniIstek.Size = new System.Drawing.Size(220, 48);
            this.btnYeniIstek.TabIndex = 2;
            this.btnYeniIstek.Text = "Yeni İstek Ekle";
            this.btnYeniIstek.UseVisualStyleBackColor = true;
            // 
            // btnKarantina
            // 
            this.btnKarantina.FlatAppearance.BorderSize = 0;
            this.btnKarantina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarantina.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarantina.ForeColor = System.Drawing.Color.White;
            this.btnKarantina.Location = new System.Drawing.Point(0, 250);
            this.btnKarantina.Name = "btnKarantina";
            this.btnKarantina.Size = new System.Drawing.Size(220, 48);
            this.btnKarantina.TabIndex = 3;
            this.btnKarantina.Text = "Soğuma Karantinası";
            this.btnKarantina.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(0, 480);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(220, 48);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblButce);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(250, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 110);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblKarantinaTutar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(480, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 110);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblGider);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(710, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 110);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mevcut Net Bütçe";
            // 
            // lblButce
            // 
            this.lblButce.AutoSize = true;
            this.lblButce.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblButce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.lblButce.Location = new System.Drawing.Point(15, 50);
            this.lblButce.Name = "lblButce";
            this.lblButce.Size = new System.Drawing.Size(134, 28);
            this.lblButce.TabIndex = 1;
            this.lblButce.Text = "35.000,00 TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Karantinada Bekleyen";
            // 
            // lblKarantinaTutar
            // 
            this.lblKarantinaTutar.AutoSize = true;
            this.lblKarantinaTutar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarantinaTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.lblKarantinaTutar.Location = new System.Drawing.Point(15, 50);
            this.lblKarantinaTutar.Name = "lblKarantinaTutar";
            this.lblKarantinaTutar.Size = new System.Drawing.Size(122, 28);
            this.lblKarantinaTutar.TabIndex = 1;
            this.lblKarantinaTutar.Text = "4.250,00 TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bu Ayki Harcamalar";
            // 
            // lblGider
            // 
            this.lblGider.AutoSize = true;
            this.lblGider.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGider.ForeColor = System.Drawing.Color.Brown;
            this.lblGider.Location = new System.Drawing.Point(15, 50);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(134, 28);
            this.lblGider.TabIndex = 1;
            this.lblGider.Text = "12.400,00 TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label5.Location = new System.Drawing.Point(250, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Son Harcama ve Karar Geçmişi";
            // 
            // dgvSonHarcamalar
            // 
            this.dgvSonHarcamalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dgvSonHarcamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonHarcamalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSonHarcamalar.Location = new System.Drawing.Point(250, 195);
            this.dgvSonHarcamalar.Name = "dgvSonHarcamalar";
            this.dgvSonHarcamalar.Size = new System.Drawing.Size(670, 320);
            this.dgvSonHarcamalar.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün / Harcama Adı";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tutar (TL)";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Emek Karşılığı";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Durum";
            this.Column4.Name = "Column4";
            // 
            // btnZorunluGider
            // 
            this.btnZorunluGider.FlatAppearance.BorderSize = 0;
            this.btnZorunluGider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZorunluGider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZorunluGider.ForeColor = System.Drawing.Color.White;
            this.btnZorunluGider.Location = new System.Drawing.Point(0, 200);
            this.btnZorunluGider.Name = "btnZorunluGider";
            this.btnZorunluGider.Size = new System.Drawing.Size(220, 48);
            this.btnZorunluGider.TabIndex = 5;
            this.btnZorunluGider.Text = "Zorunlu Gider Ekle";
            this.btnZorunluGider.UseVisualStyleBackColor = true;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.dgvSonHarcamalar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa - Bütçe ve Karar Özeti";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonHarcamalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKarantina;
        private System.Windows.Forms.Button btnYeniIstek;
        private System.Windows.Forms.Button btnMenuOzet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblButce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblKarantinaTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSonHarcamalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnZorunluGider;
    }
}