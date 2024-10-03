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
        public Form1 form1;
        public Form2(Hotel hotel, Form1 form1)
        {
            this.hotel = hotel;

            this.form1 = form1;

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

            bool available = hotel.CheckAvailability(numOccupants, checkIn, checkOut);

            if (available)
            {
                ExitButton.Enabled = true;
            }
            else
            {
                ExitButton.Enabled = false;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            form1.Show();

            this.Close();  
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(hotel, form1);

            form3.Show();
            
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
