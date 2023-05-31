namespace dofaMarketForm
{
    partial class adminCalisan
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
            dataGridView2 = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            HireDate = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button5 = new Button();
            label2 = new Label();
            label11 = new Label();
            textBox9 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, EmployeeID, Title, BirthDate, Salary, HireDate, Tel });
            dataGridView2.Location = new Point(28, 72);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(251, 350);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "Ad";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Soyad";
            LastName.Name = "LastName";
            // 
            // EmployeeID
            // 
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Visible = false;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.Visible = false;
            // 
            // BirthDate
            // 
            BirthDate.DataPropertyName = "BirthDate";
            BirthDate.HeaderText = "BirthDate";
            BirthDate.Name = "BirthDate";
            BirthDate.Visible = false;
            // 
            // Salary
            // 
            Salary.DataPropertyName = "Salary";
            Salary.HeaderText = "Salary";
            Salary.Name = "Salary";
            Salary.Visible = false;
            // 
            // HireDate
            // 
            HireDate.DataPropertyName = "HireDate";
            HireDate.HeaderText = "HireDate";
            HireDate.Name = "HireDate";
            HireDate.Visible = false;
            // 
            // Tel
            // 
            Tel.DataPropertyName = "Tel";
            Tel.HeaderText = "Tel";
            Tel.Name = "Tel";
            Tel.Visible = false;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // button4
            // 
            button4.Location = new Point(66, 45);
            button4.Name = "button4";
            button4.Size = new Size(189, 23);
            button4.TabIndex = 13;
            button4.Text = "Çalışanları Göster";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(632, 191);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 44;
            button1.Text = "Çalışan Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(727, 12);
            button3.Name = "button3";
            button3.Size = new Size(50, 23);
            button3.TabIndex = 43;
            button3.Text = "Ara";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(467, 378);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 42;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(467, 340);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 41;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(467, 153);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 40;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(467, 192);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 39;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(467, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 38;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(467, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(467, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(467, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(344, 386);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 34;
            label10.Text = "Telefon numarası";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(344, 311);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 33;
            label9.Text = "İşe alınma tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 348);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 32;
            label8.Text = "Maaş";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 275);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 31;
            label7.Text = "Doğum tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 238);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 30;
            label6.Text = "Unvan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 200);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 29;
            label5.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 161);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 28;
            label4.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 127);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 27;
            label3.Text = "ID";
            // 
            // button2
            // 
            button2.Location = new Point(632, 266);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 26;
            button2.Text = "Bilgileri Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(632, 229);
            button5.Name = "button5";
            button5.Size = new Size(113, 23);
            button5.TabIndex = 25;
            button5.Text = "İşten Çıkar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 72);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 24;
            label2.Text = "BİLGİLER";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(554, 16);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 45;
            label11.Text = "Arama";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(602, 12);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(119, 23);
            textBox9.TabIndex = 46;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // adminCalisan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox9);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Name = "adminCalisan";
            Text = "Calisan Bilgileri";
            Load += adminCalisan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView2;
        private BindingSource employeeBindingSource;
        private Button button4;
        private Button button1;
        private Button button3;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button5;
        private Label label2;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn HireDate;
        private DataGridViewTextBoxColumn Tel;
        private Label label11;
        private TextBox textBox9;
    }
}