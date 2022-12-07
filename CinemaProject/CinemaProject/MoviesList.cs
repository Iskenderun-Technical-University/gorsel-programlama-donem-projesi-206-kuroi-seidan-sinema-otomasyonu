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

        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\OneDrive\Masaüstü\gorsel-programlama-donem-projesi-206-kuroi-seidan-sinema-otomasyonu\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(Sqlcon);
        static int current = 0;

        private void MoviesList_Load(object sender, EventArgs e)
        {
            UpdateList("select MovieName,MoviePicture from MoviesTbl");
        }

        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }

        void UpdateList(string sqlquery)
        {
            try
            {
                ClearList();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                MovieName1.Text = dataTable.Rows[current][0].ToString();
                byte[] img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic1.Image = GetImage(img);

                MovieName2.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic2.Image = GetImage(img);

                MovieName3.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic3.Image = GetImage(img);

                MovieName4.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic4.Image = GetImage(img);

                MovieName5.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic5.Image = GetImage(img);

                MovieName6.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic6.Image = GetImage(img);

                MovieName7.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic7.Image = GetImage(img);

                MovieName8.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic8.Image = GetImage(img);

                MovieName9.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic9.Image = GetImage(img);

                MovieName10.Text = dataTable.Rows[current][0].ToString();
                img = (byte[])(dataTable.Rows[current++][1]);
                MoviePic10.Image = GetImage(img);

                con.Close();
            }
            catch//(Exception ex)
            {
                // MessageBox.Show(ex.Message);
                con.Close();
            }

            void ClearList()
            {
                MovieName1.Text = "";
                MoviePic1.Image = null;

                MovieName2.Text = "";
                MoviePic2.Image = null;

                MovieName3.Text = "";
                MoviePic3.Image = null;

                MovieName4.Text = "";
                MoviePic4.Image = null;

                MovieName5.Text = "";
                MoviePic5.Image = null;

                MovieName6.Text = "";
                MoviePic6.Image = null;

                MovieName7.Text = "";
                MoviePic7.Image = null;

                MovieName8.Text = "";
                MoviePic8.Image = null;

                MovieName9.Text = "";
                MoviePic9.Image = null;

                MovieName10.Text = "";
                MoviePic10.Image = null;
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            current = 0;
            string sqlquery = "select MovieName,MoviePicture from MoviesTbl where Genres like '%" + guna2ComboBox1.Text + "%'";
            UpdateList(sqlquery);
        }
    }
}
