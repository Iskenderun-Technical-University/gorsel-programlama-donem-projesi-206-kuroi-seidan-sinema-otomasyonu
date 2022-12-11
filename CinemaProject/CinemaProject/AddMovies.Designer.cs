
namespace CinemaProject
{
    partial class AddMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.imdbRate = new System.Windows.Forms.Label();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.GenresList = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DaysList = new System.Windows.Forms.CheckedListBox();
            this.HoursList = new System.Windows.Forms.CheckedListBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Length = new Guna.UI2.WinForms.Guna2TextBox();
            this.AgeRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.MovieName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // imdbRate
            // 
            this.imdbRate.AutoSize = true;
            this.imdbRate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbRate.Location = new System.Drawing.Point(869, 338);
            this.imdbRate.Name = "imdbRate";
            this.imdbRate.Size = new System.Drawing.Size(19, 21);
            this.imdbRate.TabIndex = 65;
            this.imdbRate.Text = "0";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(663, 327);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.Gold;
            this.guna2RatingStar1.Size = new System.Drawing.Size(200, 43);
            this.guna2RatingStar1.TabIndex = 64;
            this.guna2RatingStar1.ValueChanged += new System.EventHandler(this.guna2RatingStar1_ValueChanged);
            // 
            // GenresList
            // 
            this.GenresList.BackColor = System.Drawing.Color.White;
            this.GenresList.Font = new System.Drawing.Font("Segoe UI", 11.278F);
            this.GenresList.FormattingEnabled = true;
            this.GenresList.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Musicals",
            "Mystery",
            "Romance",
            "Science fiction",
            "Sports",
            "Thriller",
            "Western"});
            this.GenresList.Location = new System.Drawing.Point(663, 474);
            this.GenresList.Name = "GenresList";
            this.GenresList.Size = new System.Drawing.Size(200, 165);
            this.GenresList.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 31);
            this.label11.TabIndex = 62;
            this.label11.Text = "Show Hours";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(154, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 31);
            this.label10.TabIndex = 61;
            this.label10.Text = "Show Days";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DaysList
            // 
            this.DaysList.BackColor = System.Drawing.Color.White;
            this.DaysList.Font = new System.Drawing.Font("Segoe UI", 11.278F);
            this.DaysList.FormattingEnabled = true;
            this.DaysList.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.DaysList.Location = new System.Drawing.Point(154, 473);
            this.DaysList.Name = "DaysList";
            this.DaysList.Size = new System.Drawing.Size(170, 165);
            this.DaysList.TabIndex = 60;
            // 
            // HoursList
            // 
            this.HoursList.BackColor = System.Drawing.Color.White;
            this.HoursList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HoursList.FormattingEnabled = true;
            this.HoursList.Items.AddRange(new object[] {
            "10:15AM",
            "10:45AM",
            "12:00PM",
            "01:00PM",
            "01:45PM",
            "03:15PM",
            "03:30PM",
            "05:15PM",
            "05:30PM",
            "07:00PM",
            "07:45PM",
            "08:45PM",
            "10:00PM",
            "10:30PM"});
            this.HoursList.Location = new System.Drawing.Point(324, 474);
            this.HoursList.Name = "HoursList";
            this.HoursList.Size = new System.Drawing.Size(170, 164);
            this.HoursList.TabIndex = 59;
            // 
            // Description
            // 
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(154, 253);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(342, 148);
            this.Description.TabIndex = 55;
            this.Description.Text = "";
            // 
            // Date
            // 
            this.Date.Checked = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date.Location = new System.Drawing.Point(663, 405);
            this.Date.MaxDate = new System.DateTime(2077, 11, 16, 23, 59, 59, 999);
            this.Date.MinDate = new System.DateTime(1900, 4, 30, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 43);
            this.Date.TabIndex = 58;
            this.Date.Value = new System.DateTime(2022, 10, 1, 4, 25, 4, 299);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 2;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Brown;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(12, 54);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(132, 55);
            this.guna2GradientButton3.TabIndex = 57;
            this.guna2GradientButton3.Text = "Back To Main Menu";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click_1);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ImageButton1);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.IndianRed;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Brown;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1280, 48);
            this.guna2CustomGradientPanel1.TabIndex = 56;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(44, 55);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(44, 55);
            this.guna2ImageButton1.Image = global::CinemaProject.Properties.Resources._1200px_Font_Awesome_5_solid_times_svg;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1228, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(40, 50);
            this.guna2ImageButton1.Size = new System.Drawing.Size(47, 43);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 2;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Brown;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1030, 485);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(149, 45);
            this.guna2GradientButton1.TabIndex = 54;
            this.guna2GradientButton1.Text = "Upload Picture";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(945, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 21);
            this.label9.TabIndex = 53;
            this.label9.Text = "Movie Picture";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 44);
            this.label8.TabIndex = 52;
            this.label8.Text = "Genres:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Length
            // 
            this.Length.BorderColor = System.Drawing.Color.Gray;
            this.Length.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Length.DefaultText = "";
            this.Length.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Length.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Length.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Length.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Length.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Length.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Length.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Length.Location = new System.Drawing.Point(663, 253);
            this.Length.Name = "Length";
            this.Length.PasswordChar = '\0';
            this.Length.PlaceholderText = "";
            this.Length.SelectedText = "";
            this.Length.Size = new System.Drawing.Size(200, 43);
            this.Length.TabIndex = 51;
            // 
            // AgeRate
            // 
            this.AgeRate.BorderColor = System.Drawing.Color.Gray;
            this.AgeRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeRate.DefaultText = "";
            this.AgeRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AgeRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AgeRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AgeRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeRate.Location = new System.Drawing.Point(663, 178);
            this.AgeRate.Name = "AgeRate";
            this.AgeRate.PasswordChar = '\0';
            this.AgeRate.PlaceholderText = "";
            this.AgeRate.SelectedText = "";
            this.AgeRate.Size = new System.Drawing.Size(200, 43);
            this.AgeRate.TabIndex = 50;
            // 
            // MovieName
            // 
            this.MovieName.BorderColor = System.Drawing.Color.Gray;
            this.MovieName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MovieName.DefaultText = "";
            this.MovieName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MovieName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MovieName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MovieName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MovieName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MovieName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MovieName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MovieName.Location = new System.Drawing.Point(154, 178);
            this.MovieName.Name = "MovieName";
            this.MovieName.PasswordChar = '\0';
            this.MovieName.PlaceholderText = "";
            this.MovieName.SelectedText = "";
            this.MovieName.Size = new System.Drawing.Size(340, 43);
            this.MovieName.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 39);
            this.label7.TabIndex = 47;
            this.label7.Text = "Show Times:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 43);
            this.label6.TabIndex = 46;
            this.label6.Text = "Realese Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 43);
            this.label5.TabIndex = 45;
            this.label5.Text = "IMDb Rating:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 43);
            this.label4.TabIndex = 44;
            this.label4.Text = "Description:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 43);
            this.label3.TabIndex = 43;
            this.label3.Text = "Length:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 43);
            this.label2.TabIndex = 42;
            this.label2.Text = "Age Rating:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 43);
            this.label1.TabIndex = 41;
            this.label1.Text = "Movie Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 2;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Brown;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(1118, 654);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(136, 54);
            this.guna2GradientButton2.TabIndex = 66;
            this.guna2GradientButton2.Text = "Add The Movie";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(949, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // AddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.imdbRate);
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.GenresList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DaysList);
            this.Controls.Add(this.HoursList);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.AgeRate);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMoview";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label imdbRate;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.CheckedListBox GenresList;
        private System.Windows.Forms.CheckedListBox DaysList;
        private System.Windows.Forms.CheckedListBox HoursList;
        private System.Windows.Forms.RichTextBox Description;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox Length;
        private Guna.UI2.WinForms.Guna2TextBox AgeRate;
        private Guna.UI2.WinForms.Guna2TextBox MovieName;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        public System.Windows.Forms.Label label9;
    }
}