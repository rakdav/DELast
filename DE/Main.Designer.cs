namespace DE
{
    partial class Main
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
            panel1 = new Panel();
            labelUser = new Label();
            button1 = new Button();
            textBoxFilter = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 350);
            panel1.TabIndex = 0;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(12, 9);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(38, 15);
            labelUser.TabIndex = 1;
            labelUser.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(537, 404);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Добавить ...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(633, 33);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(173, 23);
            textBoxFilter.TabIndex = 3;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Выберите поле фильтрации", "Артикул", "Название", "Единица измерения", "Цена", "Поставщик", "Категория", "Производитель", "Скидка", "Количество" });
            comboBox1.Location = new Point(633, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Возр", "Убыв" });
            comboBox2.Location = new Point(633, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(173, 23);
            comboBox2.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBoxFilter);
            Controls.Add(button1);
            Controls.Add(labelUser);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Главная";
            FormClosed += Main_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelUser;
        private Button button1;
        private TextBox textBoxFilter;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}