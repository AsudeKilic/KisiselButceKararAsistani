namespace KisiselButceIstekIhtiyac
{
    partial class FormZorunluGider
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiderTutar = new System.Windows.Forms.TextBox();
            this.btnGiderKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zorunlu Gider Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gider Adı (Kira, Fatura, Market vb.):";
            // 
            // txtGiderTutar
            // 
            this.txtGiderTutar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGiderTutar.Location = new System.Drawing.Point(40, 195);
            this.txtGiderTutar.Name = "txtGiderTutar";
            this.txtGiderTutar.Size = new System.Drawing.Size(250, 27);
            this.txtGiderTutar.TabIndex = 2;
            // 
            // btnGiderKaydet
            // 
            this.btnGiderKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnGiderKaydet.FlatAppearance.BorderSize = 0;
            this.btnGiderKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderKaydet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderKaydet.ForeColor = System.Drawing.Color.White;
            this.btnGiderKaydet.Location = new System.Drawing.Point(40, 260);
            this.btnGiderKaydet.Name = "btnGiderKaydet";
            this.btnGiderKaydet.Size = new System.Drawing.Size(250, 45);
            this.btnGiderKaydet.TabIndex = 3;
            this.btnGiderKaydet.Text = "Hemen Bütçeden Düş";
            this.btnGiderKaydet.UseVisualStyleBackColor = false;
            // 
            // FormZorunluGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.btnGiderKaydet);
            this.Controls.Add(this.txtGiderTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormZorunluGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZorunluGider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiderTutar;
        private System.Windows.Forms.Button btnGiderKaydet;
    }
}