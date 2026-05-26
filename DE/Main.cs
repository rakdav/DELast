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
            if(form.ShowDialog() == DialogResult.OK)
            {
                Product product=new Product();
                product.Articul=form.textBoxArticul.Text;
                product.NameTovar=form.textBoxName.Text;
                product.Unit=form.textBoxUnit.Text;
                product.Price=decimal.Parse(form.textBoxPrice.Text);
                product.Suplier=form.textBoxSuplier.Text;
                product.Manufactor=form.textBoxManufactor.Text;
                if (form.comboBoxCategory.SelectedIndex != 0)
                {
                    product.Category = form.comboBoxCategory.Text;
                }
                else
                {
                    product.Category = form.comboBoxCategory.Items[1]!.ToString()!;
                }
                product.Discount=int.Parse(form.textBoxDiscount.Text);
                product.Quantity = int.Parse(form.textBoxPrice.Text);
                product.Description= form.textBoxDescription.Text;
                if (form.FilePath != null)
                {
                    FileInfo file=new FileInfo(form.FilePath);
                    file.CopyTo(Environment.CurrentDirectory + @"\Photo\" + form.FileName, true);
                    product.Photo = form.FileName;
                }
                using (De17BdContext db=new De17BdContext())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    updateForm(db.Products.ToList());
                }
            }
        }
    }
}
