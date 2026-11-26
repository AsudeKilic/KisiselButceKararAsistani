namespace KisiselButceIstekIhtiyac.Views
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSeciliIstekBilgi = new System.Windows.Forms.Label();
            this.cmbDurumFiltre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIstekGuncelleAc = new System.Windows.Forms.Button();
            this.btnYeniIstekAc = new System.Windows.Forms.Button();
            this.dgvKarantina = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKarantinaGeriDon = new System.Windows.Forms.Button();
            this.btnIstekSil = new System.Windows.Forms.Button();
            this.btnSatinAlindi = new System.Windows.Forms.Button();
            this.btnVazgecildi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarantina)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(924, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "İstek Karantinası Listesi ve Satın Alma Karar Merkezi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSeciliIstekBilgi);
            this.panel2.Controls.Add(this.cmbDurumFiltre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 50);
            this.panel2.TabIndex = 1;
            // 
            // lblSeciliIstekBilgi
            // 
            this.lblSeciliIstekBilgi.AutoSize = true;
            this.lblSeciliIstekBilgi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSeciliIstekBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.lblSeciliIstekBilgi.Location = new System.Drawing.Point(385, 15);
            this.lblSeciliIstekBilgi.Name = "lblSeciliIstekBilgi";
            this.lblSeciliIstekBilgi.Size = new System.Drawing.Size(260, 15);
            this.lblSeciliIstekBilgi.TabIndex = 2;
            this.lblSeciliIstekBilgi.Text = "Tablodan işlem yapmak istediğiniz isteği seçiniz.";
            // 
            // cmbDurumFiltre
            // 
            this.cmbDurumFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurumFiltre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDurumFiltre.FormattingEnabled = true;
            this.cmbDurumFiltre.Items.AddRange(new object[] {
            "Tümü",
            "Beklemede",
            "Vazgeçildi",
            "Satın Alındı"});
            this.cmbDurumFiltre.Location = new System.Drawing.Point(165, 11);
            this.cmbDurumFiltre.Name = "cmbDurumFiltre";
            this.cmbDurumFiltre.Size = new System.Drawing.Size(200, 25);
            this.cmbDurumFiltre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duruma Göre Filtrele:";
            // 
            // btnIstekGuncelleAc
            // 
            this.btnIstekGuncelleAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnIstekGuncelleAc.FlatAppearance.BorderSize = 0;
            this.btnIstekGuncelleAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstekGuncelleAc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstekGuncelleAc.ForeColor = System.Drawing.Color.White;
            this.btnIstekGuncelleAc.Location = new System.Drawing.Point(135, 10);
            this.btnIstekGuncelleAc.Name = "btnIstekGuncelleAc";
            this.btnIstekGuncelleAc.Size = new System.Drawing.Size(115, 36);
            this.btnIstekGuncelleAc.TabIndex = 4;
            this.btnIstekGuncelleAc.Text = "Güncelle";
            this.btnIstekGuncelleAc.UseVisualStyleBackColor = false;
            // 
            // btnYeniIstekAc
            // 
            this.btnYeniIstekAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnYeniIstekAc.FlatAppearance.BorderSize = 0;
            this.btnYeniIstekAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniIstekAc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniIstekAc.ForeColor = System.Drawing.Color.White;
            this.btnYeniIstekAc.Location = new System.Drawing.Point(12, 10);
            this.btnYeniIstekAc.Name = "btnYeniIstekAc";
            this.btnYeniIstekAc.Size = new System.Drawing.Size(115, 36);
            this.btnYeniIstekAc.TabIndex = 3;
            this.btnYeniIstekAc.Text = "+ Yeni İstek Ekle";
            this.btnYeniIstekAc.UseVisualStyleBackColor = false;
            // 
            // dgvKarantina
            // 
            this.dgvKarantina.AllowUserToAddRows = false;
            this.dgvKarantina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKarantina.BackgroundColor = System.Drawing.Color.White;
            this.dgvKarantina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarantina.Location = new System.Drawing.Point(20, 148);
            this.dgvKarantina.MultiSelect = false;
            this.dgvKarantina.Name = "dgvKarantina";
            this.dgvKarantina.ReadOnly = true;
            this.dgvKarantina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarantina.Size = new System.Drawing.Size(885, 330);
            this.dgvKarantina.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnIstekGuncelleAc);
            this.panel3.Controls.Add(this.btnKarantinaGeriDon);
            this.panel3.Controls.Add(this.btnYeniIstekAc);
            this.panel3.Controls.Add(this.btnIstekSil);
            this.panel3.Controls.Add(this.btnSatinAlindi);
            this.panel3.Controls.Add(this.btnVazgecildi);
            this.panel3.Location = new System.Drawing.Point(20, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 55);
            this.panel3.TabIndex = 3;
            // 
            // btnKarantinaGeriDon
            // 
            this.btnKarantinaGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnKarantinaGeriDon.FlatAppearance.BorderSize = 0;
            this.btnKarantinaGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarantinaGeriDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarantinaGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnKarantinaGeriDon.Location = new System.Drawing.Point(735, 10);
            this.btnKarantinaGeriDon.Name = "btnKarantinaGeriDon";
            this.btnKarantinaGeriDon.Size = new System.Drawing.Size(138, 36);
            this.btnKarantinaGeriDon.TabIndex = 3;
            this.btnKarantinaGeriDon.Text = "← Ana Sayfaya Dön";
            this.btnKarantinaGeriDon.UseVisualStyleBackColor = false;
            // 
            // btnIstekSil
            // 
            this.btnIstekSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnIstekSil.FlatAppearance.BorderSize = 0;
            this.btnIstekSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstekSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstekSil.ForeColor = System.Drawing.Color.White;
            this.btnIstekSil.Location = new System.Drawing.Point(258, 10);
            this.btnIstekSil.Name = "btnIstekSil";
            this.btnIstekSil.Size = new System.Drawing.Size(105, 36);
            this.btnIstekSil.TabIndex = 2;
            this.btnIstekSil.Text = "Kaydı Sil";
            this.btnIstekSil.UseVisualStyleBackColor = false;
            // 
            // btnSatinAlindi
            // 
            this.btnSatinAlindi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.btnSatinAlindi.FlatAppearance.BorderSize = 0;
            this.btnSatinAlindi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatinAlindi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAlindi.ForeColor = System.Drawing.Color.White;
            this.btnSatinAlindi.Location = new System.Drawing.Point(488, 10);
            this.btnSatinAlindi.Name = "btnSatinAlindi";
            this.btnSatinAlindi.Size = new System.Drawing.Size(225, 36);
            this.btnSatinAlindi.TabIndex = 1;
            this.btnSatinAlindi.Text = "Satın Alındı Olarak İşaretle";
            this.btnSatinAlindi.UseVisualStyleBackColor = false;
            // 
            // btnVazgecildi
            // 
            this.btnVazgecildi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnVazgecildi.FlatAppearance.BorderSize = 0;
            this.btnVazgecildi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgecildi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgecildi.ForeColor = System.Drawing.Color.White;
            this.btnVazgecildi.Location = new System.Drawing.Point(385, 10);
            this.btnVazgecildi.Name = "btnVazgecildi";
            this.btnVazgecildi.Size = new System.Drawing.Size(95, 36);
            this.btnVazgecildi.TabIndex = 0;
            this.btnVazgecildi.Text = "Vazgeç";
            this.btnVazgecildi.UseVisualStyleBackColor = false;
            // 
            // FormKarantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(924, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvKarantina);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormKarantina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstek Karantinası ve Karar Merkezi";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarantina)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbDurumFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSeciliIstekBilgi;
        private System.Windows.Forms.DataGridView dgvKarantina;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVazgecildi;
        private System.Windows.Forms.Button btnKarantinaGeriDon;
        private System.Windows.Forms.Button btnIstekSil;
        private System.Windows.Forms.Button btnSatinAlindi;
        private System.Windows.Forms.Button btnIstekGuncelleAc;
        private System.Windows.Forms.Button btnYeniIstekAc;
    }
}