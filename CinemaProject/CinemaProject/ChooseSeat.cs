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
using System.Runtime;
using System.IO;

namespace CinemaProject
{
    public partial class ChooseSeat : Form
    {
        public ChooseSeat()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(LoginForm.sqlcon);
        SqlDataAdapter sda;
        SqlCommand cmd;
        public static int selectedseats = 0;
        string currentseat;

        public void disableseat() {
            //To Stop Using The Bought Seat
            if (A1.Checked==false) { A1.Enabled = false; }
            if (A2.Checked == false) { A2.Enabled = false; }
            if (A3.Checked == false) { A3.Enabled = false; }
            if (A4.Checked == false) { A4.Enabled = false; }
            if (A5.Checked == false) { A5.Enabled = false; }
            if (A6.Checked == false) { A6.Enabled = false; }
            if (A7.Checked == false) { A7.Enabled = false; }
            if (A8.Checked == false) { A8.Enabled = false; }
            if (A9.Checked == false) { A9.Enabled = false; }
            if (A10.Checked == false) { A10.Enabled = false; }
            if (A11.Checked == false) { A11.Enabled = false; }
            if (A12.Checked == false) { A12.Enabled = false; }
            if (B1.Checked == false) { B1.Enabled = false; }
            if (B2.Checked == false) { B2.Enabled = false; }
            if (B3.Checked == false) { B3.Enabled = false; }
            if (B4.Checked == false) { B4.Enabled = false; }
            if (B5.Checked == false) { B5.Enabled = false; }
            if (B6.Checked == false) { B6.Enabled = false; }
            if (B7.Checked == false) { B7.Enabled = false; }
            if (B8.Checked == false) { B8.Enabled = false; }
            if (B9.Checked == false) { B9.Enabled = false; }
            if (B10.Checked == false) { B10.Enabled = false; }
            if (B11.Checked == false) { B11.Enabled = false; }
            if (B12.Checked == false) { B12.Enabled = false; }
            if (C1.Checked == false) { C1.Enabled = false; }
            if (C2.Checked == false) { C2.Enabled = false; }
            if (C3.Checked == false) { C3.Enabled = false; }
            if (C4.Checked == false) { C4.Enabled = false; }
            if (C5.Checked == false) { C5.Enabled = false; }
            if (C6.Checked == false) { C6.Enabled = false; }
            if (C7.Checked == false) { C7.Enabled = false; }
            if (C8.Checked == false) { C8.Enabled = false; }
            if (C9.Checked == false) { C9.Enabled = false; }
            if (C10.Checked == false) { C10.Enabled = false; }
            if (C11.Checked == false) { C11.Enabled = false; }
            if (C12.Checked == false) { C12.Enabled = false; }
            if (D1.Checked == false) { D1.Enabled = false; }
            if (D2.Checked == false) { D2.Enabled = false; }
            if (D3.Checked == false) { D3.Enabled = false; }
            if (D4.Checked == false) { D4.Enabled = false; }
            if (D5.Checked == false) { D5.Enabled = false; }
            if (D6.Checked == false) { D6.Enabled = false; }
            if (D7.Checked == false) { D7.Enabled = false; }
            if (D8.Checked == false) { D8.Enabled = false; }
            if (D9.Checked == false) { D9.Enabled = false; }
            if (D10.Checked == false) { D10.Enabled = false; }
            if (D11.Checked == false) { D11.Enabled = false; }
            if (D12.Checked == false) { D12.Enabled = false; }
            if (E1.Checked == false) { E1.Enabled = false; }
            if (E2.Checked == false) { E2.Enabled = false; }
            if (E3.Checked == false) { E3.Enabled = false; }
            if (E4.Checked == false) { E4.Enabled = false; }
            if (E5.Checked == false) { E5.Enabled = false; }
            if (E6.Checked == false) { E6.Enabled = false; }
            if (E7.Checked == false) { E7.Enabled = false; }
            if (E8.Checked == false) { E8.Enabled = false; }
            if (E9.Checked == false) { E9.Enabled = false; }
            if (E10.Checked == false) { E10.Enabled = false; }
            if (E11.Checked == false) { E11.Enabled = false; }
            if (E12.Checked == false) { E12.Enabled = false; }
        }

