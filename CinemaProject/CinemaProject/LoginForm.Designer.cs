
namespace CinemaProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Unamelbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.EnterBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.ShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.White;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Unamelbl
            // 
            this.Unamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Unamelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unamelbl.ForeColor = System.Drawing.Color.White;
            this.Unamelbl.Location = new System.Drawing.Point(46, 131);
            this.Unamelbl.Name = "Unamelbl";
            this.Unamelbl.Size = new System.Drawing.Size(102, 27);
            this.Unamelbl.TabIndex = 2;
            this.Unamelbl.Text = "User Name:";
            this.Unamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Passlbl
            // 
            this.Passlbl.BackColor = System.Drawing.Color.Transparent;
            this.Passlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlbl.ForeColor = System.Drawing.Color.White;
            this.Passlbl.Location = new System.Drawing.Point(49, 182);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(98, 27);
            this.Passlbl.TabIndex = 3;
            this.Passlbl.Text = "Password:";
            this.Passlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.Color.Red;
            this.ExitBtn.FillColor2 = System.Drawing.Color.DarkRed;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(112, 258);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.Size = new System.Drawing.Size(118, 59);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.guna2GradientCircleButton2_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.Transparent;
            this.EnterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EnterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EnterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EnterBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EnterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EnterBtn.FillColor = System.Drawing.Color.Maroon;
            this.EnterBtn.FillColor2 = System.Drawing.Color.Tomato;
            this.EnterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBtn.ForeColor = System.Drawing.Color.White;
            this.EnterBtn.Location = new System.Drawing.Point(270, 258);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EnterBtn.Size = new System.Drawing.Size(118, 59);
            this.EnterBtn.TabIndex = 2;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.ShowPass.CheckedState.BorderColor = System.Drawing.Color.White;
            this.ShowPass.CheckedState.BorderRadius = 0;
            this.ShowPass.CheckedState.BorderThickness = 0;
            this.ShowPass.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.ShowPass.Location = new System.Drawing.Point(152, 217);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(102, 17);
            this.ShowPass.TabIndex = 9;
            this.ShowPass.Text = "Show Password";
            this.ShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPass.UncheckedState.BorderRadius = 0;
            this.ShowPass.UncheckedState.BorderThickness = 0;
            this.ShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPass.UseVisualStyleBackColor = false;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.IndianRed;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(33, 69);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(165, 47);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Enter Customer Mode";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(152, 132);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(220, 29);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(152, 183);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(220, 29);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = global::CinemaProject.Properties.Resources._12_21_2022_4_00_19_AM_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 351);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.Unamelbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.TransparencyKey = System.Drawing.Color.OrangeRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2CheckBox ShowPass;
        public Guna.UI2.WinForms.Guna2GradientCircleButton EnterBtn;
        public Guna.UI2.WinForms.Guna2GradientCircleButton ExitBtn;
        public System.Windows.Forms.Label Passlbl;
        public System.Windows.Forms.Label Unamelbl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.TextBox username;
        public System.Windows.Forms.TextBox password;
    }
}