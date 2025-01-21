namespace CsharEğitimKampı301.EfProjec
{
    partial class FrmLocation
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
            this.txtsehir = new System.Windows.Forms.TextBox();
            this.txtulke = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textnamesehir = new System.Windows.Forms.Label();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.textsehir = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtdaynigh = new System.Windows.Forms.TextBox();
            this.txtdayng = new System.Windows.Forms.Label();
            this.txtpricee = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.Label();
            this.textcaps = new System.Windows.Forms.Label();
            this.cmbguid = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbGuide11 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsehir
            // 
            this.txtsehir.Location = new System.Drawing.Point(79, 86);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(252, 20);
            this.txtsehir.TabIndex = 31;
            // 
            // txtulke
            // 
            this.txtulke.Location = new System.Drawing.Point(79, 112);
            this.txtulke.Name = "txtulke";
            this.txtulke.Size = new System.Drawing.Size(252, 20);
            this.txtulke.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(79, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(252, 20);
            this.txtId.TabIndex = 29;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Sienna;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEkle.Location = new System.Drawing.Point(79, 282);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(252, 37);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textnamesehir
            // 
            this.textnamesehir.AutoSize = true;
            this.textnamesehir.Location = new System.Drawing.Point(42, 86);
            this.textnamesehir.Name = "textnamesehir";
            this.textnamesehir.Size = new System.Drawing.Size(31, 13);
            this.textnamesehir.TabIndex = 27;
            this.textnamesehir.Text = "Şehir";
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.Sienna;
            this.btnGetById.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetById.Location = new System.Drawing.Point(79, 408);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(252, 37);
            this.btnGetById.TabIndex = 25;
            this.btnGetById.Text = "Id Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Sienna;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.Location = new System.Drawing.Point(79, 366);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(252, 37);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Sienna;
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(79, 324);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(252, 37);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Sienna;
            this.btnList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnList.Location = new System.Drawing.Point(79, 240);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(252, 37);
            this.btnList.TabIndex = 22;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // textsehir
            // 
            this.textsehir.AutoSize = true;
            this.textsehir.Location = new System.Drawing.Point(44, 115);
            this.textsehir.Name = "textsehir";
            this.textsehir.Size = new System.Drawing.Size(29, 13);
            this.textsehir.TabIndex = 21;
            this.textsehir.Text = "Ülke";
            // 
            // textname
            // 
            this.textname.AutoSize = true;
            this.textname.Location = new System.Drawing.Point(2, 60);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(71, 13);
            this.textname.TabIndex = 20;
            this.textname.Text = "Lokasyon Id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 392);
            this.dataGridView1.TabIndex = 19;
            // 
            // txtdaynigh
            // 
            this.txtdaynigh.Location = new System.Drawing.Point(79, 190);
            this.txtdaynigh.Name = "txtdaynigh";
            this.txtdaynigh.Size = new System.Drawing.Size(252, 20);
            this.txtdaynigh.TabIndex = 33;
            // 
            // txtdayng
            // 
            this.txtdayng.AutoSize = true;
            this.txtdayng.Location = new System.Drawing.Point(17, 195);
            this.txtdayng.Name = "txtdayng";
            this.txtdayng.Size = new System.Drawing.Size(56, 13);
            this.txtdayng.TabIndex = 32;
            this.txtdayng.Text = "Gün Gece";
            this.txtdayng.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpricee
            // 
            this.txtpricee.Location = new System.Drawing.Point(79, 164);
            this.txtpricee.Name = "txtpricee";
            this.txtpricee.Size = new System.Drawing.Size(252, 20);
            this.txtpricee.TabIndex = 35;
            // 
            // txtfiyat
            // 
            this.txtfiyat.AutoSize = true;
            this.txtfiyat.Location = new System.Drawing.Point(38, 167);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(35, 13);
            this.txtfiyat.TabIndex = 34;
            this.txtfiyat.Text = "Fiyat :";
            // 
            // textcaps
            // 
            this.textcaps.AutoSize = true;
            this.textcaps.Location = new System.Drawing.Point(25, 141);
            this.textcaps.Name = "textcaps";
            this.textcaps.Size = new System.Drawing.Size(48, 13);
            this.textcaps.TabIndex = 36;
            this.textcaps.Text = "Kapasite";
            // 
            // cmbguid
            // 
            this.cmbguid.AutoSize = true;
            this.cmbguid.Location = new System.Drawing.Point(25, 219);
            this.cmbguid.Name = "cmbguid";
            this.cmbguid.Size = new System.Drawing.Size(48, 13);
            this.cmbguid.TabIndex = 38;
            this.cmbguid.Text = "Rehber :";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(79, 139);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(252, 20);
            this.nudCapacity.TabIndex = 40;
            // 
            // cmbGuide11
            // 
            this.cmbGuide11.FormattingEnabled = true;
            this.cmbGuide11.Location = new System.Drawing.Point(79, 213);
            this.cmbGuide11.Name = "cmbGuide11";
            this.cmbGuide11.Size = new System.Drawing.Size(252, 21);
            this.cmbGuide11.TabIndex = 41;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 470);
            this.Controls.Add(this.cmbGuide11);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.cmbguid);
            this.Controls.Add(this.textcaps);
            this.Controls.Add(this.txtpricee);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtdaynigh);
            this.Controls.Add(this.txtdayng);
            this.Controls.Add(this.txtsehir);
            this.Controls.Add(this.txtulke);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textnamesehir);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.textsehir);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsehir;
        private System.Windows.Forms.TextBox txtulke;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label textnamesehir;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label textsehir;
        private System.Windows.Forms.Label textname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdaynigh;
        private System.Windows.Forms.Label txtdayng;
        private System.Windows.Forms.TextBox txtpricee;
        private System.Windows.Forms.Label txtfiyat;
        private System.Windows.Forms.Label textcaps;
        private System.Windows.Forms.Label cmbguid;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.ComboBox cmbGuide11;
    }
}