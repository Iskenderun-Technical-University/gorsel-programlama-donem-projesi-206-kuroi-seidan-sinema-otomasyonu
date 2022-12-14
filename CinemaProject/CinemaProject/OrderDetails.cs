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
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }
        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlCommand cmd;

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            LoginForm.ticket.PhoneNo.Clear(); LoginForm.ticket.CustName.Clear();
            LoginForm.ticket.listBox1.Items.Clear(); LoginForm.ticket.listBox2.Items.Clear();
            ChooseSeat.selectedseats = 0; LoginForm.seat.listBox1.Items.Clear();
            LoginForm.seat.guna2ComboBox2.Text = "";




            string query = "delete from TempOrder where ID > 0";
            this.Hide();
            con.Open();
            LoginForm.mainForm.Show();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
