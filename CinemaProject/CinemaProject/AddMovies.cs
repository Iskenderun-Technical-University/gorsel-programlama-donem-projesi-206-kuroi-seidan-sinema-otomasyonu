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
    public partial class AddMovies : Form
    {
        public AddMovies()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(LoginForm.sqlcon);
        SqlCommand cmd;
        string imgloc="";



        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //To Upload The Picture
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgloc = dialog.FileName.ToString();
                 pictureBox1.ImageLocation = imgloc;
            }
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {
            //To Show The Rating in The Label
            imdbRate.Text = guna2RatingStar1.Value.ToString();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            //FİLMİ EKLEMEK İÇİN

            try
            {
                string hours = "", days = "", genres = ""; byte[] images = null;

                if (imgloc == "") { MessageBox.Show("Please Upload The Movie Picture"); }
                else
                {
                    FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                }

                if (MovieName.Text.Length == 0 || MovieName.Text.Contains("  ") || MovieName.Text[0].ToString() == " ") { MessageBox.Show("Please Write A Correct Movie Name!!"); MovieName.Clear(); MovieName.Focus(); }
                else if (AgeRate.Text.Length == 0 || AgeRate.Text.Contains("  ") || AgeRate.Text[0].ToString() == " ") { MessageBox.Show("Please Write A Correct Age Rate!!"); AgeRate.Clear(); AgeRate.Focus(); }
                else if (Length.Text.Length == 0 || Length.Text.Contains("  ") || Length.Text[0].ToString() == " ") { MessageBox.Show("Please Write A Correct Movie Length!!"); Length.Clear(); Length.Focus(); }
                else if (GenresList.CheckedItems.Count == 0) { MessageBox.Show("Please Add At Least One Genre For The Movie!!"); }
                else
                {
                    for (int i = 0; i < DaysList.CheckedItems.Count; i++)
                    {
                        days += DaysList.CheckedItems[i].ToString();
                        if (i + 1 != DaysList.CheckedItems.Count) days += ",";
                    }
                    for (int i = 0; i < HoursList.CheckedItems.Count; i++)
                    {
                        hours += HoursList.CheckedItems[i].ToString();
                        if (i + 1 != HoursList.CheckedItems.Count) hours += ",";
                    }
                    for (int i = 0; i < GenresList.CheckedItems.Count; i++)
                    {
                        genres += GenresList.CheckedItems[i].ToString();
                        if (i + 1 != GenresList.CheckedItems.Count) genres += ",";
                    }
                    string query = "insert into MoviesTbl (MovieName,MoviePicture,Description,Genres,IMDbRating,Length,AgeRating,ShowDays,ShowHours,ReleaseDate) values (@name,@pic,@desc,@genres,@rate,@length,@age,@days,@hours,@date)";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@name", MovieName.Text));
                    cmd.Parameters.Add(new SqlParameter("@pic", images));
                    cmd.Parameters.Add(new SqlParameter("@desc", Link.Text));
                    cmd.Parameters.Add(new SqlParameter("@genres", genres));
                    cmd.Parameters.Add(new SqlParameter("@rate", Convert.ToSingle(imdbRate.Text)));
                    cmd.Parameters.Add(new SqlParameter("@length", Length.Text));
                    cmd.Parameters.Add(new SqlParameter("@age", AgeRate.Text));
                    cmd.Parameters.Add(new SqlParameter("@days", days));
                    cmd.Parameters.Add(new SqlParameter("@hours", hours));
                    cmd.Parameters.Add(new SqlParameter("@date", Date.Value));
                    cmd.ExecuteNonQuery(); ResetPage(); con.Close();
                    MessageBox.Show("Successful!!");
                }
            }
            catch(Exception ex){ MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }

        void ResetPage() {
            //To Clean The Form From the Data
            MovieName.Clear(); Link.Clear(); AgeRate.Clear(); Length.Clear(); guna2RatingStar1.Value = 0; imgloc = ""; pictureBox1.Image = null;
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            //To Get Back To The Main Form
            ResetPage();
            this.Hide();
            LoginForm.mainForm.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            // To Leave From The Whole App
            Application.Exit();
        }

    }
}
