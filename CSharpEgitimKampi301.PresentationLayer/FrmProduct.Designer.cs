namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            btnEkle = new Button();
            btnSil = new Button();
            btnGüncelle = new Button();
            btnId = new Button();
            txtProductName = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnList = new Button();
            txtProductId = new TextBox();
            label1 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            cmbKategori = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtAcıkalma = new TextBox();
            btnList2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(193, 360);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(158, 28);
            btnEkle.TabIndex = 26;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(193, 394);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(158, 25);
            btnSil.TabIndex = 25;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(193, 425);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(158, 28);
            btnGüncelle.TabIndex = 24;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnId
            // 
            btnId.Location = new Point(193, 459);
            btnId.Name = "btnId";
            btnId.Size = new Size(158, 23);
            btnId.TabIndex = 23;
            btnId.Text = "Id Göre Getir";
            btnId.UseVisualStyleBackColor = true;
            btnId.Click += btnId_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.Menu;
            txtProductName.Location = new Point(193, 87);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(158, 23);
            txtProductName.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 90);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 19;
            label3.Text = "Ürün Adı :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 431);
            dataGridView1.TabIndex = 17;
            // 
            // btnList
            // 
            btnList.Location = new Point(193, 324);
            btnList.Name = "btnList";
            btnList.Size = new Size(73, 30);
            btnList.TabIndex = 16;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // txtProductId
            // 
            txtProductId.BackColor = SystemColors.Menu;
            txtProductId.Location = new Point(193, 48);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(158, 23);
            txtProductId.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 51);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 14;
            label1.Text = "Ürün Id :";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Menu;
            txtPrice.Location = new Point(193, 168);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(158, 23);
            txtPrice.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 171);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 27;
            label4.Text = "Ürün Fiyat :";
            // 
            // txtStock
            // 
            txtStock.BackColor = SystemColors.Menu;
            txtStock.Location = new Point(193, 127);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(158, 23);
            txtStock.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 130);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 29;
            label5.Text = "Ürün Stok :";
            // 
            // cmbKategori
            // 
            cmbKategori.BackColor = SystemColors.Menu;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(193, 208);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(158, 23);
            cmbKategori.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 211);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 32;
            label6.Text = "Kategori :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 249);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 33;
            label7.Text = "Açıklama :";
            // 
            // txtAcıkalma
            // 
            txtAcıkalma.BackColor = SystemColors.Menu;
            txtAcıkalma.Location = new Point(193, 249);
            txtAcıkalma.Multiline = true;
            txtAcıkalma.Name = "txtAcıkalma";
            txtAcıkalma.Size = new Size(158, 69);
            txtAcıkalma.TabIndex = 34;
            // 
            // btnList2
            // 
            btnList2.Location = new Point(272, 324);
            btnList2.Name = "btnList2";
            btnList2.Size = new Size(79, 30);
            btnList2.TabIndex = 35;
            btnList2.Text = "Listele 2";
            btnList2.UseVisualStyleBackColor = true;
            btnList2.Click += btnList2_Click;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1363, 571);
            Controls.Add(btnList2);
            Controls.Add(txtAcıkalma);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbKategori);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnId);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnList);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Name = "FrmProduct";
            Text = "FrmProduct";
            Load += FrmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnId;
        private TextBox txtProductName;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnList;
        private TextBox txtProductId;
        private Label label1;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private ComboBox cmbKategori;
        private Label label6;
        private Label label7;
        private TextBox txtAcıkalma;
        private Button btnList2;
    }
}