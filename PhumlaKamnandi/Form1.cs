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
            
        }

        private void makeBookingBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(hotel);

            form2.Show();

            this.Hide();
        }
    }
}
