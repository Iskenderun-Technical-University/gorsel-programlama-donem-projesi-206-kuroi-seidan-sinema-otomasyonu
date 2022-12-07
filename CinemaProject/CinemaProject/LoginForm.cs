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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static SnacksShop snacks = new SnacksShop();
        public static MainForm mainForm = new MainForm();
        public static MoviesList moviesList = new MoviesList();
        public static Ticket ticket = new Ticket();
        public static EditSnacksMenu editSnacks = new EditSnacksMenu();
        public static AddMovies addMovies = new AddMovies();
<<<<<<< HEAD
        public static MovieDetails movieDetails = new MovieDetails();
        public static ChooseSeat seat = new ChooseSeat();
=======
        public static ChooseSeat seat= new ChooseSeat();

        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\OneDrive\Masaüstü\gorsel-programlama-donem-projesi-206-kuroi-seidan-sinema-otomasyonu\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(Sqlcon);
>>>>>>> Salsabil

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            /*   string query = "select * from LoginTbl where UserName='"+guna2TextBox1.Text+"' and Password='"+guna2TextBox2.Text+"'";
                 sda = new SqlDataAdapter(query,con);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);
             if (dt.Rows.Count > 0)
             {
                 this.Hide();
                 mainForm.Show();
             }
             else
             {
                 MessageBox.Show("The User Name Or Password is Wrong, Please Check them and Try again!", "Invaild Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 guna2TextBox1.Clear(); guna2TextBox2.Clear(); guna2TextBox1.Focus();
             }*/
            this.Hide();
           mainForm.Show();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true) textBox1.UseSystemPasswordChar = false;
            else textBox1.UseSystemPasswordChar = true;
        }
    }
}
