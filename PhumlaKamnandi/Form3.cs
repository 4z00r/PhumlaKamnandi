﻿using PhumlaKamnandi.Business;
using PhumlaKamnandi.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private bool bLog = true;

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
            int ID = Convert.ToInt32(textBox7.Text);
            string name = textBox6.Text;

            bool foundGuest = hotel.CheckGuest(ID, name);

            if (foundGuest == false)
            {
                MessageBox.Show("No Guest found with these credentials. Please try again");
            }else
            {
                
                CancelButton.Enabled = false;
                CheckInButton.Enabled = false;
                label8.Enabled = false;
                button2.Enabled = true;

                MessageBox.Show("Login Successful!");

            }
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
            GuestController g = new GuestController();
            Collection<Guest> guests = g.AllGuests;
            if (!bLog)
            {
                hotel.LoggedInGuest = guests[guests.Count - 1];
            }
            DialogResult result = MessageBox.Show(
                "Do you want to continue and create this booking under GuestID: "+ hotel.LoggedInGuest.GuestID +"?",        
                "Confirmation",                    
                MessageBoxButtons.YesNo,           
                MessageBoxIcon.Question            
            );

            if (result == DialogResult.Yes)
            {
             
                hotel.AddBooking();
                BookingController b = new BookingController();
                Collection<Booking> bookings = b.AllBookings;
                MessageBox.Show("Reservation created with ID: " + bookings[bookings.Count-1].BookingID +"\nKindly ask Guest to take note of this number.");


                Form4 form4 = new Form4(hotel);

                form4.Show();

                this.Close();
            }
            else if (result == DialogResult.No)
            {
                form1.Show();

                this.Close();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string telepphone = textBox2.Text;
            string address = textBox1.Text;

            hotel.LoggedInGuest = hotel.AddGuest(name, telepphone, address);        

            CancelButton.Enabled = false;
            CheckInButton.Enabled = false;
            button1.Enabled = false;
            label8.Enabled = false;
            button2.Enabled = true; ;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (bLog)
            {

                textBox7.Enabled = false;
                textBox6.Enabled = false;
                CheckInButton.Enabled = false;

                textBox3.Enabled = true;
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                button1.Enabled = true;

                bLog = false;
            }
            else
            {
                textBox7.Enabled = false;
                textBox6.Enabled = false;
                CheckInButton.Enabled = false;

                textBox3.Enabled = true;
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                button1.Enabled = true;

                bLog = true;
            }
        }
        private void PopulateObject()
        {

        }
    }
}
