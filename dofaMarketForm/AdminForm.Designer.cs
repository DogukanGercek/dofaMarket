namespace dofaMarketForm
{
    partial class AdminForm
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
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(110, 107);
            button2.Name = "button2";
            button2.Size = new Size(159, 61);
            button2.TabIndex = 1;
            button2.Text = "Çalışan Bilgileri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(329, 107);
            button3.Name = "button3";
            button3.Size = new Size(159, 61);
            button3.TabIndex = 2;
            button3.Text = "Ürün Bilgileri";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 314);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "AdminForm";
            Text = "admin";
            Load += AdminForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button3;
    }
}