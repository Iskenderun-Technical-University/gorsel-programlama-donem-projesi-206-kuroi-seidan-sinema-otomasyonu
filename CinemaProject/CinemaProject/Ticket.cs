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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        public static int CustNo = 0,price;
        string gender;
        SqlConnection con = new SqlConnection(LoginForm.sqlcon);
        SqlCommand cmd;
        SqlDataAdapter sda;

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            //To Go To The Choosing Seat Step
            CustNo = listBox1.Items.Count ;
            if (CustNo == 0) MessageBox.Show("Please Add At Least One Customer And Try Again!!");
            else
            {
                string query = "select CustomerName from TempOrder where SeatNo is Null";
                con.Open();
                sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LoginForm.seat.CustomerCombox.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoginForm.seat.CustomerCombox.Items.Add(dt.Rows[i][0].ToString());
                }
                con.Close();
                this.Hide();
                LoginForm.seat.Show();
            }
        }

        public void ResetPage() {
            //To Reset Everything in This Form And Clear The Temp Table
            Type.SelectedIndex = -1; CustName.Clear(); PhoneNo.Clear(); radioButton1.Checked = false; radioButton2.Checked = false; listBox1.Items.Clear();listBox2.Items.Clear();
            LoginForm.seat.listBox1.Items.Clear(); ChooseSeat.selectedseats = 0; CustNo = 0; LoginForm.seat.cover.Visible = false;
            LoginForm.seat.guna2ComboBox2.SelectedIndex = -1; LoginForm.seat.ResetChairs(); LoginForm.seat.CustomerCombox.Items.Clear();
            string query = "delete from TempOrder where ID > 0";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            //To Clear Everything in This Form And Go To The Main Form
            ResetPage(); this.Hide();
            LoginForm.mainForm.Show();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            //BİLET BİLGİLERİNİ KAYDETMEK İÇİM
            if (radioButton1.Checked) gender = "Male";
            else if (radioButton2.Checked) gender = "Female";

            if (Type.Text == "Standard Ticket") price = 35;
            else if (Type.Text == "Student Ticket") price = 26;
            else if (Type.Text == "Elite Ticket") price = 45;
            else if (Type.Text == "VIP Ticket") price = 60;
            if (CustName.Text == "" || Type.SelectedIndex == -1) MessageBox.Show("You Can't Leave The Name And Ticket Type Empty!! Please Fill Them Then Try Again!!");
            else if (CustName.Text.Contains("  ") || CustName.Text[0].ToString() == " ") { MessageBox.Show("You Can't Make That Kind Of Spaces In Your Name!! Please Try Again."); CustName.Clear(); CustName.Focus(); }
            else
            {
                string query = "insert into TempOrder (CustomerName,TicketType,PhoneNo,Gender,Price) values ('" + CustName.Text + "','" + Type.Text + "','" + PhoneNo.Text + "','" + gender + "','" + price + "')";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                listBox1.Items.Add(CustName.Text);
                listBox2.Items.Add(Type.Text);
                CustName.Clear(); PhoneNo.Clear();
            }
        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //To Delete The Entered Customer Details From The List and The Table
                string query = "delete from TempOrder where CustomerName = '" + listBox1.Text + "'";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                int index = Convert.ToInt32(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);
            }
            catch { }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //To Select The Other list With This list
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //To Select The Other list With This list
            listBox1.SelectedIndex = listBox2.SelectedIndex;
        }
    }
}
