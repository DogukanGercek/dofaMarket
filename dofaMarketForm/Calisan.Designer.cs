namespace dofaMarketForm
{
    partial class Calisan
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
            barkodTextBox = new TextBox();
            label1 = new Label();
            urunData = new DataGridView();
            toplamtextBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            vParaTextBox = new TextBox();
            pUstutextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            eklebutton = new Button();
            odeButton = new Button();
            faturadGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)urunData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)faturadGV).BeginInit();
            SuspendLayout();
            // 
            // barkodTextBox
            // 
            barkodTextBox.Location = new Point(182, 79);
            barkodTextBox.Name = "barkodTextBox";
            barkodTextBox.Size = new Size(171, 23);
            barkodTextBox.TabIndex = 0;
            barkodTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürün barkodu okutunuz :";
            // 
            // urunData
            // 
            urunData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            urunData.Location = new Point(383, 68);
            urunData.Name = "urunData";
            urunData.RowTemplate.Height = 25;
            urunData.Size = new Size(405, 107);
            urunData.TabIndex = 2;
            urunData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // toplamtextBox
            // 
            toplamtextBox.Location = new Point(182, 152);
            toplamtextBox.Name = "toplamtextBox";
            toplamtextBox.Size = new Size(171, 23);
            toplamtextBox.TabIndex = 3;
            toplamtextBox.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(110, 152);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Toplam :";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(606, 347);
            button1.Name = "button1";
            button1.Size = new Size(116, 34);
            button1.TabIndex = 5;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // vParaTextBox
            // 
            vParaTextBox.Location = new Point(116, 351);
            vParaTextBox.Name = "vParaTextBox";
            vParaTextBox.Size = new Size(100, 23);
            vParaTextBox.TabIndex = 6;
            vParaTextBox.TextChanged += textBox3_TextChanged;
            // 
            // pUstutextBox
            // 
            pUstutextBox.Location = new Point(383, 350);
            pUstutextBox.Name = "pUstutextBox";
            pUstutextBox.Size = new Size(100, 23);
            pUstutextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 353);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 8;
            label3.Text = "Verilen para :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(298, 354);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Para üstü : ";
            // 
            // eklebutton
            // 
            eklebutton.Location = new Point(232, 108);
            eklebutton.Name = "eklebutton";
            eklebutton.Size = new Size(75, 23);
            eklebutton.TabIndex = 10;
            eklebutton.Text = "Ekle";
            eklebutton.UseVisualStyleBackColor = true;
            eklebutton.Click += button2_Click;
            // 
            // odeButton
            // 
            odeButton.Location = new Point(127, 380);
            odeButton.Name = "odeButton";
            odeButton.Size = new Size(75, 23);
            odeButton.TabIndex = 11;
            odeButton.Text = "Öde";
            odeButton.UseVisualStyleBackColor = true;
            odeButton.Click += button2_Click_1;
            // 
            // faturadGV
            // 
            faturadGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            faturadGV.Location = new Point(794, 21);
            faturadGV.Name = "faturadGV";
            faturadGV.RowTemplate.Height = 25;
            faturadGV.Size = new Size(309, 402);
            faturadGV.TabIndex = 12;
            // 
            // Calisan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 450);
            Controls.Add(faturadGV);
            Controls.Add(odeButton);
            Controls.Add(eklebutton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pUstutextBox);
            Controls.Add(vParaTextBox);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(toplamtextBox);
            Controls.Add(urunData);
            Controls.Add(label1);
            Controls.Add(barkodTextBox);
            Name = "Calisan";
            Text = "Calisan";
            Load += Calisan_Load;
            ((System.ComponentModel.ISupportInitialize)urunData).EndInit();
            ((System.ComponentModel.ISupportInitialize)faturadGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox barkodTextBox;
        private Label label1;
        private DataGridView urunData;
        private TextBox toplamtextBox;
        private Label label2;
        private Button button1;
        private TextBox vParaTextBox;
        private TextBox pUstutextBox;
        private Label label3;
        private Label label4;
        private Button eklebutton;
        private Button odeButton;
        private DataGridView faturadGV;
    }
}