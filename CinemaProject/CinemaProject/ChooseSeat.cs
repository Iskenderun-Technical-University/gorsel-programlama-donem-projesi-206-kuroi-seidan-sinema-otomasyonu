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
        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        //static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\OneDrive\Masaüstü\gorsel-programlama-donem-projesi-206-kuroi-seidan-sinema-otomasyonu\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlDataAdapter sda;
        SqlCommand cmd;
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

        private void E7_Click(object sender, EventArgs e) { Seats(E7);}

        private void E8_Click(object sender, EventArgs e) { Seats(E8);}

        private void E9_Click(object sender, EventArgs e) { Seats(E9);}

        private void E10_Click(object sender, EventArgs e) { Seats(E10);}

        private void E11_Click(object sender, EventArgs e) { Seats(E11);}

        private void E12_Click(object sender, EventArgs e) { Seats(E12);}

        private void D7_Click(object sender, EventArgs e) { Seats(D7); }

        private void D8_Click(object sender, EventArgs e) { Seats(D8); }

        private void D9_Click(object sender, EventArgs e) { Seats(D9); }

        private void D10_Click(object sender, EventArgs e) { Seats(D10); }

        private void D11_Click(object sender, EventArgs e) { Seats(D11); }

        private void D12_Click(object sender, EventArgs e) { Seats(D12); }

        private void C7_Click(object sender, EventArgs e) { Seats(C7); }

        private void C8_Click(object sender, EventArgs e) { Seats(C8); }

        private void C9_Click(object sender, EventArgs e) { Seats(C9); }

        private void C10_Click(object sender, EventArgs e) { Seats(C10); }

        private void C11_Click(object sender, EventArgs e) { Seats(C11); }

        private void C12_Click(object sender, EventArgs e) { Seats(C12); }

        private void B7_Click(object sender, EventArgs e) { Seats(B7); }

        private void B8_Click(object sender, EventArgs e) { Seats(B8); }

        private void B9_Click(object sender, EventArgs e) { Seats(B9); }

        private void B10_Click(object sender, EventArgs e) { Seats(B10); }

        private void B11_Click(object sender, EventArgs e) { Seats(B11); }

        private void B12_Click(object sender, EventArgs e) { Seats(B12); }

        private void A7_Click(object sender, EventArgs e) { Seats(A7); }

        private void A8_Click(object sender, EventArgs e) { Seats(A8); }

        private void A9_Click(object sender, EventArgs e) { Seats(A9); }

        private void A10_Click(object sender, EventArgs e) { Seats(A10); }

        private void A11_Click(object sender, EventArgs e) { Seats(A11); }

        private void A12_Click(object sender, EventArgs e) { Seats(A12); }
        private void ChooseSeat_Load(object sender, EventArgs e)
        {
            /*string query = "select MovieName from MoviesTbl where ShowDays like'%"+DateTime.Now.ToString("dddd")+"%'";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
                            guna2ComboBox2.Items.Clear();

            sda.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                guna2ComboBox2.Items.Add(dt.Rows[i][0].ToString());
            }*/
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
            con.Close();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.ticket.Show();
        }

       
    }
}
