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
    public partial class TovarControl : UserControl
    {
        private Product product;
        private Main main;
        public TovarControl(Product _product, Main _main)
        {
            InitializeComponent();
            product = _product;
            main = _main;
            try
            {
                label1.Text = product.Category + " | " + product.NameTovar;
                label2.Text = "Описание товара:" + product.Description;
                label3.Text = "Производитель:" + product.Manufactor;
                label4.Text = "Поставщик:" + product.Suplier;
                label5.Text = "Цена:" + product.Price.ToString();
                label6.Text = "Единица измерения:" + product.Unit;
                label7.Text = "Количество на складе:" + product.Quantity.ToString();
                label8.Text = product.Discount.ToString() + "%";
                if(product.Discount>15) this.BackColor= Color.FromArgb(46, 139, 87);
                if (product.Discount > 0)
                {
                    label5.Font = new Font(new FontFamily("Times New Roman"), 9, FontStyle.Strikeout);
                    label5.ForeColor = Color.Red;
                    label9.Visible = true;
                    decimal price = (decimal)(1 - (product.Discount / 100.0)) * product.Price;
                    label9.Text = price.ToString("F2");
                }
                if (product.Photo != "" && product.Photo != null)
                {
                    pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Photo\" + product.Photo);
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.picture;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TovarControl_DoubleClick(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm(product);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (De17BdContext db = new De17BdContext())
                {
                    product = db.Products.FirstOrDefault(p => p.Articul == product.Articul)!;
                }

                product.Articul = form.textBoxArticul.Text;
                product.NameTovar = form.textBoxName.Text;
                product.Unit = form.textBoxUnit.Text;
                product.Price = decimal.Parse(form.textBoxPrice.Text);
                product.Suplier = form.textBoxSuplier.Text;
                product.Manufactor = form.textBoxManufactor.Text;
                if (form.comboBoxCategory.SelectedIndex != 0)
                {
                    product.Category = form.comboBoxCategory.Text;
                }
                else
                {
                    product.Category = "Женская обувь";
                }
                product.Discount = int.Parse(form.textBoxDiscount.Text);
                product.Quantity = int.Parse(form.textBoxQuantity.Text);
                product.Description = form.textBoxDescription.Text;
                if (form.FilePath != null)
                {
                    FileInfo file = new FileInfo(form.FilePath);
                    file.CopyTo(Environment.CurrentDirectory + @"\Photo\" + form.FileName, true);
                    product.Photo = form.FileName;
                }
                using (De17BdContext db = new De17BdContext())
                {
                    try
                    {
                        db.Products.Update(product);
                        db.SaveChanges();
                        main.updateForm(db.Products.ToList());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (De17BdContext db=new De17BdContext())
            {
                db.Products.Remove(product);
                db.SaveChanges();
                main.updateForm(db.Products.ToList());
            }
        }
    }
}
