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
    public partial class EditSnacksMenu : Form
    {
        public EditSnacksMenu()
        {
            InitializeComponent();
        }
        static string SqlCon = @"";
        SqlConnection con = new SqlConnection(SqlCon);
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
            if (AddRBtn.Checked) {
                string query = "insert to MENU (SnackName,Size,Category,Price) values ('" + guna2TextBox1.Text + "','" + guna2TextBox3.Text + "','" + guna2ComboBox1.Text + "','" + guna2TextBox2.Text + "')";
                cmd=new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
            }
            else if(EditRBtn.Checked) { }
            else if(DeleteRBtn.Checked) {
                string query = "delete from MENU where ID='"+listBox3.SelectedItem.ToString()+"'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.SelectedIndex = listBox2.SelectedIndex = listBox1.SelectedIndex;
        }
    }
}
