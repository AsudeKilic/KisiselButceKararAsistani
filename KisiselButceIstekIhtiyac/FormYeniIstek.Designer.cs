namespace KisiselButceIstekIhtiyac
{
    partial class FormYeniIstek
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
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaatlikKazan = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnKarantinaEkle = new System.Windows.Forms.Button();
            this.btnHemenAl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ne almak istiyorsun?";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUrunAdi.Location = new System.Drawing.Point(40, 55);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(350, 27);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyatı ne kadar? (TL)";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(40, 125);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(160, 20);
            this.txtFiyat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saatlik net kazancın nedir? (TL)";
            // 
            // txtSaatlikKazan
            // 
            this.txtSaatlikKazan.Location = new System.Drawing.Point(230, 125);
            this.txtSaatlikKazan.Name = "txtSaatlikKazan";
            this.txtSaatlikKazan.Size = new System.Drawing.Size(160, 20);
            this.txtSaatlikKazan.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnHesapla.FlatAppearance.BorderSize = 0;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(40, 180);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(350, 45);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Gerçek Maliyetini Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSonuc);
            this.panel1.Location = new System.Drawing.Point(40, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 120);
            this.panel1.TabIndex = 7;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblSonuc.Location = new System.Drawing.Point(0, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(351, 40);
            this.lblSonuc.TabIndex = 0;
            this.lblSonuc.Text = "\"Bu ürünü almak için hayatının 0 saatini feda etmen \r\ngerekiyor. Değer mi?\"";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnKarantinaEkle
            // 
            this.btnKarantinaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnKarantinaEkle.FlatAppearance.BorderSize = 0;
            this.btnKarantinaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarantinaEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarantinaEkle.ForeColor = System.Drawing.Color.White;
            this.btnKarantinaEkle.Location = new System.Drawing.Point(225, 400);
            this.btnKarantinaEkle.Name = "btnKarantinaEkle";
            this.btnKarantinaEkle.Size = new System.Drawing.Size(165, 45);
            this.btnKarantinaEkle.TabIndex = 8;
            this.btnKarantinaEkle.Text = "Karantinaya At (3 Gün)";
            this.btnKarantinaEkle.UseVisualStyleBackColor = false;
            // 
            // btnHemenAl
            // 
            this.btnHemenAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnHemenAl.FlatAppearance.BorderSize = 0;
            this.btnHemenAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHemenAl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHemenAl.ForeColor = System.Drawing.Color.White;
            this.btnHemenAl.Location = new System.Drawing.Point(40, 400);
            this.btnHemenAl.Name = "btnHemenAl";
            this.btnHemenAl.Size = new System.Drawing.Size(165, 45);
            this.btnHemenAl.TabIndex = 9;
            this.btnHemenAl.Text = "Yine de Al";
            this.btnHemenAl.UseVisualStyleBackColor = false;
            // 
            // FormYeniIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(434, 541);
            this.Controls.Add(this.btnHemenAl);
            this.Controls.Add(this.btnKarantinaEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSaatlikKazan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Name = "FormYeniIstek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni İstek ve Emek Analizi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaatlikKazan;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnKarantinaEkle;
        private System.Windows.Forms.Button btnHemenAl;
    }
}