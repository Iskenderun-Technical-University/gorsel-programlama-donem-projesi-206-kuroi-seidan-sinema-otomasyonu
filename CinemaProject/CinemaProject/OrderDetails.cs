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
using CrystalDecisions.CrystalReports.Engine;

namespace CinemaProject
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(LoginForm.sqlcon);
        SqlCommand cmd;
        SqlDataAdapter sda;

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2RadioButton3.Checked == false && guna2RadioButton4.Checked == false) MessageBox.Show("Please Choose The Payment Method And Try Again !!!");
                else
                {
                    crystalReportViewer2.PrintReport();
                        string update = "";
                        if (guna2RadioButton3.Checked == true) update = "update TempOrder set Payment='" + guna2RadioButton3.Text + "' where ID>0";
                        else if (guna2RadioButton4.Checked == true) update = "update TempOrder set Payment='" + guna2RadioButton4.Text + "' where ID>0";
                        string add = "insert into TicketOrders select * from TempOrder";
                        con.Open();
                        cmd = new SqlCommand(update, con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand(add, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        LoginForm.seat.disableseat();
                        LoginForm.ticket.ResetPage();
                        guna2RadioButton3.Checked = false; guna2RadioButton4.Checked = false;
                        this.Hide();
                        LoginForm.mainForm.Show(); }
            }
            catch { }
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            con.Open();
             CrystalReport1 Receipt = new CrystalReport1();
            sda = new SqlDataAdapter("select ID,CustomerName,TicketType,MovieName,SeatNo,Price from TempOrder", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            Receipt.SetDataSource(ds.Tables[0]);
            crystalReportViewer2.ReportSource = Receipt ;
            con.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.seat.Show();
        }
    }
}
