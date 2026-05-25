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
            product=_product;
            main=_main;
            label1.Text = product.Category + " | " + product.NameTovar;
            label2.Text = "Описание товара:"+product.Description;
            label3.Text = "Производитель:"+product.Manufactor;
            label4.Text = "Поставщик:"+product.Suplier;
            label5.Text = "Цена:"+product.Price.ToString();
            label6.Text = "Единица измерения:" + product.Unit;
            label7.Text="Количество на складе:"+product.Quantity.ToString();
            label8.Text=product.Discount.ToString()+"%";
        }
    }
}
