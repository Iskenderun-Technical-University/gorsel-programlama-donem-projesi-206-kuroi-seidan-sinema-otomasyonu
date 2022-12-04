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
        public static MovieDetails movieDetails = new MovieDetails();
        public static ChooseSeat seat = new ChooseSeat();

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
           this.Hide();
           mainForm.Show();
        }
    }
}