        public void ResetChairs()
        {
            //To Reset All The seats
            if (A1.Checked == false) { A1.Checked = true; A1.Image = imageList1.Images[1]; }
            if (A2.Checked == false) { A2.Checked = true; A2.Image = imageList1.Images[1]; }
            if (A3.Checked == false) { A3.Checked = true; A3.Image = imageList1.Images[1]; }
            if (A4.Checked == false) { A4.Checked = true; A4.Image = imageList1.Images[1]; }
            if (A5.Checked == false) { A5.Checked = true; A5.Image = imageList1.Images[1]; }
            if (A6.Checked == false) { A6.Checked = true; A6.Image = imageList1.Images[1]; }
            if (A7.Checked == false) { A7.Checked = true; A7.Image = imageList1.Images[1]; }
            if (A8.Checked == false) { A8.Checked = true; A8.Image = imageList1.Images[1]; }
            if (A9.Checked == false) { A9.Checked = true; A9.Image = imageList1.Images[1]; }
            if (A10.Checked == false) { A10.Checked = true; A10.Image = imageList1.Images[1]; }
            if (A11.Checked == false) { A11.Checked = true; A11.Image = imageList1.Images[1]; }
            if (A12.Checked == false) { A12.Checked = true;A12.Image = imageList1.Images[1]; }
            if (B1.Checked == false) { B1.Checked = true; B1.Image = imageList1.Images[1]; }
            if (B2.Checked == false) { B2.Checked = true; B2.Image = imageList1.Images[1]; }
            if (B3.Checked == false) { B3.Checked = true; B3.Image = imageList1.Images[1]; }
            if (B4.Checked == false) { B4.Checked = true; B4.Image = imageList1.Images[1]; }
            if (B5.Checked == false) { B5.Checked = true; B5.Image = imageList1.Images[1]; }
            if (B6.Checked == false) { B6.Checked = true; B6.Image = imageList1.Images[1]; }
            if (B7.Checked == false) { B7.Checked = true; B7.Image = imageList1.Images[1]; }
            if (B8.Checked == false) { B8.Checked = true; B8.Image = imageList1.Images[1]; }
            if (B9.Checked == false) { B9.Checked = true; B9.Image = imageList1.Images[1]; }
            if (B10.Checked == false) { B10.Checked = true; B10.Image = imageList1.Images[1]; }
            if (B11.Checked == false) { B11.Checked = true; B11.Image = imageList1.Images[1]; }
            if (B12.Checked == false) { B12.Checked = true; B12.Image = imageList1.Images[1]; }
            if (C1.Checked == false) { C1.Checked = true; C1.Image = imageList1.Images[1]; }
            if (C2.Checked == false) { C2.Checked = true; C2.Image = imageList1.Images[1]; }
            if (C3.Checked == false) { C3.Checked = true; C3.Image = imageList1.Images[1]; }
            if (C4.Checked == false) { C4.Checked = true; C4.Image = imageList1.Images[1]; }
            if (C5.Checked == false) { C5.Checked = true; C5.Image = imageList1.Images[1]; }
            if (C6.Checked == false) { C6.Checked = true; C6.Image = imageList1.Images[1]; }
            if (C7.Checked == false) { C7.Checked = true; C7.Image = imageList1.Images[1]; }
            if (C8.Checked == false) { C8.Checked = true; C8.Image = imageList1.Images[1]; }
            if (C9.Checked == false) { C9.Checked = true; C9.Image = imageList1.Images[1]; }
            if (C10.Checked == false) { C10.Checked = true; C10.Image = imageList1.Images[1]; }
            if (C11.Checked == false) { C11.Checked = true; C11.Image = imageList1.Images[1]; }
            if (C12.Checked == false) { C12.Checked = true; C12.Image = imageList1.Images[1]; }
            if (D1.Checked == false) { D1.Checked = true; D1.Image = imageList1.Images[1]; }
            if (D2.Checked == false) { D2.Checked = true; D2.Image = imageList1.Images[1]; }
            if (D3.Checked == false) { D3.Checked = true; D3.Image = imageList1.Images[1]; }
            if (D4.Checked == false) { D4.Checked = true; D4.Image = imageList1.Images[1]; }
            if (D5.Checked == false) { D5.Checked = true; D5.Image = imageList1.Images[1]; }
            if (D6.Checked == false) { D6.Checked = true; D6.Image = imageList1.Images[1]; }
            if (D7.Checked == false) { D7.Checked = true; D7.Image = imageList1.Images[1]; }
            if (D8.Checked == false) { D8.Checked = true; D8.Image = imageList1.Images[1]; }
            if (D9.Checked == false) { D9.Checked = true; D9.Image = imageList1.Images[1]; }
            if (D10.Checked == false) { D10.Checked = true; D10.Image = imageList1.Images[1]; }
            if (D11.Checked == false) { D11.Checked = true; D11.Image = imageList1.Images[1]; }
            if (D12.Checked == false) { D12.Checked = true; D12.Image = imageList1.Images[1]; }
            if (E1.Checked == false) { E1.Checked = true; E1.Image = imageList1.Images[1]; }
            if (E2.Checked == false) { E2.Checked = true; E2.Image = imageList1.Images[1]; }
            if (E3.Checked == false) { E3.Checked = true; E3.Image = imageList1.Images[1]; }
            if (E4.Checked == false) { E4.Checked = true; E4.Image = imageList1.Images[1]; }
            if (E5.Checked == false) { E5.Checked = true; E5.Image = imageList1.Images[1]; }
            if (E6.Checked == false) { E6.Checked = true; E6.Image = imageList1.Images[1]; }
            if (E7.Checked == false) { E7.Checked = true; E7.Image = imageList1.Images[1]; }
            if (E8.Checked == false) { E8.Checked = true; E8.Image = imageList1.Images[1]; }
            if (E9.Checked == false) { E9.Checked = true; E9.Image = imageList1.Images[1]; }
            if (E10.Checked == false) { E10.Checked = true; E10.Image = imageList1.Images[1]; }
            if (E11.Checked == false) { E11.Checked = true; E11.Image = imageList1.Images[1]; }
            if (E12.Checked == false) { E12.Checked = true; E12.Image = imageList1.Images[1]; }
        }

