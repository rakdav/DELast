namespace DE
{
    partial class ProductForm
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
            textBoxArticul = new TextBox();
            textBoxName = new TextBox();
            textBoxUnit = new TextBox();
            textBoxPrice = new TextBox();
            textBoxSuplier = new TextBox();
            textBoxManufactor = new TextBox();
            comboBoxCategory = new ComboBox();
            textBoxDiscount = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxDescription = new TextBox();
            pictureBoxImage = new PictureBox();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonCancel = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // textBoxArticul
            // 
            textBoxArticul.Location = new Point(12, 12);
            textBoxArticul.Name = "textBoxArticul";
            textBoxArticul.PlaceholderText = "Введите артикул";
            textBoxArticul.Size = new Size(291, 23);
            textBoxArticul.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 53);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите  наименование";
            textBoxName.Size = new Size(291, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxUnit
            // 
            textBoxUnit.Location = new Point(12, 95);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.PlaceholderText = "Введите единицу измерения";
            textBoxUnit.Size = new Size(291, 23);
            textBoxUnit.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(12, 139);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Введите цену";
            textBoxPrice.Size = new Size(291, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // textBoxSuplier
            // 
            textBoxSuplier.Location = new Point(12, 185);
            textBoxSuplier.Name = "textBoxSuplier";
            textBoxSuplier.PlaceholderText = "Введите поставщика";
            textBoxSuplier.Size = new Size(291, 23);
            textBoxSuplier.TabIndex = 4;
            // 
            // textBoxManufactor
            // 
            textBoxManufactor.Location = new Point(12, 230);
            textBoxManufactor.Name = "textBoxManufactor";
            textBoxManufactor.PlaceholderText = "Введите производителя";
            textBoxManufactor.Size = new Size(291, 23);
            textBoxManufactor.TabIndex = 5;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Выберите категорию ...", "Женская обувь", "Мужская обувь" });
            comboBoxCategory.Location = new Point(13, 279);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(290, 23);
            comboBoxCategory.TabIndex = 6;
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Location = new Point(12, 322);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.PlaceholderText = "Введите скидку";
            textBoxDiscount.Size = new Size(291, 23);
            textBoxDiscount.TabIndex = 7;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(12, 367);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.PlaceholderText = "Введите остаток";
            textBoxQuantity.Size = new Size(291, 23);
            textBoxQuantity.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 401);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Введите пояснение";
            textBoxDescription.Size = new Size(290, 122);
            textBoxDescription.TabIndex = 9;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(335, 14);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(338, 376);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 10;
            pictureBoxImage.TabStop = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(335, 401);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(338, 57);
            buttonLoad.TabIndex = 11;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(335, 480);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(142, 40);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(525, 480);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 40);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 532);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(pictureBoxImage);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxDiscount);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxManufactor);
            Controls.Add(textBoxSuplier);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxUnit);
            Controls.Add(textBoxName);
            Controls.Add(textBoxArticul);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxImage;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonCancel;
        private OpenFileDialog openFileDialog1;
        public TextBox textBoxArticul;
        public TextBox textBoxName;
        public TextBox textBoxUnit;
        public TextBox textBoxPrice;
        public TextBox textBoxSuplier;
        public TextBox textBoxManufactor;
        public ComboBox comboBoxCategory;
        public TextBox textBoxDiscount;
        public TextBox textBoxQuantity;
        public TextBox textBoxDescription;
    }
}