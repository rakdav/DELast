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

        }
    }
}
