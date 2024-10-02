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
    public partial class Form5 : Form
    {
        public Hotel hotel;
        public Form5(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
