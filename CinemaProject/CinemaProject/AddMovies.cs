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
using System.IO
    ;
namespace CinemaProject
{
    public partial class AddMovies : Form
    {
        public AddMovies()
        {
            InitializeComponent();
        }
        static string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(sqlcon);
        SqlCommand cmd;
        string imgloc;
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgloc = dialog.FileName.ToString();
                 pictureBox1.ImageLocation = imgloc;
            }
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {
            imdbRate.Text = guna2RatingStar1.Value.ToString();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string hours = "", days = "", genres = "";
                for (int i = 0; i < DaysList.CheckedItems.Count; i++)
                {
                    days += DaysList.CheckedItems[i].ToString();
                    if (i + 1 != DaysList.CheckedItems.Count) days += ", ";
                }
                for (int i = 0; i < HoursList.CheckedItems.Count; i++)
                {
                    hours += HoursList.CheckedItems[i].ToString();
                    if (i + 1 != HoursList.CheckedItems.Count) hours += ", ";
                }
                for (int i = 0; i < GenresList.CheckedItems.Count; i++)
                {
                    genres += GenresList.CheckedItems[i].ToString();
                    if (i + 1 != GenresList.CheckedItems.Count) genres += ", ";
                }
                byte[] images = null;
                FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                string query = "insert into MoviesTbl (MovieName,MoviePicture,Description,Genres,IMDbRating,Length,AgeRating,ShowDays,ShowHours,ReleaseDate) values (@name,@pic,@desc,@genres,@rate,@length,@age,@days,@hours,@date)";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@name", MovieName.Text));
                cmd.Parameters.Add(new SqlParameter("@pic", images));
                cmd.Parameters.Add(new SqlParameter("@desc", Description.Text));
                cmd.Parameters.Add(new SqlParameter("@genres", genres));
                cmd.Parameters.Add(new SqlParameter("@rate", Convert.ToSingle(imdbRate.Text)));
                cmd.Parameters.Add(new SqlParameter("@length", Length.Text));
                cmd.Parameters.Add(new SqlParameter("@age", AgeRate.Text));
                cmd.Parameters.Add(new SqlParameter("@days", days));
                cmd.Parameters.Add(new SqlParameter("@hours", hours));
                cmd.Parameters.Add(new SqlParameter("@date", Date.Value));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successful!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.mainForm.Show();
        }
    }
}
