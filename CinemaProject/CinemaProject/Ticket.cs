using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CinemaProject
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        static int CostNum = 0;
        string gender;
        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlCommand cmd;
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            CostNum = Convert.ToInt32(StanderdTicket.Value + StudentTicket.Value + EliteTicket.Value + VIPTicket.Value);
            if (listBox1.Items.Count != CostNum)
            {
                MessageBox.Show("Please Add All The Costumer Data.");
            }
            else
            {
                this.Hide();
                LoginForm.seat.Show();
            }
        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.mainForm.Show();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) gender = "Male";
            else if (radioButton2.Checked) gender = "Female";
            string query = "insert into TempOrder (CustomerName,TicketType,PhoneNo,Gender) values ('" + CustName.Text + "','" + Type.Text + "','" + PhoneNo.Text + "','" + gender + "')";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            listBox1.Items.Add(CustName.Text);
            listBox2.Items.Add(Type.Text);
        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {
            string query = "delete from TempOrder where CustomerName = '"+listBox1.Text+"'";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            int index = Convert.ToInt32(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
        }
    }
}
