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
        SqlConnection con = new SqlConnection(LoginForm.sqlcon);
        SqlCommand cmd;

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            //DEĞŞİKLİKLERİ KEYDETMEK İÇİN
            string query = "";
            try
            {
                if (Category.SelectedIndex == -1) MessageBox.Show("Please Choose The Category First!");
                else
                {
                    if (AddRBtn.Checked == true || EditRBtn.Checked == true)
                    {
                        if (PName.Text == "" || PName.Text.Contains("  ") || PName.Text[0] == ' ') { MessageBox.Show("Please Add The Item Name Correctly!!"); PName.Clear(); PName.Focus(); }
                        else
                        {
                            if (Category.Text == "PopCorn" && PopCornSize.SelectedIndex == -1)
                            {
                                MessageBox.Show("Please Select A Size For The PopCorn!!");
                            }
                            else if (Category.Text == "Drinks" && (Size.Text.Contains(" ") || Size.Text == ""))
                            {
                                MessageBox.Show("Please Add The Size Correctly And Try Again!"); Size.Clear(); Size.Focus();
                            }
                            else if (price.Text == "") { MessageBox.Show("You Have To Add A Price.. Please Try Again!"); price.Focus(); }
                            else
                            {
                                if (AddRBtn.Checked)
                                {//MENÜYE EKLEMEK İÇİN
                                    if (Category.Text == "PopCorn") query = "insert into MENU (SnackName,Size,Category,Price) values ('" + PName.Text + "','" + PopCornSize.Text + "','" + Category.Text + "','" + price.Text + "')";
                                    else query = "insert into MENU (SnackName,Size,Category,Price) values ('" + PName.Text + "','" + Size.Text + "','" + Category.Text + "','" + price.Text + "')";
                                }
                                else if (EditRBtn.Checked && listBox3.SelectedIndex != -1)
                                {
                                   // MENÜYÜ DEĞŞTİRMEK İÇİN
                                    if (Category.Text == "PopCorn") query = "Update MENU Set SnackName='" + PName.Text + "', Size='" + PopCornSize.Text + "',Category='" + Category.Text + "',price='" + price.Text + "' where ID='" + listBox3.SelectedItem.ToString() + "'";
                                    else query = "Update MENU Set SnackName='" + PName.Text + "', Size='" + Size.Text + "',Category='" + Category.Text + "',price='" + price.Text + "' where ID='" + listBox3.SelectedItem.ToString() + "'";
                                }
                                else { MessageBox.Show("Please Choose The Item That You Want To Edit And Try Again!"); }
                                con.Open();
                                cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("The Data Added Successfully!");

                                con.Close();
                                ResetPage();
                            }
                        }
                    }
                    else if (AddRBtn.Checked == false && EditRBtn.Checked == false && DeleteRBtn.Checked == false) { MessageBox.Show("Please Choose The Desired Operation!!"); }
                    if (DeleteRBtn.Checked == true && listBox3.SelectedIndex!=-1)
                    {
                        if (MessageBox.Show("Are You Sure That You Want To Delete This Product?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            query = "delete from MENU where ID='" + listBox3.SelectedItem.ToString() + "'";
                            con.Open();
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("The Selected Data Deleted Successfully!");
                            ResetPage();
                        }
                    }
                    UpdateList("select SnackName,Size,Price,ID from MENU where Category='" + Category.Text + "'");
                }
            }
            catch { MessageBox.Show("There Is A Problem Occurred!! Please Try Again."); }
            finally { con.Close(); }
        }

        void ResetPage() {
            //Clean The The Page From The Entered Data
            PName.Clear(); Size.Clear(); price.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { //To Select Both the Lists with the this list
            listBox3.SelectedIndex = listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { //To Select Both the Lists with the this list
            listBox3.SelectedIndex = listBox1.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        { //To Select Both the Lists with the this list
            listBox2.SelectedIndex = listBox1.SelectedIndex = listBox3.SelectedIndex;
        }

        void ClearList() { 
            //To Clear The Data From The Lists
        listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear();
        listBox1.Items.Add("Item"); listBox2.Items.Add("Price"); listBox3.Items.Add("ID");
        }

        void UpdateList(string query) {
            //To Show The Another Categories In The List
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
            //ATIŞTIRMALIK TÜRÜNÜ SEÇMENİZ VE ARADINDAN İSTEDİĞNİZ İŞLMİ GEÇELEŞTİRMENİZİ SAĞLAR
            if (Category.Text == "PopCorn") { Size.Visible = false; PopCornSize.Visible = true; }
            else { Size.Visible = true; PopCornSize.Visible = false; }
            string query = "select SnackName,Size,Price,ID from MENU where Category='" + Category.Text + "'";
            UpdateList(query);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            //Back To Main Form And Clear All The Current Form
            ResetPage(); ClearList();
            Category.SelectedIndex = -1;
            this.Hide();
            LoginForm.mainForm.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //To Exit The App
            Application.Exit();
        }
    }
}
