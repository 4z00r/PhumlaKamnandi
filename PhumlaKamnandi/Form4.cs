using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi
{
    public partial class Form4 : Form
    {
        public Hotel hotel;
        public Form4(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }

        private void NameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServiceBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServiceBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreditBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomRateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddServicesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            string cardNum = CreditBox.Text;
            string cardName = textBox3.Text;
            string exp = textBox1.Text;
            string cvv = textBox2.Text;

            Form5 form5 = new Form5(hotel, hotel.LoggedInGuest.GuestID);

            form5.Show();

            this.Close();



        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            fullPriceBox.Text = "R" + Convert.ToString(hotel.NewPrice.Total);
            depositBox.Text = "R" + Convert.ToString(hotel.NewPrice.Deposit);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
