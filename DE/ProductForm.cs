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
