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
    public partial class Form3 : Form
    {
        public Hotel hotel;

        private Form1 form1;

        public Form3(Hotel hotel, Form1 form1)
        {
            this.hotel = hotel;

            this.form1 = form1;
       
            InitializeComponent();
        }

        private void NameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AuthorisationDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SignatureBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void RoomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckInBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckOutBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            form1.Show();

            // method that clears Hotel variables for restart!!! (on all forms cancels)

            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
