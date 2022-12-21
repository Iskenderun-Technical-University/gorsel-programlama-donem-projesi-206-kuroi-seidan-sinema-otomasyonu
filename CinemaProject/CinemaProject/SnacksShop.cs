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
        string type="";
        static bool Dcheck=false, Pcheck=false;
        int CustomerID;

        void UpdateList(string query)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }
        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            category.Text = "Snacks";
            string query = "select SnackName,Size,Price from MENU where Category='"+"Snacks"+"'";
            UpdateList(query);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            category.Text = "PopCorn";
            string query = "select SnackName,Size,Price  from MENU where Category='" + "PopCorn" + "'";
            UpdateList(query);
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            category.Text = "Drinks";
            string query = "select SnackName,Size,Price from MENU where Category='" + "Drinks" + "'";
            UpdateList(query);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Text == "Discounted PopCorn") Pcheck = false;
                else if (listBox1.Text == "Discounted Drink") { Dcheck = false; }
                if (total >= 0)
                {
                    int index = listBox4.SelectedIndex;
                    total -= Convert.ToSingle(listBox4.Text);
                    listBox4.Items.RemoveAt(index);
                    listBox3.Items.RemoveAt(index);
                    listBox1.Items.RemoveAt(index);
                    label7.Text = total.ToString();
                }
            }
            catch { }
        }


        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.SelectedIndex =listBox1.SelectedIndex= listBox3.SelectedIndex;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.SelectedIndex =listBox1.SelectedIndex= listBox4.SelectedIndex;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPage();
            LoginForm.mainForm.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if (type == "VIP Ticket")
            {
                if (category.Text == "PopCorn" && guna2DataGridView1.CurrentRow.Cells[1].Value.ToString()=="Large" && Pcheck==false)
                {
                    listBox4.Items.Add("0.0000");
                    listBox1.Items.Add("Discounted PopCorn");
                    Pcheck = true;
                }
                else if (category.Text == "Drinks" && Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[2].Value) >= 10 && Dcheck==false)
                {
                    listBox1.Items.Add("Discounted Drink");
                    listBox4.Items.Add((Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[2].Value) - 10).ToString()+".0000");
                    total += Convert.ToSingle(guna2DataGridView1.CurrentRow.Cells[2].Value) - 10;
                    Dcheck = true;
                }
                else
                {
                    listBox1.Items.Add("Standard");
                    total += Convert.ToSingle(guna2DataGridView1.CurrentRow.Cells[2].Value);
                    listBox4.Items.Add(guna2DataGridView1.CurrentRow.Cells[2].Value.ToString());
                }
            }
            else if (type == "Elite Ticket") 
            {
                if (category.Text == "PopCorn" && guna2DataGridView1.CurrentRow.Cells[1].Value.ToString() == "Medium" && Pcheck == false)
                {
                    listBox4.Items.Add("0.0000");
                    listBox1.Items.Add("Discounted PopCorn");
                    Pcheck = true;
                }
                else
                {
                    listBox1.Items.Add("Standard");
                    total += Convert.ToSingle(guna2DataGridView1.CurrentRow.Cells[2].Value);
                    listBox4.Items.Add(guna2DataGridView1.CurrentRow.Cells[2].Value.ToString());
                }
            }
            else 
            {
                listBox1.Items.Add("Standard");
                total += Convert.ToSingle(guna2DataGridView1.CurrentRow.Cells[2].Value);
                listBox4.Items.Add(guna2DataGridView1.CurrentRow.Cells[2].Value.ToString());
            }

            listBox3.Items.Add(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()+"  \t"+ guna2DataGridView1.CurrentRow.Cells[1].Value.ToString());
            label7.Text = total.ToString();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (guna2RadioButton4.Checked) temp = "Credit Card";
            else if (guna2RadioButton3.Checked) temp = "Cash";
            
            string query1 = "insert into CanteenOrders values ('"+CustomerID+"','"+label7.Text+"','"+temp+"','"+DateTime.Now.ToString("MM/dd/yyyy hh:mm")+"')";
            string check = "select * from TicketOrders where ID='"+CustomerID+"'";
            con.Open();
            cmd=new SqlCommand(check,con);
            if (cmd.ExecuteScalar() != null && (guna2RadioButton3.Checked == true || guna2RadioButton4.Checked == true) && listBox1.Items.Count!=0)
            {
                cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                string query2 = "SELECT IDENT_CURRENT('CanteenOrders')";
                cmd = new SqlCommand(query2, con);
                temp = cmd.ExecuteScalar().ToString();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string query3 = "insert into CanteenOrderDetails (OrderID,SnackName,Price) values ('" + temp + "','" + listBox3.Items[i].ToString() + "','" + listBox4.Items[i].ToString() + "')";
                    cmd = new SqlCommand(query3, con);
                    cmd.ExecuteNonQuery();
                }
                ResetPage();
                MessageBox.Show("Thanks For Your Purchese!! Enjoy The Movie.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (guna2RadioButton3.Checked == false && guna2RadioButton4.Checked == false) { MessageBox.Show("Please Choose A Payment Method And Try Again!!", "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if(listBox1.Items.Count == 0) MessageBox.Show("Please Add Something To Your Order And Try Again!!", "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else { MessageBox.Show("The Entered Ticket Number Is Wrong!! Please Check It And Try Again!!", "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); TicketNo.Clear(); TicketNo.Focus(); }

            con.Close(); 
        }

        void ResetPage() {
            listBox1.Items.Clear(); listBox3.Items.Clear(); listBox4.Items.Clear(); TicketNo.Clear();
            label7.Text = "0"; CheckStatus.Visible = false; CustomerID = 0;

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TicketNo.Text.Contains(' ') || TicketNo.Text.Length == 0) {
                    MessageBox.Show("You Can't Make Spaces In The Ticket Number!! Please Try Again"); TicketNo.Clear(); TicketNo.Focus();
                }
                else
                {
                    if (MessageBox.Show("Are You Sure That You Want To Change The Ticket Number? That's Will Reset The Order List!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        listBox1.Items.Clear(); listBox3.Items.Clear(); listBox4.Items.Clear(); label7.Text = "0";
                        total = 0; Pcheck = false; Dcheck = false;
                        string query = "select TicketType from TicketOrders where ID='" + TicketNo.Text + "'";
                        con.Open();
                        cmd = new SqlCommand(query, con);

                        if (cmd.ExecuteScalar() != null) { type = cmd.ExecuteScalar().ToString(); CustomerID = Convert.ToInt32(TicketNo.Text); }
                        else { type = ""; }

                        string query1 = "select * from CanteenOrders where CustomerID='" + CustomerID + "'";
                        cmd = new SqlCommand(query1, con);
                        if (cmd.ExecuteScalar() != null) { type = "Standard Ticket"; }

                        con.Close();
                        CheckStatus.Visible = true;
                        if (type == "VIP Ticket" || type == "Elite Ticket" || type == "Student Ticket" || type == "Standard Ticket")
                        { CheckStatus.Text = "Your Ticket Type Is '" + type + "', Enjoy With Our Discounts!"; CheckStatus.ForeColor = Color.Green;}
                        else {CheckStatus.Text = "The Entered Ticket Number Is Not Valid!! Please Try Again"; CheckStatus.ForeColor = Color.Red;}
                    }
                }
            }
            catch { }
        }
    }
}
