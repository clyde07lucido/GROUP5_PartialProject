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

        private void button2_Click(object sender, EventArgs e)
        {
            string imagePath = pictureBox1.ImageLocation; // or store file path
            string productName = txtProductName.Text;
            string stock = txtStock.Text;
            string price = txtPrice.Text;
            string description = txtDescription.Text;

            OnAddProduct?.Invoke(imagePath, productName, stock, price, description, "");

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
