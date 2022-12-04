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
    public partial class MovieDetails : Form
    {
        public MovieDetails()
        {
            InitializeComponent();
        }
        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        string imgloc;
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlCommand cmd;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void iMDbRatingLabel1_TextChanged(object sender, EventArgs e)
        {
            guna2RatingStar1.Value = Convert.ToSingle(iMDbRatingLabel1.Text);
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch2.Checked == true)
            {
                movieNameTextBox.ReadOnly = false; guna2RatingStar1.ReadOnly = false;
                lengthTextBox.ReadOnly = false; ageRatingTextBox.ReadOnly = false;
                showDaysTextBox.ReadOnly = false; showHoursTextBox.ReadOnly = false;
                genresTextBox.ReadOnly = false; releaseDateDateTimePicker.Enabled = true;
                descriptionRichTextBox.ReadOnly = false; uploadImgBtn.Visible = true;
                SaveBtn.Visible = true; DeleteBtn.Visible = true;
            }
            else
            {
                movieNameTextBox.ReadOnly = true; guna2RatingStar1.ReadOnly = true;
                lengthTextBox.ReadOnly = true; ageRatingTextBox.ReadOnly = true;
                showDaysTextBox.ReadOnly = true; showHoursTextBox.ReadOnly = true;
                genresTextBox.ReadOnly = true; releaseDateDateTimePicker.Enabled = false;
                descriptionRichTextBox.ReadOnly = true; uploadImgBtn.Visible = false;
                SaveBtn.Visible = false; DeleteBtn.Visible = false;
            }
        }

        private void uploadImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgloc = dialog.FileName.ToString();
                moviePicturePictureBox.ImageLocation = imgloc;
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure That You Want To Delete This Movie?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MoviesList.current = 0;
                con.Open();
                string query="delete from MoviesTbl where ID='"+IDtxt.Text+"'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                LoginForm.moviesList.UpdateList("select MovieName,MoviePicture,ID from MoviesTbl");
            }
        }
    }
}
