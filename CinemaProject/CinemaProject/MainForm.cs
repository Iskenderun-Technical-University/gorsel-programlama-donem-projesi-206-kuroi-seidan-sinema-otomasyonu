using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CinemaProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        static int sum;
        static string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Kuroi Seidan Project\CinemaProject\CinemaProject\ProjectDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(sqlcon);
        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.moviesList.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.snacks.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.ticket.Show();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.editSnacks.Show();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.addMovies.Show();
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                //Translate For The Ticket Form
                LoginForm.ticket.guna2GradientButton3.Text = "Ana Sayfaya Dön";
                LoginForm.ticket.label1.Text = "Müşterı Adı:";
                LoginForm.ticket.label12.Text = "Bilet Tipi:";
                LoginForm.ticket.label3.Text = "Cep Telefonu:";
                LoginForm.ticket.label4.Text = "Cinsiyet:";
                LoginForm.ticket.radioButton1.Text = "Erkek";
                LoginForm.ticket.radioButton2.Text = "kadın";
                LoginForm.ticket.guna2GradientCircleButton1.Text = "EKLE";
                LoginForm.ticket.guna2GroupBox1.Text = "Bilet Turu Detaylari:";
                LoginForm.ticket.label9.Text = "1- Standart Bilet:Sineme Giriş Bileti.";
                LoginForm.ticket.label10.Text = "2- Elit Bilet:Sineme Giriş Bilet + Orta Boy Patlamiş Mısır.";
                LoginForm.ticket.label11.Text = "3- VIP Bilet:Sineme Giriş Bilet + Büyük Boy Patlamiş Mısır + Seçeceğniz Içecek 10TL Limitli Fiyat.";
                LoginForm.ticket.guna2GradientCircleButton2.Text = "Koltugu Seçin";
                /////////////////////////////////////////////////////////////////
                //Translate For The AddMovies Form
                LoginForm.addMovies.guna2GradientButton3.Text = "Ana Sayfaya Dön";
                LoginForm.addMovies.label1.Text = "Film Adı:";
                LoginForm.addMovies.label5.Text = "IMDb Puanı:";
                LoginForm.addMovies.label3.Text = "Uzunluk:";
                LoginForm.addMovies.label2.Text = "Uygun Yaş:";
                LoginForm.addMovies.label10.Text = "Gösteri Günleri";
                LoginForm.addMovies.label11.Text = "Göstetri Saatleri";
                LoginForm.addMovies.label8.Text = "Türler:";
                LoginForm.addMovies.label7.Text = "Gösteri Zamanlar:";
                LoginForm.addMovies.label6.Text = "Yayın Tarhhi:";
                LoginForm.addMovies.label4.Text = "Tanım:";
                LoginForm.addMovies.guna2GradientButton1.Text = "Yükle";
                LoginForm.addMovies.label9.Text = "Film Resmi";
                LoginForm.addMovies.guna2GradientButton2.Text = "Filmi Ekle";
                /////////////////////////////////////////////////////////////////
                //Translate For The Main Form 
                label4.Text = "Müştari UI";
                label3.Text = "Personal UI";
                label8.Text = "Eski Şifre Giriniz:";
                label7.Text = "Yeni Şifre Giriniz:";
                label6.Text = "Yeni Şifre Tekrar Giriniz:";
                guna2GradientButton1.Text = "Değştir";
                guna2GradientCircleButton1.Text = "Hesap Şifresi Değştir";
                GroupBox1.Text = "Hesap Şifresi Değştir:-";
                /////////////////////////////////////////////////////////////////
                //Translate For the editsnacksMenu Form
                LoginForm.editSnacks.label3.Text = "Not:- Lütfen!! Menüyü Düzenlemek Veya Bir Şeyi Silmek İçin Sol Taraftaki Listeden Bir Öğe Seçin!";
                LoginForm.editSnacks.guna2GradientButton3.Text = "Ana Sayfaya Dön";
                LoginForm.editSnacks.label6.Text = "Kategori Adı:";
                LoginForm.editSnacks.AddRBtn.Text = "Ekle";
                LoginForm.editSnacks.EditRBtn.Text = "Düzenle";
                LoginForm.editSnacks.DeleteRBtn.Text = "Sil";
                LoginForm.editSnacks.label1.Text = "Ürün Adını Girin:";
                LoginForm.editSnacks.label5.Text = "Ürün Boyutunu Girin:";
                LoginForm.editSnacks.label2.Text = "Fiyatı Girin: ";
                LoginForm.editSnacks.guna2GradientCircleButton1.Text = "Keydet";
                /////////////////////////////////////////////////////////////
                ///Translate For The SnacksShop Form
                LoginForm.snacks.guna2GradientButton3.Text = "Ana Sayfaya Dön";
                LoginForm.snacks.label1.Text = "Bilet Numarası:";
                LoginForm.snacks.label8.Text = "Toplam Fiyat:";
                LoginForm.snacks.label2.Text = "Ödeme Yöntemi:";
                LoginForm.snacks.guna2RadioButton3.Text = "Nakit";
                LoginForm.snacks.guna2RadioButton4.Text = "Kredi Kartı";
                LoginForm.snacks.guna2GradientButton2.Text = "Siparişi Bitir";
                LoginForm.snacks.guna2GradientButton5.Text = "Siparişe Ekle";
                LoginForm.snacks.guna2GradientButton4.Text = "Siparişten Sil";
                /////////////////////////////////////////////////////////////
                ///Translate For The LoginForm
                LoginForm.loginForm.Unamelbl.Text = "Kullanıcı Adı:";
                LoginForm.loginForm.Passlbl.Text = "Şifre:";
                LoginForm.loginForm.ShowPass.Text = "Şifre Göster";
                LoginForm.loginForm.ExitBtn.Text = "çıkış";
                LoginForm.loginForm.EnterBtn.Text = "Giriş";
                /////////////////////////////////////////////////////////////
                ///Translate For The MoviesList Form
                LoginForm.moviesList.BackMenuBtn.Text = "Ana Sayfaya Dön";
                LoginForm.moviesList.FilterBtn.Text = "Filtreler";
                LoginForm.moviesList.Genrelbl.Text = "Türü Seçin:";
                LoginForm.moviesList.Snamelbl.Text = "Ada Göre Ara:";
                LoginForm.moviesList.Genrelbl2.Text = "Türe Göre Ara";
                LoginForm.moviesList.Snamelbl2.Text = "Ada Göre Ara";
                LoginForm.moviesList.SearchBtn.Text = "Ara";
                /////////////////////////////////////////////////////////////
                ///Translate For The MovieDetails Form
                LoginForm.movieDetails.label3.Text = "Düzenleme Modu";
                LoginForm.movieDetails.label4.Text = "Gösteri Modu";
                LoginForm.movieDetails.SaveBtn.Text = "Kaydet";
                LoginForm.movieDetails.uploadImgBtn.Text = "Resmi Yükle";
                LoginForm.movieDetails.DeleteBtn.Text = "Filmi Sil";
                LoginForm.movieDetails.movieNameLabel.Text = "Film Adı:";
                LoginForm.movieDetails.ageRatingLabel.Text = "Uygun Yaş:";
                LoginForm.movieDetails.descriptionLabel.Text = "Tanım:";
                LoginForm.movieDetails.genresLabel.Text = "Türler:";
                LoginForm.movieDetails.iMDbRatingLabel.Text = "IMDb Puanı:";
                LoginForm.movieDetails.lengthLabel.Text = "Uzunluk:";
                LoginForm.movieDetails.releaseDateLabel.Text = "Yayın Tarihi:";
                LoginForm.movieDetails.showDaysLabel.Text = "Gösteri Günleri:";
                LoginForm.movieDetails.showHoursLabel.Text = "Gösteri Saatleri:";
            }
            else {
                //Translate For The Ticket Form
                LoginForm.ticket.guna2GradientButton3.Text = "Back To Main Menu";
                LoginForm.ticket.label1.Text = "Customer Name:";
                LoginForm.ticket.label12.Text = "Ticket Type:";
                LoginForm.ticket.label3.Text = "Phone Number:";
                LoginForm.ticket.label4.Text = "Gender:";
                LoginForm.ticket.radioButton1.Text = "Male";
                LoginForm.ticket.radioButton2.Text = "Female";
                LoginForm.ticket.guna2GradientCircleButton1.Text = "ADD";
                LoginForm.ticket.guna2GroupBox1.Text = "Ticket Types Details:";
                LoginForm.ticket.label9.Text = "1- Standard Ticket: The Movie Entry Ticket.";
                LoginForm.ticket.label10.Text = "2- Elite Ticket: Movie Entry Ticket + Meduim PopCorn.";
                LoginForm.ticket.label11.Text = "3- VIP Ticket: The Movie Entry + Large PopCorn Of Choice + Drink Of Choice With 10TL Limit Price.";
                LoginForm.ticket.guna2GradientCircleButton2.Text = "Choose The Seat";
                /////////////////////////////////////////////////////////////////
                //Translate For The AddMovies Form
                LoginForm.addMovies.guna2GradientButton3.Text = "Back To Main Menu";
                LoginForm.addMovies.label1.Text = "Movie Name:";
                LoginForm.addMovies.label5.Text = "IMDb Rating:";
                LoginForm.addMovies.label3.Text = "Length:";
                LoginForm.addMovies.label2.Text = "Age Rating:";
                LoginForm.addMovies.label10.Text = "Show Days";
                LoginForm.addMovies.label11.Text = "Show Hours";
                LoginForm.addMovies.label8.Text = "Genres:";
                LoginForm.addMovies.label7.Text = "Show Times:";
                LoginForm.addMovies.label6.Text = "Realese Date:";
                LoginForm.addMovies.label4.Text = "Description:";
                LoginForm.addMovies.guna2GradientButton1.Text = "Upload Picture";
                LoginForm.addMovies.label9.Text = "Movie Picture";
                LoginForm.addMovies.guna2GradientButton2.Text = "Add The Movie";
                /////////////////////////////////////////////////////////////////
                //Translate For The Main Form 
                label4.Text = "Costumer UI";
                label3.Text = "Worker UI";
                label8.Text = "Enter The Old Password:";
                label7.Text = "Enter The New Password:";
                label6.Text = "Enter The Password Again:";
                guna2GradientButton1.Text = "Change";
                guna2GradientCircleButton1.Text = "Change Account Password";
                GroupBox1.Text = "Change Account Password:-";
                /////////////////////////////////////////////////////////////////
                //Translate For the editsnacksMenu Form
                LoginForm.editSnacks.label3.Text = "Note:- Please!! For Edit the Menu Or delete something, Select An Item From The List left side!";
                LoginForm.editSnacks.guna2GradientButton3.Text = "Back To Main Menu";
                LoginForm.editSnacks.label6.Text = "Kategori Adı:";
                LoginForm.editSnacks.AddRBtn.Text = "ADD";
                LoginForm.editSnacks.EditRBtn.Text = "EDIT";
                LoginForm.editSnacks.DeleteRBtn.Text = "DELETE";
                LoginForm.editSnacks.label1.Text = "Enter The Product Name:";
                LoginForm.editSnacks.label5.Text = "Enter The Product Size:";
                LoginForm.editSnacks.label2.Text = "Enter The Price:";
                LoginForm.editSnacks.guna2GradientCircleButton1.Text = "Save";
                /////////////////////////////////////////////////////////////
                ///Translate For The SnacksShop Form
                LoginForm.snacks.guna2GradientButton3.Text = "Back To Main Menu";
                LoginForm.snacks.label1.Text = "Ticket Number:";
                LoginForm.snacks.label8.Text = "Total Price:";
                LoginForm.snacks.label2.Text = "Payment Method:";
                LoginForm.snacks.guna2RadioButton3.Text = "Cash";
                LoginForm.snacks.guna2RadioButton4.Text = "Credit Card";
                LoginForm.snacks.guna2GradientButton2.Text = "Finish Order";
                LoginForm.snacks.guna2GradientButton5.Text = "Add To Order";
                LoginForm.snacks.guna2GradientButton4.Text = "Delete From Order";
                /////////////////////////////////////////////////////////////
                ///Translate For The LoginForm
                LoginForm.loginForm.Unamelbl.Text = "User Name:";
                LoginForm.loginForm.Passlbl.Text = "Password:";
                LoginForm.loginForm.ShowPass.Text = "Show Password";
                LoginForm.loginForm.ExitBtn.Text = "Exit";
                LoginForm.loginForm.EnterBtn.Text = "Enter";
                /////////////////////////////////////////////////////////////
                ///Translate For The MoviesList Form
                LoginForm.moviesList.BackMenuBtn.Text = "Back To Main Menu";
                LoginForm.moviesList.FilterBtn.Text = "Filters";
                LoginForm.moviesList.Genrelbl.Text = "Choose The Genre:";
                LoginForm.moviesList.Snamelbl.Text = "Search By Name:";
                LoginForm.moviesList.Genrelbl2.Text = "Search By Genre";
                LoginForm.moviesList.Snamelbl2.Text = "Search By Name";
                LoginForm.moviesList.SearchBtn.Text = "Search";
                /////////////////////////////////////////////////////////////
                ///Translate For The MovieDetails Form
                LoginForm.movieDetails.label3.Text = "Editing Mode";
                LoginForm.movieDetails.label4.Text = "Show Mode";
                LoginForm.movieDetails.SaveBtn.Text = "Save";
                LoginForm.movieDetails.uploadImgBtn.Text = "Upload Picture";
                LoginForm.movieDetails.DeleteBtn.Text = "Delete The Movie";
                LoginForm.movieDetails.movieNameLabel.Text = "Movie Name:";
                LoginForm.movieDetails.ageRatingLabel.Text = "Age Rating:";
                LoginForm.movieDetails.descriptionLabel.Text = "Description:";
                LoginForm.movieDetails.genresLabel.Text = "Genres:";
                LoginForm.movieDetails.iMDbRatingLabel.Text = "IMDb Rating:";
                LoginForm.movieDetails.lengthLabel.Text = "Length:";
                LoginForm.movieDetails.releaseDateLabel.Text = "Release Date:";
                LoginForm.movieDetails.showDaysLabel.Text = "Show Days:";
                LoginForm.movieDetails.showHoursLabel.Text = "Show Hours:";
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            GroupBox1.Visible = guna2GradientCircleButton1.Checked;
            Createcaptcha();
        }

        void Createcaptcha()
        {
            Random r = new Random();
            int temp1 = r.Next(0, 49);
            int temp2 = r.Next(0, 50);
            sum = temp1 + temp2;
            label5.Text = temp1.ToString() + "+" + temp2.ToString();
        }
        Boolean Checkcaptcha()
        {
            if (TextBox4.Text == sum.ToString()) return true;
            else return false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (Checkcaptcha())
            {
                if (TextBox2.Text != TextBox3.Text) { MessageBox.Show("The Entering Password Isn't The Same! Please Try Again"); TextBox2.Clear(); TextBox3.Clear(); TextBox4.Clear(); Createcaptcha(); }
                else
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select Password from LoginTb Where UserID='" + LoginForm.userid + "'", con);
                    if (command.ExecuteScalar().ToString() != TextBox1.Text) { MessageBox.Show("The Old Password Is Wrong! Please Check It And Try Again"); TextBox4.Clear(); Createcaptcha(); }
                    else
                    {
                        command = new SqlCommand("Update LoginTb set Password='" + TextBox3.Text + "' where UserID='" + LoginForm.userid + "'", con);
                        if (command.ExecuteNonQuery() == 1) MessageBox.Show("Your Password Changed Successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GroupBox1.Visible = false;
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("The Captcha Is Wrong!, Please Try Again ");
                TextBox4.Clear();
                Createcaptcha();
            }
        }
    }
}
