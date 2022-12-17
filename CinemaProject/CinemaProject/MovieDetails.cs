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
using System.IO;

namespace CinemaProject
{
    public partial class MovieDetails : Form
    {
        public MovieDetails()
        {
            InitializeComponent();
        }
        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        public string MoreDetails;
        string imgloc; bool PicCheck = false;
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlCommand cmd;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            PicCheck = false;
            guna2ToggleSwitch2.Checked = false;
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
                Link.Visible = true; uploadImgBtn.Visible = true;
                SaveBtn.Visible = true; DeleteBtn.Visible = true;
                guna2RatingStar1.ReadOnly = false; linkLabel1.Visible = false;
            }
            else
            {
                movieNameTextBox.ReadOnly = true; guna2RatingStar1.ReadOnly = true;
                lengthTextBox.ReadOnly = true; ageRatingTextBox.ReadOnly = true;
                showDaysTextBox.ReadOnly = true; showHoursTextBox.ReadOnly = true;
                genresTextBox.ReadOnly = true; releaseDateDateTimePicker.Enabled = false;
                Link.Visible = false; uploadImgBtn.Visible = false;
                SaveBtn.Visible = false; DeleteBtn.Visible = false;
                guna2RatingStar1.ReadOnly = true; linkLabel1.Visible = true;

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
                PicCheck = true;
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query= ""; byte[] images = null;
                con.Open();
                if (PicCheck == false)
                {
                    query = "update MoviesTbl set MovieName=@name, Description=@desc, Genres=@genres, IMDbRating=@rate, Length=@length, AgeRating=@age, ShowDays=@days, ShowHours=@hours,ReleaseDate=@date where ID='" + IDtxt.Text + "'";
                    cmd = new SqlCommand(query, con);

                }
                else if (PicCheck == true)
                {
                    query = "update MoviesTbl set MovieName=@name,MoviePicture=@img, Description=@desc, Genres=@genres, IMDbRating=@rate, Length=@length, AgeRating=@age, ShowDays=@days, ShowHours=@hours,ReleaseDate=@date where ID='" + IDtxt.Text + "'";

                    FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@img",images));
                    PicCheck = false;
                }
                 
                cmd.Parameters.Add(new SqlParameter("@name", movieNameTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@desc", Link.Text));
                cmd.Parameters.Add(new SqlParameter("@genres", genresTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@rate", Convert.ToSingle(iMDbRatingLabel1.Text)));
                cmd.Parameters.Add(new SqlParameter("@length", lengthTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@age", ageRatingTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@days", showDaysTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@hours", showHoursTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@date", releaseDateDateTimePicker.Value));
                cmd.ExecuteNonQuery(); con.Close();
                guna2ToggleSwitch2.Checked = false;
                MessageBox.Show("Successful!!");
            }
            catch { con.Close(); }
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
            }
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {
            iMDbRatingLabel1.Text = guna2RatingStar1.Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Link.Text.Contains("http")|| Link.Text.Contains("www.")||Link.Text.Contains(".com")|| Link.Text.Contains(".net"))
            {
                System.Diagnostics.Process.Start(Link.Text);
                PicCheck = false;
                this.Hide();
            }
            else MessageBox.Show("Sorry, There Is No Link Or The Link Is Wrong.");
        }
    }
}
