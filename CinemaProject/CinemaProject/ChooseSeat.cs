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
    public partial class ChooseSeat : Form
    {
        public ChooseSeat()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(Sqlcon);

=======
        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\OneDrive\Masaüstü\gorsel-programlama-donem-projesi-206-kuroi-seidan-sinema-otomasyonu\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlDataAdapter sda;
        SqlCommand cmd;
>>>>>>> Salsabil
        void Seats(Guna.UI2.WinForms.Guna2ImageButton x)
        {
           if (x.Image != x.PressedState.Image) x.Image = x.PressedState.Image;
            else x.Image = x.CheckedState.Image;
        }

        private void E1_Click(object sender, EventArgs e) {Seats(E1);}

        private void E2_Click(object sender, EventArgs e) {Seats(E2);}

        private void E3_Click(object sender, EventArgs e) {Seats(E3);}

        private void E4_Click(object sender, EventArgs e) {Seats(E4);}

        private void E5_Click(object sender, EventArgs e) {Seats(E5);}

        private void E6_Click(object sender, EventArgs e) {Seats(E6);}

        private void D1_Click(object sender, EventArgs e) {Seats(D1);}

        private void D2_Click(object sender, EventArgs e) {Seats(D2);}

        private void D3_Click(object sender, EventArgs e) {Seats(D3);}

        private void D4_Click(object sender, EventArgs e) {Seats(D4);}

        private void D5_Click(object sender, EventArgs e) {Seats(D5);}

        private void D6_Click(object sender, EventArgs e) {Seats(D6);}

        private void C1_Click(object sender, EventArgs e) {Seats(C1);}

        private void C2_Click(object sender, EventArgs e) {Seats(C2);}

        private void C3_Click(object sender, EventArgs e) {Seats(C3);}

        private void C4_Click(object sender, EventArgs e) {Seats(C4);}

        private void C5_Click(object sender, EventArgs e) {Seats(C5);}

        private void C6_Click(object sender, EventArgs e) {Seats(C6);}

        private void B1_Click(object sender, EventArgs e) {Seats(B1);}

        private void B2_Click(object sender, EventArgs e) {Seats(B2);}

        private void B3_Click(object sender, EventArgs e) {Seats(B3);}

        private void B4_Click(object sender, EventArgs e) {Seats(B4);}

        private void B5_Click(object sender, EventArgs e) {Seats(B5);}

        private void B6_Click(object sender, EventArgs e) {Seats(B6);}

        private void A1_Click(object sender, EventArgs e) {Seats(A1);}

        private void A2_Click(object sender, EventArgs e) {Seats(A2);}

        private void A3_Click(object sender, EventArgs e) {Seats(A3);}

        private void A4_Click(object sender, EventArgs e) {Seats(A4);}

        private void A5_Click(object sender, EventArgs e) {Seats(A5);}

        private void A6_Click(object sender, EventArgs e) {Seats(A6);}

        private void ChooseSeat_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string query = "select MovieName from MoviesTbl where ShowDays like'%"+DateTime.Now.ToString("dddd")+"%'";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                guna2ComboBox2.Items.Add(dt.Rows[i][0].ToString());
            }
=======
            string query = "select MovieName from MoviesTbl where ShowDays Like '%"+DateTime.Now.ToString("dddd")+"%'";
            con.Open();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(query,con);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                guna2ComboBox2.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    guna2ComboBox2.Items.Add(dt.Rows[i][0]);
                }
            }
            else MessageBox.Show("No Data Found");
>>>>>>> Salsabil
            con.Close();
        }
    }
}
