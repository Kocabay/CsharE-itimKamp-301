namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmCategory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtKategoriId = new TextBox();
            btnList = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtKategoriAd = new TextBox();
            label3 = new Label();
            rdbActive = new RadioButton();
            rdbPassive = new RadioButton();
            btnId = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori Id :";
            // 
            // txtKategoriId
            // 
            txtKategoriId.Location = new Point(128, 20);
            txtKategoriId.Name = "txtKategoriId";
            txtKategoriId.Size = new Size(158, 23);
            txtKategoriId.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.Location = new Point(128, 149);
            btnList.Name = "btnList";
            btnList.Size = new Size(158, 41);
            btnList.TabIndex = 2;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(329, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(667, 412);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 104);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "Kategori Durum :";
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Location = new Point(128, 59);
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new Size(158, 23);
            txtKategoriAd.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 62);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "Kategori Adı :";
            // 
            // rdbActive
            // 
            rdbActive.AutoSize = true;
            rdbActive.Location = new Point(145, 100);
            rdbActive.Name = "rdbActive";
            rdbActive.Size = new Size(50, 19);
            rdbActive.TabIndex = 8;
            rdbActive.TabStop = true;
            rdbActive.Text = "Aktif";
            rdbActive.UseVisualStyleBackColor = true;
            rdbActive.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbPassive
            // 
            rdbPassive.AutoSize = true;
            rdbPassive.Location = new Point(222, 102);
            rdbPassive.Name = "rdbPassive";
            rdbPassive.Size = new Size(50, 19);
            rdbPassive.TabIndex = 9;
            rdbPassive.TabStop = true;
            rdbPassive.Text = "Pasif";
            rdbPassive.UseVisualStyleBackColor = true;
            // 
            // btnId
            // 
            btnId.Location = new Point(128, 394);
            btnId.Name = "btnId";
            btnId.Size = new Size(158, 41);
            btnId.TabIndex = 10;
            btnId.Text = "Id Göre Getir";
            btnId.UseVisualStyleBackColor = true;
            btnId.Click += btnId_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(128, 332);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(158, 41);
            btnGüncelle.TabIndex = 11;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(128, 269);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(158, 41);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(128, 211);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(158, 41);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 503);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnId);
            Controls.Add(rdbPassive);
            Controls.Add(rdbActive);
            Controls.Add(txtKategoriAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnList);
            Controls.Add(txtKategoriId);
            Controls.Add(label1);
            Name = "FrmCategory";
            Text = "Forum Kategori";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKategoriId;
        private Button btnList;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtKategoriAd;
        private Label label3;
        private RadioButton rdbActive;
        private RadioButton rdbPassive;
        private Button btnId;
        private Button btnGüncelle;
        private Button btnSil;
        private Button btnEkle;
    }
}
