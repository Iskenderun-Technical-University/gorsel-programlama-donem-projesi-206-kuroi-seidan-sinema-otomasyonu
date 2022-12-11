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
using System.Timers;
using Guna.UI2.WinForms;

namespace CinemaProject
{
    public partial class EditSnacksMenu : Form
    {
        public EditSnacksMenu()
        {
            InitializeComponent();
        }
        static string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        //static string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amalz\Desktop\gorsel-programlama-donem-projesi-206-kuroi-seidan-sinema-otomasyonu\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(sqlcon);
        SqlCommand cmd;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void EditSnacksMenu_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (AddRBtn.Checked) {
                string query = "insert into MENU (SnackName,Size,Category,Price) values ('" + PName.Text + "','" + Size.Text + "','" + Category.Text + "','" + price.Text + "')";
                cmd=new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Selected Data Added Successfully!");

            }
            else if(EditRBtn.Checked) {
                string query = "Update MENU Set SnackName='" + PName.Text + "', Size='" + Size.Text + "',Category='" + Category.Text + "',price='" + price.Text + "' where ID='"+listBox3.SelectedItem.ToString()+"'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Selected Data Updated Successfully!");

            }
            else if(DeleteRBtn.Checked) {
                string query = "delete from MENU where ID='"+listBox3.SelectedItem.ToString()+"'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Selected Data Deleted Successfully!");
            }
            con.Close();
            PName.Clear();Size.Clear();price.Clear(); PName.Focus();
            UpdateList("select SnackName,Size,Price,ID from MENU where Category='" + Category.Text + "'");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.SelectedIndex = listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.SelectedIndex = listBox1.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex = listBox3.SelectedIndex;
        }

        void ClearList() { 
        listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear();
        listBox1.Items.Add("Item"); listBox2.Items.Add("Price"); listBox3.Items.Add("ID");
        }

        void UpdateList(string query) {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt =new DataTable();
            sda.Fill(dt);
            ClearList();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i][0].ToString()+"\t"+dt.Rows[i][1].ToString()); listBox2.Items.Add(dt.Rows[i][2].ToString()); listBox3.Items.Add(dt.Rows[i][3].ToString());
            }
            con.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select SnackName,Size,Price,ID from MENU where Category='" + Category.Text + "'";
            UpdateList(query);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.mainForm.Show();
        }
    }
}
