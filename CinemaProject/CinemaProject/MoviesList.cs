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
    public partial class MoviesList : Form
    {
        public MoviesList()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(LoginForm.sqlcon);
        public static int current = 0, prev = 0;

        private void MoviesList_Load(object sender, EventArgs e)
        {
            UpdateList("select MovieName,MoviePicture,ID from MoviesTbl order by MovieName ASC");
        }
         
        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));  
            }
        }

        public void UpdateList(string sqlquery)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (current >= 0 && dataTable.Rows.Count>current)
                {
                    ClearList();
                    prev = current-10;

                    MovieName1.Text = dataTable.Rows[current][0].ToString();
                    ID1.Text= dataTable.Rows[current][2].ToString();
                    byte[] img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic1.Image = GetImage(img);
                    
                    MovieName2.Text = dataTable.Rows[current][0].ToString();
                    ID2.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic2.Image = GetImage(img);

                    MovieName3.Text = dataTable.Rows[current][0].ToString();
                    ID3.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic3.Image = GetImage(img);

                    MovieName4.Text = dataTable.Rows[current][0].ToString();
                    ID4.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic4.Image = GetImage(img);

                    MovieName5.Text = dataTable.Rows[current][0].ToString();
                    ID5.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic5.Image = GetImage(img);

                    MovieName6.Text = dataTable.Rows[current][0].ToString();
                    ID6.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic6.Image = GetImage(img);

                    MovieName7.Text = dataTable.Rows[current][0].ToString();
                    ID7.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic7.Image = GetImage(img);

                    MovieName8.Text = dataTable.Rows[current][0].ToString();
                    ID8.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic8.Image = GetImage(img);

                    MovieName9.Text = dataTable.Rows[current][0].ToString();
                    ID9.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic9.Image = GetImage(img);

                    MovieName10.Text = dataTable.Rows[current][0].ToString();
                    ID10.Text = dataTable.Rows[current][2].ToString();
                    img = (byte[])(dataTable.Rows[current++][1]);
                    MoviePic10.Image = GetImage(img);
                }
                else { current = 10; }
                con.Close();
            }
            catch//(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            UpdateList("select MovieName,MoviePicture,ID from MoviesTbl order by MovieName ASC");
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            current = prev;
            UpdateList("select MovieName,MoviePicture,ID from MoviesTbl order by MovieName ASC");
        }

        void ShowMovieDetails(string sqlquery)
        {
            try
            {
                SearchBox.Visible = FilterBtn.Checked = false;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                LoginForm.movieDetails.IDtxt.Text= dataTable.Rows[0][0].ToString();
                LoginForm.movieDetails.movieNameTextBox.Text = dataTable.Rows[0][1].ToString();
                byte[] img = (byte[])(dataTable.Rows[0][2]);
                LoginForm.movieDetails.moviePicturePictureBox.Image = GetImage(img);
                LoginForm.movieDetails.Link.Text = dataTable.Rows[0][3].ToString();
                LoginForm.movieDetails.genresTextBox.Text = dataTable.Rows[0][4].ToString();
                LoginForm.movieDetails.iMDbRatingLabel1.Text = dataTable.Rows[0][5].ToString();
                LoginForm.movieDetails.lengthTextBox.Text = dataTable.Rows[0][6].ToString();
                LoginForm.movieDetails.ageRatingTextBox.Text = dataTable.Rows[0][7].ToString();
                LoginForm.movieDetails.showDaysTextBox.Text = dataTable.Rows[0][8].ToString();
                LoginForm.movieDetails.showHoursTextBox.Text = dataTable.Rows[0][9].ToString();
                LoginForm.movieDetails.releaseDateDateTimePicker.Value = Convert.ToDateTime(dataTable.Rows[0][10]);
                LoginForm.movieDetails.ShowDialog();
                con.Close();
            }
            catch { }
            finally { con.Close(); }
        }

        void ClearList()
        {
            ID1.Text = "";
            MovieName1.Text = "";
            MoviePic1.Image = null;

            ID2.Text = "";
            MovieName2.Text = "";
            MoviePic2.Image = null;

            ID3.Text = "";
            MovieName3.Text = "";
            MoviePic3.Image = null;
           
            ID4.Text = "";
            MovieName4.Text = "";
            MoviePic4.Image = null;

            ID5.Text = "";
            MovieName5.Text = "";
            MoviePic5.Image = null;

            ID6.Text = "";
            MovieName6.Text = "";
            MoviePic6.Image = null;

            ID7.Text = "";
            MovieName7.Text = "";
            MoviePic7.Image = null;

            ID8.Text = "";
            MovieName8.Text = "";
            MoviePic8.Image = null;

            ID9.Text = "";
            MovieName9.Text = "";
            MoviePic9.Image = null;

            ID10.Text = "";
            MovieName10.Text = "";
            MoviePic10.Image = null;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //FİLM ARAMAK İÇİN ID GÖRE YADA ADI GÖRE
            current = 0;
            if (guna2ToggleSwitch1.Checked == true)
            {
                string sqlquery = "select MovieName,MoviePicture,ID from MoviesTbl where Genres like '%" + guna2ComboBox1.Text + "%' order by MovieName ASC";
                UpdateList(sqlquery);
            }
            else
            {
                string sqlquery = "select MovieName,MoviePicture,ID from MoviesTbl where MovieName like '%" + guna2TextBox1.Text + "%' order by MovieName ASC";
                UpdateList(sqlquery);
                guna2TextBox1.Clear();
            }
        }

        private void MoviePic1_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID1.Text + "'";
            ShowMovieDetails(sqlquery);
            
        }

        private void MoviePic2_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID2.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void MoviePic3_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID3.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void MoviePic4_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID4.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void MoviePic5_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID5.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void MoviePic6_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID6.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void MoviePic7_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID7.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void MoviePic8_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID8.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void MoviePic9_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID9.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void MoviePic10_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from MoviesTbl where ID = '" + ID10.Text + "'";
            ShowMovieDetails(sqlquery);
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            SearchBox.Visible = FilterBtn.Checked;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ToggleSwitch1.Checked = true;
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            guna2ToggleSwitch1.Checked = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            current = 0;
            UpdateList("select MovieName,MoviePicture,ID from MoviesTbl order by MovieName ASC");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SearchBox.Visible = FilterBtn.Checked = false;
            this.Hide();
            LoginForm.mainForm.Show();
        }

        
    }
}