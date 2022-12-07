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
        static string Sqlcon= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\OneDrive\Masaüstü\gorsel-programlama-donem-projesi-206-kuroi-seidan-sinema-otomasyonu\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlCommand cmd;
        int total=0;
        private void SnacksShop_Load(object sender, EventArgs e)
        {

        }

        void ClearMenu()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            ClearMenu();
            string query = "select Name,Price from SnackTbl where Category=Snacks";
            DataTable dt = new DataTable(query);
            listBox1.Items.Add("Items");listBox2.Items.Add("Price");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i][0]);
                listBox2.Items.Add(dt.Rows[i][1]);
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            ClearMenu();
            string query = "select Name,Price from SnackTbl where Category=Popcorn";
            DataTable dt = new DataTable(query);
            listBox1.Items.Add("Items"); listBox2.Items.Add("Price");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i][0]);
                listBox2.Items.Add(dt.Rows[i][1]);
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            ClearMenu();
            string query = "select Name,Price from SnackTbl where Category=Drinks";
            DataTable dt = new DataTable(query);
            listBox1.Items.Add("Items"); listBox2.Items.Add("Price");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i][0]);
                listBox2.Items.Add(dt.Rows[i][1]);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            total += Convert.ToInt32(listBox2.SelectedItem);
            listBox3.Items.Add(listBox1.SelectedItem.ToString());
            listBox4.Items.Add(listBox2.SelectedItem.ToString());
            label3.Text = total.ToString();
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
            int index = listBox4.SelectedIndex;
            total -=Convert.ToInt32(listBox4.SelectedItem);
            listBox4.Items.RemoveAt(index);
            listBox3.Items.RemoveAt(index);
            label3.Text= total.ToString();

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
    }
}
