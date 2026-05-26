using DE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DE
{
    public partial class ProductForm : Form
    {
        public string FilePath;
        public string FileName;
        public ProductForm(Product product)
        {
            InitializeComponent();
            comboBoxCategory.SelectedIndex = 0;
            if (product.Articul != null)
            {
                textBoxArticul.Text = product.Articul;
                textBoxDescription.Text = product.Description;
                textBoxDiscount.Text = product.Discount.ToString();
                textBoxPrice.Text = product.Price.ToString();
                textBoxSuplier.Text = product.Suplier;
                textBoxUnit.Text = product.Unit;
                textBoxManufactor.Text = product.Manufactor;
                textBoxName.Text = product.NameTovar;
                textBoxQuantity.Text = product.Quantity.ToString();
                if(product.Category=="Женская обувь")
                {
                    comboBoxCategory.SelectedIndex = 1;
                }
                else
                {
                    comboBoxCategory.SelectedIndex = 2;
                }
                if (product.Photo != "" && product.Photo != null)
                {
                    pictureBoxImage.Image = Image.FromFile(Environment.CurrentDirectory + @"\Photo\" + product.Photo);
                }
                else
                {
                    pictureBoxImage.Image = Properties.Resources.picture;
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImage.Image=Image.FromFile(openFileDialog1.FileName);
                FilePath= openFileDialog1.FileName;
                FileName = openFileDialog1.SafeFileName;
            }
        }
    }
}
