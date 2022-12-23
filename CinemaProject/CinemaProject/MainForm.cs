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
        SqlConnection con = new SqlConnection(LoginForm.sqlcon);

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            // MEVCUT FILIMLERI
            this.Hide();
            LoginForm.moviesList.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            //MENÜYÜ GÖRUNTÜLEMEK İÇİN
            this.Hide();
            LoginForm.snacks.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {//BILET SATIŞI İÇİN
            this.Hide();
            LoginForm.ticket.Show();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            //MENÜNÜN DEĞİŞTİRİLMESI İÇİN
            this.Hide();
            LoginForm.editSnacks.Show();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {//FILMI EKLEMEK İÇİN
            this.Hide();
            LoginForm.addMovies.Show();
        }

        private void TypeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            //To Change Between The Customer UI And Worker UI
            if (TypeSwitch.Checked == true){
                LoginForm.loginForm.username.Clear(); ChangePassBtn.Visible = true;
                LoginForm.loginForm.ShowPass.Checked = false; this.Hide();
                LoginForm.loginForm.password.Clear(); LoginForm.loginForm.Show();

                TicketBtn.Location = new Point(100, 124); 
                MoviesListBtn.Location = new Point(509, 124);
                SnacksShopBtn.Location = new Point(858, 124);

                LoginForm.movieDetails.label3.Visible = true;
                LoginForm.movieDetails.label4.Visible = true;
                LoginForm.movieDetails.guna2ToggleSwitch2.Visible = true;

                TicketBtn.ImageSize = new Size(220, 120);
                TicketBtn.HoverState.ImageSize = new Size(230, 130);
                TicketBtn.PressedState.ImageSize = new Size(220, 120);


                MoviesListBtn.ImageSize = new Size(150, 140);
                MoviesListBtn.HoverState.ImageSize = new Size(160, 150);
                MoviesListBtn.PressedState.ImageSize = new Size(150, 140);

                SnacksShopBtn.ImageSize = new Size(175, 165);
                SnacksShopBtn.HoverState.ImageSize = new Size(185, 175);
                SnacksShopBtn.PressedState.ImageSize = new Size(175, 165);

                AddMoviesBtn.Visible = true;
                AdminPageBtn.Visible = true;
                EditMenuBtn.Visible = true;
            }
            else 
            {
                ChangePassBtn.Visible = false;

                TicketBtn.Location = new Point(115, 255);
                MoviesListBtn.Location = new Point(515, 255);
                SnacksShopBtn.Location = new Point(857, 255);

                LoginForm.movieDetails.label3.Visible = false;
                LoginForm.movieDetails.label4.Visible = false;
                LoginForm.movieDetails.guna2ToggleSwitch2.Visible = false;
                LoginForm.movieDetails.guna2ToggleSwitch2.Checked = false;

                TicketBtn.ImageSize =new Size (260, 160);
                TicketBtn.HoverState.ImageSize = new Size (270,170);
                TicketBtn.PressedState.ImageSize = new Size(260,160);

                MoviesListBtn.ImageSize = new Size(190,180);
                MoviesListBtn.HoverState.ImageSize = new Size(200,190);
                MoviesListBtn.PressedState.ImageSize = new Size(190,180);

                SnacksShopBtn.ImageSize = new Size(215, 205);
                SnacksShopBtn.HoverState.ImageSize = new Size(225, 215);
                SnacksShopBtn.PressedState.ImageSize = new Size(215, 205);

                AddMoviesBtn.Visible = false;
                AdminPageBtn.Visible = false;
                EditMenuBtn.Visible = false;

            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            //To Translate Between EN and TR
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
                LoginForm.ticket.guna2GroupBox2.Text = "Bilet Fiyatları:-";
                LoginForm.ticket.label6.Text = "1- Standart Bilet Fiyatı : 35TL.";
                LoginForm.ticket.label7.Text = "2- Öğrenci Bilet Fiyatı : 26TL.";
                LoginForm.ticket.label5.Text = "3- Elite Bilet Fiyatı : 45TL.";
                LoginForm.ticket.label2.Text = "4- VİP Bilet Fiyatı : 45TL.";
                LoginForm.ticket.guna2GradientCircleButton4.Text = "SİL";
                LoginForm.ticket.guna2GradientCircleButton2.Text = "Koltuğu Seç";
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
                LoginForm.addMovies.Link.Text = "Tanım:";
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
                ChangePassBtn.Text = "Hesap Şifresi Değştir";
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
                LoginForm.snacks.guna2GradientCircleButton2.Text = "Gir";
                //Translate For The AdmınPage

                LoginForm.admin.guna2TabControl1.TabPages[0].Text = "Gelir Paneli";
                LoginForm.admin.guna2TabControl1.TabPages[1].Text = "Kantini Yönet";
                LoginForm.admin.guna2TabControl1.TabPages[2].Text = "Bilet Siparşi";
                LoginForm.admin.guna2TabControl1.TabPages[3].Text = "Işçi yöntimi";
                LoginForm.admin.label3.Text = "Toplam Siparişi Sayısı";
                LoginForm.admin.label6.Text = "Kantin Geliri";
                LoginForm.admin.category.Text= "Kantin Gelir";
                LoginForm.admin.category.Text = "Kantin Gelir";
                LoginForm.admin.label1.Text = "Sineme Bileti Geliri";
                LoginForm.admin.label10.Text = "Toplam Satılan Bilet";
                LoginForm.admin.label8.Text = "Film Geliri";
                LoginForm.admin.label2.Text = "Toplam Geliri";
                LoginForm.admin.label12.Text = "Toplam Geliri";
                LoginForm.admin.label5.Text = "Belirli bir sipariste Ara";
                LoginForm.admin.guna2Button2.Text = "ARA";
                LoginForm.admin.label4.Text = "Belirli bir sipariste Ara";
                LoginForm.admin.guna2Button1.Text = "ARA";
                LoginForm.admin.label11.Text = "Yeni Personal Ekle:-";
                LoginForm.admin.label13.Text = "Personalin Adını Giriniz:";
                LoginForm.admin.label17.Text = "Personal Şifresini Giriniz:";
                LoginForm.admin.label18.Text = "Personal Şifresini Tekrar Giriniz:";
                LoginForm.admin.guna2TileButton1.Text = "Personal Ekle";

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
                LoginForm.moviesList.Snamelbl.Text = "Adı Göre Ara:";
                LoginForm.moviesList.Genrelbl2.Text = "Türe Göre Ara";
                LoginForm.moviesList.Snamelbl2.Text = "Adı Göre Ara";
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
                //Translate For The ChooseSeat Form
                LoginForm.seat.guna2GradientButton3.Text = "Ana Sayfaya Dön";
                LoginForm.seat.label1.Text = "Koltuğu Seç";
                LoginForm.seat.ChooseCust.Text = "Müşteriyi Seç";
                LoginForm.seat.label4.Text = "Müşteriyi Seç";
                LoginForm.seat.guna2GradientCircleButton1.Text = "Devam Et";
                LoginForm.seat.label2.Text = "Ekran";
                LoginForm.seat.label11.Text = "Çıkış";
                LoginForm.seat.guna2GradientCircleButton2.Text = "Ödemeye Git";
                LoginForm.seat.label14.Text = "Filml Seç";
                //Translate For The OrderDetails
                LoginForm.orderDetails.label1.Text = "Toplam Fıyatı";
                LoginForm.orderDetails.label4.Text = "Ödeme Şekli";
                LoginForm.orderDetails.guna2RadioButton3.Text = "Nakit";
                LoginForm.orderDetails.guna2RadioButton4.Text = "Kredi Kartı";
                LoginForm.orderDetails.guna2GradientCircleButton2.Text = "Siparişi Bitir";

                //Translate For The MovieList
                LoginForm.moviesList.guna2GradientCircleButton1.Text = "Yenile";





            }
            else
            {
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
                LoginForm.ticket.guna2GroupBox2.Text = "Ticket Prices:-";
                LoginForm.ticket.label6.Text = "1- Standard Ticket Price : 35TL.";
                LoginForm.ticket.label7.Text = "2- Student Ticket Price : 26TL.";
                LoginForm.ticket.label5.Text = "3- Elite Bilet Fiyatı : 45TL.";
                LoginForm.ticket.guna2GroupBox2.Text = ":";
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
                LoginForm.addMovies.Link.Text = "Description:";
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
                ChangePassBtn.Text = "Change Account Password";
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
                LoginForm.snacks.guna2GradientCircleButton2.Text = "Enter";

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
                //Translate For The ChooseSeat Form
                LoginForm.seat.guna2GradientButton3.Text = "Back To Main Menu";
                LoginForm.seat.label1.Text = "Choose The Seat ";
                LoginForm.seat.ChooseCust.Text = "Choose Customer:";
                LoginForm.seat.label4.Text = "Choose Customer:";
                LoginForm.seat.guna2GradientCircleButton1.Text = "Continue";
                LoginForm.seat.label2.Text = "Screen";
                LoginForm.seat.label11.Text = "Exit";
                LoginForm.seat.guna2GradientCircleButton2.Text = "Go To Pay";
                LoginForm.seat.label14.Text = "Choose The Movie";
                //Translate For The OrderDetails
                LoginForm.orderDetails.label1.Text = "Total Price";
                LoginForm.orderDetails.label4.Text = "Payment Method:";
                LoginForm.orderDetails.guna2RadioButton3.Text = "Cash";
                LoginForm.orderDetails.guna2RadioButton4.Text = "Credit Card";
                LoginForm.orderDetails.guna2GradientCircleButton2.Text = "Finish Order";
                //Translate For The AdminPage
                LoginForm.admin.guna2TabControl1.TabPages[0].Text = "Income Panel";
                LoginForm.admin.guna2TabControl1.TabPages[1].Text = "Manage Canteen Orders";
                LoginForm.admin.guna2TabControl1.TabPages[2].Text = "Manage Ticket Orders";
                LoginForm.admin.guna2TabControl1.TabPages[3].Text = "Worker Managment";
                LoginForm.admin.label3.Text = "Total Orders Count:";
                LoginForm.admin.label6.Text = "Canteen Income:";
                LoginForm.admin.category.Text = "Canteen Income";
                LoginForm.admin.label1.Text = "Movie Tickets Income";
                LoginForm.admin.label10.Text = "Total Sold Tickets:";
                LoginForm.admin.label8.Text = "Movies Income:";
                LoginForm.admin.label2.Text = "Total Income:";
                LoginForm.admin.label12.Text = "Total Income:";
                LoginForm.admin.label5.Text = "Search A Specific Order:";
                LoginForm.admin.guna2Button2.Text = "Search";
                LoginForm.admin.label4.Text = "Search A Specific Order:";
                LoginForm.admin.guna2Button1.Text = "Search";
                LoginForm.admin.label11.Text = "Add A New Woreker:-";
                LoginForm.admin.label13.Text = "Enter The Worker Name:";
                LoginForm.admin.label17.Text = "Enter The Worker's Password:";
                LoginForm.admin.label18.Text = "Enter The Password Again:";
                LoginForm.admin.guna2TileButton1.Text = "Add Worker";





            }
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
          // HESAP ŞİFRESİ DEĞŞTİRMEK İÇİN
            GroupBox1.Visible = ChangePassBtn.Checked;
            Createcaptcha();
        }

        void Createcaptcha()
        {
            //To Create Captcha Code
            Random r = new Random();
            int temp1 = r.Next(0, 49);
            int temp2 = r.Next(0, 50);
            sum = temp1 + temp2;
            label5.Text = temp1.ToString() + "+" + temp2.ToString();
        }
        Boolean Checkcaptcha()
        {
            //To Check If The Captcha Code Is Right Or Wrong
            if (TextBox4.Text == sum.ToString()) return true;
            else return false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //To Change The Password If The Entered Data Is Right
            if (Checkcaptcha())
            {
                if (TextBox2.Text != TextBox3.Text) { MessageBox.Show("The Entering Password Isn't The Same! Please Try Again"); TextBox2.Clear(); TextBox3.Clear(); TextBox4.Clear(); Createcaptcha(); }
                else
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select Password from Login Where ID='" + LoginForm.userid + "'", con);
                    if (command.ExecuteScalar().ToString() != TextBox1.Text) { MessageBox.Show("The Old Password Is Wrong! Please Check It And Try Again"); TextBox4.Clear(); Createcaptcha(); }
                    else
                    {
                        command = new SqlCommand("Update Login set Password='" + TextBox3.Text + "' where ID='" + LoginForm.userid + "'", con);
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //To Exit The App
            Application.Exit();
        }

        private void AdminPageBtn_Click(object sender, EventArgs e)
        {
            //To Show The Admin Page
            LoginForm.admin.ShowDialog();
        }
    }
}
