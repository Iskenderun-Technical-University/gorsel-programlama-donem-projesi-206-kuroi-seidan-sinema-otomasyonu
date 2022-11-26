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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.moviesList.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.snacks.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.ticket.Show();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.editSnacks.Show();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.addMovies.Show();
        }
    }
}
