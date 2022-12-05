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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CinemaProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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
                LoginForm.ticket.label6.Text = "Bilet Sayisini Secin:-";
                LoginForm.ticket.label5.Text = "Standart bilet:";
                LoginForm.ticket.label13.Text = "Oğrenci bilet:";
                LoginForm.ticket.label2.Text = "Elit bilet:";
                LoginForm.ticket.label8.Text = "VIP bilet:";
                LoginForm.ticket.label1.Text = "Müşterı adı:";
                LoginForm.ticket.label12.Text = "bilet tipi:";
                LoginForm.ticket.label3.Text = "Cep telefonu:";
                LoginForm.ticket.label4.Text = "Cinsiyet:";
                LoginForm.ticket.radioButton1.Text = "Erkek";
                LoginForm.ticket.radioButton2.Text = "kadın";
                LoginForm.ticket.guna2GradientCircleButton1.Text = "EKLE";
                LoginForm.ticket.guna2GroupBox1.Text = "Bilet Turu Detaylari:";
                LoginForm.ticket.label9.Text = "Standart Bilet:Sineme Giriş Bileti";
                LoginForm.ticket.label10.Text = "Elit Bilet:Sineme Giriş Bilet +Orta boy patlamiş mısır";
                LoginForm.ticket.label11.Text = "VIP Bilet::Sineme Giriş Bilet +büyük boy patlamiş mısır+Seçeceğniz içecek 10TL Limitli Fiyat";
                LoginForm.ticket.guna2GradientCircleButton2.Text = "koltugu Seçin";
                /////////////////////////////////////////////////////////////////
                //Translate For The AddMovies Form
                LoginForm.addMovies.guna2GradientButton3.Text = "Ana Sayfaya Dön";
                LoginForm.addMovies.label1.Text = "Film Adı:";
                LoginForm.addMovies.label5.Text = "iMDb Değelendirme:";
                LoginForm.addMovies.label3.Text = "Film süresi:";
                LoginForm.addMovies.label2.Text = "uygun yaş:";
                LoginForm.addMovies.label10.Text = "gösteri günleri";
                LoginForm.addMovies.label11.Text = "göstetri saatleri";
                LoginForm.addMovies.label8.Text = "türler";
                LoginForm.addMovies.label7.Text = "göstetri zamani:";
                LoginForm.addMovies.label6.Text = "yayın tarhhi:";
                LoginForm.addMovies.label4.Text = "Tanım:";
                LoginForm.addMovies.guna2GradientButton1.Text = "yükle";
                LoginForm.addMovies.label9.Text = "Film resmi";
                LoginForm.addMovies.guna2GradientButton2.Text = "Filmi Ekle";
                /////////////////////////////////////////////////////////////////
                //Translate For The Main Form 
                LoginForm.mainForm.label4.Text = "Müştari UI";
                LoginForm.mainForm.label3.Text = "Personal UI";
                LoginForm.mainForm.label8.Text = "Eski Şifre giriniz:";
                LoginForm.mainForm.label7.Text = "yeni Şifre giriniz:";
                LoginForm.mainForm.label6.Text = "yeni Şifre tekrar giriniz:";
                LoginForm.mainForm.guna2GradientButton1.Text = "değstir:";
                LoginForm.mainForm.guna2GradientCircleButton1.Text = "Hesap Şifresi değştir";
                GroupBox1.Text = "Hesap Şifresi değştir:";
                //Translate For the editsnacksMenu Form
                /////////////////////////////////////////////////////////////////
                LoginForm.editSnacks.label6.Text = "Kategori Adı:";
                LoginForm.editSnacks.AddRBtn.Text = "Ekle";
                LoginForm.editSnacks.EditRBtn.Text = "Düzenle";
                LoginForm.editSnacks.DeleteRBtn.Text = "Sil";
                LoginForm.editSnacks.label1.Text = "Ürün Adını Girin:";
                LoginForm.editSnacks.label5.Text = "Ürün Boyutunu Girin:";
                LoginForm.editSnacks.label2.Text ="Fiyatı Girin: ";
                LoginForm.editSnacks.guna2GradientCircleButton1.Text = "Keydet";
                /////////////////////////////////////////////////////////////
                ///Translate For The SnacksShop Form
                LoginForm.snacks.guna2GradientButton3.Text = "Ana Sayfaya Dön";
                LoginForm.snacks.label1.Text = "Bilet Numarasi:";
                LoginForm.snacks.label2.Text = "Toplam Fiyat:";
                LoginForm.snacks.label5.Text = "Ödeme Yöntemi:";
                LoginForm.snacks.guna2RadioButton1.Text = "Nakit";
                LoginForm.snacks.guna2RadioButton2.Text = "Kredi Card";
                LoginForm.snacks.guna2GradientButton2.Text = "Siparişi bitir";
                LoginForm.snacks.guna2GradientButton1.Text = "Siparişe ekle";















            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            GroupBox1.Visible = guna2GradientCircleButton1.Checked;
        }
    }
}
