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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        int sum = 0;
        static string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(sqlcon);
        SqlDataAdapter sda;
        SqlCommand cmd;

        private void AdminPage_Load(object sender, EventArgs e)
        {
            int TotalIncome=0, TotalOrders=0;
            string query1 = "select count(*),sum(TotalPrice) from CanteenOrders";
            string query2 = "select count(*),sum(Price) from TicketOrders";
            con.Open();
            sda = new SqlDataAdapter(query1,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0) {
                OrderCountlbl.Text= dt.Rows[0][0].ToString();
                CanteenIncomelbl.Text = dt.Rows[0][1].ToString();
                TotalIncome += Convert.ToInt32(dt.Rows[0][1]);
                TotalOrders += Convert.ToInt32(dt.Rows[0][0]);
            }
            sda = new SqlDataAdapter(query2, con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TicktCountlbl.Text = dt.Rows[0][0].ToString();
                MovieIncomelbl.Text = dt.Rows[0][1].ToString();
                TotalIncome += Convert.ToInt32(dt.Rows[0][1]);
                TotalOrders += Convert.ToInt32(dt.Rows[0][0]);
            }
            TotalOrderslbl.Text = "There Is "+TotalOrders.ToString()+" Order Has Been Made So Far!!";
            TotalIncomelbl.Text = TotalIncome.ToString();
            con.Close();
            Createcaptcha();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "select CustomerName,TicketType,MovieName,SeatNo,Date,ShowTime from TicketOrders where ";
            if (TicketComboBox.Text== "By ID") { query += "ID='" + TicketSearch.Text + "'"; }
            else if (TicketComboBox.Text == "By Name") { query += "CustomerName like '%"+TicketSearch.Text+"%'"; }
            con.Open();
            sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Tresultlbl.Text = "There Is "+dt.Rows.Count.ToString()+" Result.";
            TicketDGV.DataSource = dt;
            con.Close();
            TicketSearch.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (OrderComboBox.Text == "By Customer ID") {
                string query = "select ID,CustomerID AS 'Customer ID',TotalPrice AS 'Total Price',PurchaseDate AS 'Purchase Date',Payment from CanteenOrders where CustomerID='"+OrderSearch.Text+"'";
                con.Open();
                sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Oresultlbl.Text = "There Is " + dt.Rows.Count.ToString() + " Result.";
                OrderDGV.DataSource = dt;
                con.Close();
                label9.Visible = false;
                OrderSearch.Clear();
            }
        }

        private void OrderDGV_Click(object sender, EventArgs e)
        {
            if(OrderDGV.Rows.Count>0)label7.Text = OrderDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (OrderDGV.Rows.Count > 0 && label7.Text != "")
            {
                string query = "select ID,SnackName AS 'Snack Name',Price from CanteenOrderDetails where OrderID='"+label7.Text+"'";
                string type = "select TicketType from TicketOrders where ID='"+OrderDGV.CurrentRow.Cells[1].Value.ToString()+"'";
                con.Open();
                sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Oresultlbl.Text = "There Is " + dt.Rows.Count.ToString() + " Result.";
                OrderDGV.DataSource = dt;
                cmd = new SqlCommand(type,con);
                label9.Text = "The Ticket Type Of The Order Is : "+cmd.ExecuteScalar().ToString();
                label9.Visible = true;
                con.Close();
            }
            else MessageBox.Show("Please Select An Order To Show The Details") ;
        }
        void Createcaptcha()
        {
            Random r = new Random();
            int temp1 = r.Next(0, 49);
            int temp2 = r.Next(0, 50);
            sum = temp1 + temp2;
            label19.Text = temp1.ToString() + "+" + temp2.ToString();
        }

        Boolean Checkcaptcha()
        {
            if (TextBox4.Text == sum.ToString()) return true;
            else return false;
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            if (Checkcaptcha())
            {
                if (guna2TextBox1.Text == "" || guna2TextBox1.Text[0].ToString() == " " || guna2TextBox1.Text.Contains("  "))
                {
                    MessageBox.Show("Please Use A Valid Name!!"); guna2TextBox1.Clear(); guna2TextBox1.Focus();
                    Createcaptcha(); TextBox4.Clear();
                }
                else if (guna2TextBox2.Text == guna2TextBox3.Text && guna2TextBox2.Text.Length>5)
                {
                    if (guna2TextBox2.Text.Contains(" "))
                    {
                        MessageBox.Show("You Can't Use Spaces In The Password, Please Try Again !!!");
                        guna2TextBox2.Clear(); guna2TextBox3.Clear(); guna2TextBox2.Focus(); Createcaptcha(); TextBox4.Clear();
                    }
                    else {
                        string query = "insert into Login values ('"+guna2TextBox1.Text+"','"+guna2TextBox2.Text+"')";
                        con.Open();
                        cmd = new SqlCommand(query,con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("The Worker Added Successfully!!","Confirmation!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        guna2TextBox1.Clear();guna2TextBox2.Clear(); guna2TextBox3.Clear(); TextBox4.Clear(); Createcaptcha();
                    }
                }
                else { 
                    MessageBox.Show("The Password Is Not The Same,Or Less Than 5 Characters. Please Check It And Try Again!!");
                    guna2TextBox2.Clear(); guna2TextBox3.Clear(); guna2TextBox2.Focus(); Createcaptcha(); TextBox4.Clear();
                }
            }
            else { MessageBox.Show("The Captcha Code Is Wrong, Try Again!!");Createcaptcha(); TextBox4.Clear(); TextBox4.Focus(); }
        }

    }
}
