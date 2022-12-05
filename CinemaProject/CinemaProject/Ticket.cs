using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        static int CostNum = 0;
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.mainForm.Show();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Cost.Text);
            listBox2.Items.Add(Type.Text);

        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            CostNum = Convert.ToInt32(StanderdTicket.Value + StudentTicket.Value + EliteTicket.Value + VIPTicket.Value);
            if (listBox1.Items.Count != CostNum) {
                MessageBox.Show("Please Add All The Costumer Data.");
            }
            else
            {
                //this.Hide();
                //LoginForm.seat.Show();
            }
        }

        
    }
}
