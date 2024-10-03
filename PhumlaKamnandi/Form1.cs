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
    public partial class Form1 : Form
    {
        public Hotel hotel;
        public Form1()
        {
            this.hotel = new Hotel(1, 5);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(hotel);

            form6.ShowDialog();

        }

        private void makeBookingBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(hotel, this);

            form2.Show();

            this.Hide();
        }

        private void cancelBookingBtn_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void changeBookingBtn_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide(); 
        }

        private void enquireBtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(hotel);
            form5.Show();
            this.Hide(); 
        }
    }
}
