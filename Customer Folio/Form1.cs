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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int roomCounter = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            // ROOMS
            dataGridView1.Columns.Add("colRoomNumber", "Room Number");
            dataGridView1.Columns.Add("colCustomerName", "Name");
            dataGridView1.Columns.Add("colPhone", "Phone");
            dataGridView1.Columns.Add("colEmail", "Email");
            dataGridView1.Columns.Add("colRoom", "Room Type");
            dataGridView1.Columns.Add("colBeds", "Beds");
            dataGridView1.Columns.Add("colBedType", "Bed Type");
            dataGridView1.Columns.Add("colDate", "Date");

            // INVENTORY FIX
            dataGridViewInventory.Columns.Clear();
            dataGridViewInventory.AutoGenerateColumns = false;

            dataGridViewInventory.Columns.Add("colImage", "Image");
            dataGridViewInventory.Columns.Add("colName", "Product Name");
            dataGridViewInventory.Columns.Add("colStock", "Stock");
            dataGridViewInventory.Columns.Add("colPrice", "Price");
            dataGridViewInventory.Columns.Add("colDesc", "Description");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookCustomer newForm = new BookCustomer();

            newForm.OnBookNow += (CustomerName, phone, email, roomType, beds, bedType, date) =>
            {
                string roomNumber = roomCounter.ToString("D4");

                dataGridView1.Rows.Add(
                    roomNumber,
                    CustomerName,
                    phone,
                    email,
                    roomType,
                    beds,
                    bedType,
                    date
                );

                roomCounter++;
            };

            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddInventory form = new AddInventory();

            form.OnAddProduct += (img, name, stock, price, desc, x) =>
            {
                dataGridViewInventory.Rows.Add(img, name, stock, price, desc);
            };

            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete ALL records?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                MessageBox.Show("All records have been deleted.");
            }
        }
    }
}
