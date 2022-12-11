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
    public partial class SnacksShop : Form
    {
        public SnacksShop()
        {
            InitializeComponent();
        }
        static string Sqlcon= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        //static string Sqlcon= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\OneDrive\Masaüstü\gorsel-programlama-donem-projesi-206-kuroi-seidan-sinema-otomasyonu\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlCommand cmd;
        static float total=0;

        void ClearList()
        {
            listBox1.Items.Clear(); listBox2.Items.Clear(); 
            listBox1.Items.Add("Item"); listBox2.Items.Add("Price"); 
        }

        void UpdateList(string query)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ClearList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i][0].ToString() + "\t" + dt.Rows[i][1].ToString()); listBox2.Items.Add(dt.Rows[i][2].ToString());
            }
            con.Close();
        }
        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            ClearList();
            string query = "select SnackName,Size,Price,ID from MENU where Category='"+"Snacks"+"'";
            UpdateList(query);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            ClearList();
            string query = "select SnackName,Size,Price,ID from MENU where Category='" + "PopCorn" + "'";
            UpdateList(query);
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            ClearList();
            string query = "select SnackName,Size,Price,ID from MENU where Category='" + "Drinks" + "'";
            UpdateList(query);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex= listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (total != 0)
            {
                int index = listBox4.SelectedIndex;
                total -= Convert.ToSingle(listBox4.Text);
                listBox4.Items.RemoveAt(index);
                listBox3.Items.RemoveAt(index);
                label7.Text = total.ToString();
            }
        }


        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.SelectedIndex = listBox3.SelectedIndex;

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.SelectedIndex = listBox4.SelectedIndex;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.mainForm.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            total += Convert.ToSingle(listBox2.Text);
            listBox3.Items.Add(listBox1.SelectedItem.ToString());
            listBox4.Items.Add(listBox2.SelectedItem.ToString());
            label7.Text = total.ToString();
        }
    }
}
