using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       // static string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        static string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amalz\Desktop\gorsel-programlama-donem-projesi-206-kuroi-seidan-sinema-otomasyonu\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(sqlcon);
        SqlCommand cmd;

        public static SnacksShop snacks = new SnacksShop();
        public static MainForm mainForm = new MainForm();
        public static MoviesList moviesList = new MoviesList();
        public static Ticket ticket = new Ticket();
        public static EditSnacksMenu editSnacks = new EditSnacksMenu();
        public static AddMovies addMovies = new AddMovies();

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Boolean Login() {
            string query = "select * from Login where UserName='"+username.Text+"'and Password='"+password.Text+"'";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
            /*if (Login())
            {
                
            }
            else MessageBox.Show("the data is worng");*/
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