        public void Seats(Guna.UI2.WinForms.Guna2ImageButton x)
        {
            //To Check or Uncheck The Seat
                if (x.Checked == true)
                {
                    if (selectedseats >= Ticket.CustNo) MessageBox.Show("You Have Selected The Maximum Number Of Seats For this Order!!");
                    else
                    {
                        x.Image = imageList1.Images[0];
                        x.Checked = false;
                        selectedseats++;
                        cover.Visible = true;
                        currentseat = x.Name;
                    }
                }
                else if (x.Checked == false)
                {
                    x.Image = imageList1.Images[1];
                    x.Checked = true;
                    selectedseats--;
                    string query1 = "select CustomerName from TempOrder where SeatNo='" + x.Name + "'";
                    string query2 = "update TempOrder set SeatNo= NULL where SeatNo='" + x.Name + "'";
                    con.Open();
                    cmd = new SqlCommand(query1, con);
                    CustomerCombox.Items.Add(cmd.ExecuteScalar());
                    cmd.CommandText = query2;
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
        }

        private void E1_Click(object sender, EventArgs e) {Seats(E1);}

        private void E2_Click(object sender, EventArgs e) {Seats(E2);}

        private void E3_Click(object sender, EventArgs e) {Seats(E3);}

        private void E4_Click(object sender, EventArgs e) {Seats(E4);}

        private void E5_Click(object sender, EventArgs e) {Seats(E5);}

        private void E6_Click(object sender, EventArgs e) {Seats(E6);}

        private void D1_Click(object sender, EventArgs e) {Seats(D1);}

        private void D2_Click(object sender, EventArgs e) {Seats(D2);}

        private void D3_Click(object sender, EventArgs e) {Seats(D3);}

        private void D4_Click(object sender, EventArgs e) {Seats(D4);}

        private void D5_Click(object sender, EventArgs e) {Seats(D5);}

        private void D6_Click(object sender, EventArgs e) {Seats(D6);}

        private void C1_Click(object sender, EventArgs e) { Seats(C1);}

        private void C2_Click(object sender, EventArgs e) {Seats(C2);}

        private void C3_Click(object sender, EventArgs e) {Seats(C3);}

        private void C4_Click(object sender, EventArgs e) {Seats(C4);}

        private void C5_Click(object sender, EventArgs e) {Seats(C5);}

        private void C6_Click(object sender, EventArgs e) {Seats(C6);}

        private void B1_Click(object sender, EventArgs e) {Seats(B1);}

        private void B2_Click(object sender, EventArgs e) {Seats(B2);}

        private void B3_Click(object sender, EventArgs e) {Seats(B3);}

        private void B4_Click(object sender, EventArgs e) {Seats(B4);}

        private void B5_Click(object sender, EventArgs e) {Seats(B5);}

        private void B6_Click(object sender, EventArgs e) {Seats(B6);}

        private void A1_Click(object sender, EventArgs e) {Seats(A1);}

        private void A2_Click(object sender, EventArgs e) {Seats(A2);}

        private void A3_Click(object sender, EventArgs e) {Seats(A3);}

        private void A4_Click(object sender, EventArgs e) {Seats(A4);}

        private void A5_Click(object sender, EventArgs e) {Seats(A5);}

        private void A6_Click(object sender, EventArgs e) {Seats(A6);}

        private void E7_Click(object sender, EventArgs e) { Seats(E7);}

        private void E8_Click(object sender, EventArgs e) { Seats(E8);}

        private void E9_Click(object sender, EventArgs e) { Seats(E9);}

        private void E10_Click(object sender, EventArgs e) { Seats(E10);}

        private void E11_Click(object sender, EventArgs e) { Seats(E11);}

        private void E12_Click(object sender, EventArgs e) { Seats(E12);}

        private void D7_Click(object sender, EventArgs e) { Seats(D7); }

        private void D8_Click(object sender, EventArgs e) { Seats(D8); }

        private void D9_Click(object sender, EventArgs e) { Seats(D9); }

        private void D10_Click(object sender, EventArgs e) { Seats(D10); }

        private void D11_Click(object sender, EventArgs e) { Seats(D11); }

        private void D12_Click(object sender, EventArgs e) { Seats(D12); }

        private void C7_Click(object sender, EventArgs e) { Seats(C7); }

        private void C8_Click(object sender, EventArgs e) { Seats(C8); }

        private void C9_Click(object sender, EventArgs e) { Seats(C9); }

        private void C10_Click(object sender, EventArgs e) { Seats(C10); }

        private void C11_Click(object sender, EventArgs e) { Seats(C11); }

        private void C12_Click(object sender, EventArgs e) { Seats(C12); }

        private void B7_Click(object sender, EventArgs e) { Seats(B7); }

        private void B8_Click(object sender, EventArgs e) { Seats(B8); }

        private void B9_Click(object sender, EventArgs e) { Seats(B9); }

        private void B10_Click(object sender, EventArgs e) { Seats(B10); }

        private void B11_Click(object sender, EventArgs e) { Seats(B11); }

        private void B12_Click(object sender, EventArgs e) { Seats(B12); }

        private void A7_Click(object sender, EventArgs e) { Seats(A7); }

        private void A8_Click(object sender, EventArgs e) { Seats(A8); }

        private void A9_Click(object sender, EventArgs e) { Seats(A9); }

        private void A10_Click(object sender, EventArgs e) { Seats(A10); }

        private void A11_Click(object sender, EventArgs e) { Seats(A11); }

        private void A12_Click(object sender, EventArgs e) { Seats(A12); }

        private void ChooseSeat_Load(object sender, EventArgs e)
        {
            //To Show The Movies in the CompoBox
            string query = "select MovieName from MoviesTbl where ShowDays Like '%"+DateTime.Now.ToString("dddd")+"%'";
            con.Open();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(query,con);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                guna2ComboBox2.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    guna2ComboBox2.Items.Add(dt.Rows[i][0]);
                }
            }
            else MessageBox.Show("No Data Found");
            con.Close();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            //To Back To The Ticke Form
            this.Hide();
            LoginForm.ticket.Show();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //To show The ShowHours Of the Movie in The ListBox
            if (guna2ComboBox2.SelectedIndex != -1)
            {
                listBox1.Items.Clear();
                string query = "select ShowHours from MoviesTbl where MovieName='" + guna2ComboBox2.Text + "'";
                con.Open();
                cmd = new SqlCommand(query, con);
                string temp = cmd.ExecuteScalar().ToString();
                string now = "";
                for (int i = 0; i < temp.Length; i++)
                {
                    if (char.IsPunctuation(temp[i]))
                    {
                        if (temp[i] == ':') { now += temp[i]; continue; }
                        else
                        {
                            listBox1.Items.Add(now);
                            now = "";
                        }
                    }
                    else now += temp[i];
                }
                listBox1.Items.Add(now);
                con.Close();
            }
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            //To Save The Seat Data For The Customer
            string query = "update TempOrder set SeatNo='"+currentseat+"' where CustomerName='"+CustomerCombox.Text+"'";
            CustomerCombox.Items.Remove(CustomerCombox.Text);
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cover.Visible = false;
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            //To Enter The Next Form If EveryThing Is Good!
            if (selectedseats != Ticket.CustNo) MessageBox.Show("Please Choose A seat For All The Customers!!");
            else if (listBox1.SelectedIndex == -1) MessageBox.Show("Please Choose The Movie And Show Time!!");
            else
            {
                string query = "select CustomerName,TicketType,SeatNo,Price from TempOrder";
                string update = "update TempOrder set MovieName='" + guna2ComboBox2.Text + "' ,Date='" + DateTime.Now.ToString("MM/dd/yyyy") + "', ShowTime='" + listBox1.Text + "' where ID>0";
                con.Open();
                cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(query,con);
                DataTable dt=new DataTable();
                sda.Fill(dt);
                LoginForm.orderDetails.guna2DataGridView1.DataSource = dt;
                cmd = new SqlCommand("select sum(Price) from TempOrder", con);
                LoginForm.orderDetails.label2.Text = cmd.ExecuteScalar().ToString();
                con.Close();
                this.Hide();
                LoginForm.orderDetails.Show();
                LoginForm.orderDetails.Location = this.Location;

                con.Open();
                CrystalReport1 Receipt = new CrystalReport1();
                sda = new SqlDataAdapter("select ID,CustomerName,TicketType,MovieName,SeatNo,Price from TempOrder", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                Receipt.SetDataSource(ds.Tables[0]);
                LoginForm.orderDetails.crystalReportViewer2.ReportSource = Receipt;
                con.Close();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //To Close The App
            Application.Exit();
        }
    }
}
