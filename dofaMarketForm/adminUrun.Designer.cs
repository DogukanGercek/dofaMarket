namespace dofaMarketForm
{
    partial class adminUrun
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
            components = new System.ComponentModel.Container();
            urunlerGrid = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            idTextbox = new TextBox();
            stokTextbox = new TextBox();
            ureticiTextbox = new TextBox();
            fiyatTextbox = new TextBox();
            isimTextbox = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label7 = new Label();
            employeeBindingSource = new BindingSource(components);
            label1 = new Label();
            kategoriTextbox = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)urunlerGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // urunlerGrid
            // 
            urunlerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            urunlerGrid.Location = new Point(74, 60);
            urunlerGrid.Name = "urunlerGrid";
            urunlerGrid.RowTemplate.Height = 25;
            urunlerGrid.Size = new Size(240, 255);
            urunlerGrid.TabIndex = 0;
            urunlerGrid.CellClick += urunlerGrid_CellClick;
            urunlerGrid.CellContentClick += urunlerGrid_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 60);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "BİLGİLER";
            // 
            // button1
            // 
            button1.Location = new Point(649, 184);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 4;
            button1.Text = "Ürünü Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(649, 226);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 5;
            button2.Text = "Bilgileri Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 115);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 149);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "İsim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 188);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "Fiyat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 226);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 9;
            label6.Text = "Üretici";
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(465, 107);
            idTextbox.Name = "idTextbox";
            idTextbox.Size = new Size(134, 23);
            idTextbox.TabIndex = 14;
            // 
            // stokTextbox
            // 
            stokTextbox.Location = new Point(465, 253);
            stokTextbox.Name = "stokTextbox";
            stokTextbox.Size = new Size(134, 23);
            stokTextbox.TabIndex = 16;
            // 
            // ureticiTextbox
            // 
            ureticiTextbox.Location = new Point(465, 218);
            ureticiTextbox.Name = "ureticiTextbox";
            ureticiTextbox.Size = new Size(134, 23);
            ureticiTextbox.TabIndex = 17;
            // 
            // fiyatTextbox
            // 
            fiyatTextbox.Location = new Point(465, 180);
            fiyatTextbox.Name = "fiyatTextbox";
            fiyatTextbox.Size = new Size(134, 23);
            fiyatTextbox.TabIndex = 18;
            // 
            // isimTextbox
            // 
            isimTextbox.Location = new Point(465, 141);
            isimTextbox.Name = "isimTextbox";
            isimTextbox.Size = new Size(134, 23);
            isimTextbox.TabIndex = 19;
            // 
            // button3
            // 
            button3.Location = new Point(708, 385);
            button3.Name = "button3";
            button3.Size = new Size(54, 23);
            button3.TabIndex = 22;
            button3.Text = "Ara";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(649, 140);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 23;
            button4.Text = "Ürün Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(116, 31);
            button5.Name = "button5";
            button5.Size = new Size(158, 23);
            button5.TabIndex = 24;
            button5.Text = "ÜRÜNLERİ GÖSTER";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 261);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 10;
            label7.Text = "Stok";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 300);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 25;
            label1.Text = "Kategori";
            // 
            // kategoriTextbox
            // 
            kategoriTextbox.Location = new Point(465, 292);
            kategoriTextbox.Name = "kategoriTextbox";
            kategoriTextbox.Size = new Size(134, 23);
            kategoriTextbox.TabIndex = 26;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(563, 386);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(120, 23);
            textBox7.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(418, 386);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // button6
            // 
            button6.Location = new Point(649, 270);
            button6.Name = "button6";
            button6.Size = new Size(113, 23);
            button6.TabIndex = 29;
            button6.Text = "Temizle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // adminUrun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(kategoriTextbox);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(isimTextbox);
            Controls.Add(fiyatTextbox);
            Controls.Add(ureticiTextbox);
            Controls.Add(stokTextbox);
            Controls.Add(idTextbox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(urunlerGrid);
            Name = "adminUrun";
            Text = "Urun Bilgileri";
            Load += adminUrun_Load;
            ((System.ComponentModel.ISupportInitialize)urunlerGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView urunlerGrid;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox idTextbox;
        private TextBox stokTextbox;
        private TextBox ureticiTextbox;
        private TextBox fiyatTextbox;
        private TextBox isimTextbox;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label7;
        private BindingSource employeeBindingSource;
        private Label label1;
        private TextBox kategoriTextbox;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private BindingSource categoryBindingSource;
        private Button button6;
    }
}