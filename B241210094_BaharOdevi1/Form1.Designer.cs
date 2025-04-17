namespace B241210094_BaharOdevi1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            txtAdi = new TextBox();
            txtCins = new TextBox();
            txtFiyat = new TextBox();
            txtKdv = new TextBox();
            txtKalori = new TextBox();
            btnSil = new Button();
            btnEkle = new Button();
            listBox1 = new ListBox();
            lblFiyatToplam = new Label();
            lblKaloriToplam = new Label();
            label1 = new Label();
            lblAdi = new Label();
            lblCins = new Label();
            lblFiyat = new Label();
            lblKdv = new Label();
            lblKalori = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMenuGoster = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Meyve", "Tatlı", "Salata", "İçecek" });
            comboBox1.Location = new Point(145, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(145, 79);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(150, 31);
            txtAdi.TabIndex = 1;
            // 
            // txtCins
            // 
            txtCins.Location = new Point(145, 116);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(150, 31);
            txtCins.TabIndex = 2;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(145, 150);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(150, 31);
            txtFiyat.TabIndex = 3;
            // 
            // txtKdv
            // 
            txtKdv.Location = new Point(145, 187);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(150, 31);
            txtKdv.TabIndex = 4;
            // 
            // txtKalori
            // 
            txtKalori.Location = new Point(145, 222);
            txtKalori.Name = "txtKalori";
            txtKalori.Size = new Size(150, 31);
            txtKalori.TabIndex = 5;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveBorder;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(120, 258);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveBorder;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(238, 258);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(385, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(377, 204);
            listBox1.TabIndex = 8;
            // 
            // lblFiyatToplam
            // 
            lblFiyatToplam.BackColor = SystemColors.ActiveBorder;
            lblFiyatToplam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblFiyatToplam.Location = new Point(385, 258);
            lblFiyatToplam.Name = "lblFiyatToplam";
            lblFiyatToplam.Size = new Size(377, 33);
            lblFiyatToplam.TabIndex = 9;
            // 
            // lblKaloriToplam
            // 
            lblKaloriToplam.BackColor = SystemColors.ActiveBorder;
            lblKaloriToplam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblKaloriToplam.Location = new Point(385, 298);
            lblKaloriToplam.Name = "lblKaloriToplam";
            lblKaloriToplam.Size = new Size(377, 33);
            lblKaloriToplam.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(49, 45);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 11;
            label1.Text = "Kategori";
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAdi.Location = new Point(49, 82);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(35, 25);
            lblAdi.TabIndex = 12;
            lblAdi.Text = "Ad";
            // 
            // lblCins
            // 
            lblCins.AutoSize = true;
            lblCins.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCins.Location = new Point(49, 122);
            lblCins.Name = "lblCins";
            lblCins.Size = new Size(47, 25);
            lblCins.TabIndex = 13;
            lblCins.Text = "Cins";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblFiyat.Location = new Point(49, 156);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(51, 25);
            lblFiyat.TabIndex = 14;
            lblFiyat.Text = "Fiyat";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKdv.Location = new Point(49, 190);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(94, 25);
            lblKdv.TabIndex = 15;
            lblKdv.Text = "Kdv Oranı";
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKalori.Location = new Point(49, 225);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(60, 25);
            lblKalori.TabIndex = 16;
            lblKalori.Text = "Kalori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(521, 2);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 17;
            label2.Text = "MENÜ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(49, 9);
            label3.Name = "label3";
            label3.Size = new Size(305, 25);
            label3.TabIndex = 18;
            label3.Text = "Menü oluşturmak için bilgileri giriniz.";
            // 
            // btnMenuGoster
            // 
            btnMenuGoster.BackColor = SystemColors.ActiveBorder;
            btnMenuGoster.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnMenuGoster.Location = new Point(145, 298);
            btnMenuGoster.Name = "btnMenuGoster";
            btnMenuGoster.Size = new Size(171, 34);
            btnMenuGoster.TabIndex = 19;
            btnMenuGoster.Text = "Menüyü Tamamla";
            btnMenuGoster.UseVisualStyleBackColor = false;
            btnMenuGoster.Click += btnMenuGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 341);
            Controls.Add(btnMenuGoster);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblKalori);
            Controls.Add(lblKdv);
            Controls.Add(lblFiyat);
            Controls.Add(lblCins);
            Controls.Add(lblAdi);
            Controls.Add(label1);
            Controls.Add(lblKaloriToplam);
            Controls.Add(lblFiyatToplam);
            Controls.Add(listBox1);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(txtKalori);
            Controls.Add(txtKdv);
            Controls.Add(txtFiyat);
            Controls.Add(txtCins);
            Controls.Add(txtAdi);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Menüsü";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txtAdi;
        private TextBox txtCins;
        private TextBox txtFiyat;
        private TextBox txtKdv;
        private TextBox txtKalori;
        private Button btnSil;
        private Button btnEkle;
        private ListBox listBox1;
        private Label lblFiyatToplam;
        private Label lblKaloriToplam;
        private Label label1;
        private Label lblAdi;
        private Label lblCins;
        private Label lblFiyat;
        private Label lblKdv;
        private Label lblKalori;
        private Label label2;
        private Label label3;
        private Button btnMenuGoster;
    }
}
