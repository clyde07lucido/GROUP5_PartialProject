using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Customer_Folio
{
    public partial class BookCustomer : Form
    {
        public BookCustomer()
        {
            InitializeComponent();
        }

        public event Action<string, string, string, string, string, string, string> OnBookNow;
        public bool IsEdit = false;
        public DataGridViewRow EditRow;

        public void SetData(string name, string phone, string email, string roomType, string beds, string bedType, string date)
        {
            textBoxName.Text = name;
            textBoxPhone.Text = phone;
            textBoxEmail.Text = email;
            comboBoxRoomType.Text = roomType;
            comboBoxBeds.Text = beds;
            comboBoxBedType.Text = bedType;
            monthCalendar1.Text = date;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;

            string roomType = comboBoxRoomType.Text;
            string beds = comboBoxBeds.Text;
            string bedType = comboBoxBedType.Text;

            string date = monthCalendar1.SelectionStart.ToShortDateString();

            if (IsEdit)
            {
                EditRow.Cells[1].Value = name;
                EditRow.Cells[2].Value = phone;
                EditRow.Cells[3].Value = email;
                EditRow.Cells[4].Value = roomType;
                EditRow.Cells[5].Value = beds;
                EditRow.Cells[6].Value = bedType;
                EditRow.Cells[7].Value = date;
            }
            else
            {
                OnBookNow?.Invoke(name, phone, email, roomType, beds, bedType, date);
            }

            this.Close();
        }

        private void BookCustomer_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cbNoBeds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRoomType_Click(object sender, EventArgs e)
        {

        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNoBeds_Click(object sender, EventArgs e)
        {

        }

        private void lblBedType_Click(object sender, EventArgs e)
        {

        }

        private void cbBedType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbSched_Enter(object sender, EventArgs e)
        {

        }


    }
}
