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
        public static int CustNo = 0,price;
        string gender;
        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlCommand cmd;
        SqlDataAdapter sda;
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            CustNo = listBox1.Items.Count ;
            if (CustNo == 0) MessageBox.Show("Please Add At Least One Customer And Try Again!!");
            else
            {
                string query = "select CustomerName from TempOrder where SeatNo is Null";
                con.Open();
                sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LoginForm.seat.guna2ComboBox1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoginForm.seat.guna2ComboBox1.Items.Add(dt.Rows[i][0].ToString());
                }
                con.Close();
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

            if (Type.Text == "Standard Ticket") price = 35;
            else if (Type.Text == "Student Ticket") price = 26;
            else if (Type.Text == "Elite Ticket") price = 45;
            else if (Type.Text == "VIP Ticket") price = 60;

            string query = "insert into TempOrder (CustomerName,TicketType,PhoneNo,Gender,Price) values ('" + CustName.Text + "','" + Type.Text + "','" + PhoneNo.Text + "','" + gender + "','"+price+"')";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            listBox1.Items.Add(CustName.Text);
            listBox2.Items.Add(Type.Text);
            CustName.Clear();PhoneNo.Clear();
        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from TempOrder where CustomerName = '" + listBox1.Text + "'";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                int index = Convert.ToInt32(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);
            }
            catch { }
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
