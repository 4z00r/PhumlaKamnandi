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
    public partial class Form2 : Form
    {
        public Hotel hotel;
        public Form2(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreditBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeasonBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckInDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckOutDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Above5Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Below5Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepositBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            int numOccupants = Convert.ToInt32(numBox.Text);
            DateTime checkIn = CheckInDate.Value;
            DateTime checkOut = CheckOutDate.Value;

            MessageBox.Show(hotel.CheckAvailability(numOccupants, checkIn, checkOut).ToString());

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
