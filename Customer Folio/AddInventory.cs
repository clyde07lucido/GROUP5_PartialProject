using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Folio
{
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }
        public event Action<string, string, string, string, string, string> OnAddProduct;

        public bool IsEdit = false;
        public DataGridViewRow EditRow;

        public void SetData(string img, string name, string stock, string price, string desc)
        {
            pictureBox1.ImageLocation = img;
            txtProductName.Text = name;
            txtStock.Text = stock;
            txtPrice.Text = price;
            txtDescription.Text = desc;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string img = pictureBox1.ImageLocation;
            string name = txtProductName.Text;
            string stock = txtStock.Text;
            string price = txtPrice.Text;
            string desc = txtDescription.Text;

            if (IsEdit)
            {
                EditRow.Cells[0].Value = img;
                EditRow.Cells[1].Value = name;
                EditRow.Cells[2].Value = stock;
                EditRow.Cells[3].Value = price;
                EditRow.Cells[4].Value = desc;
            }
            else
            {
                OnAddProduct?.Invoke(img, name, stock, price, desc, "");
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
