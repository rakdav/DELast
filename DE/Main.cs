using DE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DE
{
    public partial class Main : Form
    {
        private List<Product> list;
        public Main()
        {
            InitializeComponent();
            labelUser.Text = Form1.User.SurName + " " + Form1.User.FirstName.Substring(0, 1) + "." + Form1.User.LastName.Substring(0, 1) + ".";
            using (De17BdContext db = new De17BdContext())
            {
                list = db.Products.ToList();
                updateForm(list);
            }
        }
        public void updateForm(List<Product> list)
        {
            panel1.Controls.Clear();
            int y = 0;
            foreach (Product product in list)
            {
                TovarControl tc = new TovarControl(product, this);
                tc.Top = y;
                panel1.Controls.Add(tc);
                y += tc.Height;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm(new Product());
            if (form.ShowDialog() == DialogResult.OK)
            {
                Product product = new Product();
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
                product.Quantity = int.Parse(form.textBoxPrice.Text);
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
                        db.Products.Add(product);
                        db.SaveChanges();
                        updateForm(db.Products.ToList());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Instance.Show();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            using (De17BdContext db = new De17BdContext())
            {
                if (textBoxFilter.Text.Length > 0)
                {

                    list = db.Products.Where(p => p.NameTovar.StartsWith(textBoxFilter.Text) || p.Articul.StartsWith(textBoxFilter.Text) ||
                                        p.Unit.StartsWith(textBoxFilter.Text) ||
                                        p.Suplier.StartsWith(textBoxFilter.Text) ||
                                        p.Manufactor.StartsWith(textBoxFilter.Text) ||
                                        p.Category.StartsWith(textBoxFilter.Text)).ToList();
                    updateForm(list);
                }
                else
                {
                    list=db.Products.ToList(); 
                    updateForm(list);
                }
            }
        }
    }
}
