
namespace CinemaProject
{
    partial class EditSnacksMenu
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
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Size = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteRBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.AddRBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.EditRBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.PopCornSize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.price = new System.Windows.Forms.MaskedTextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 30;
            this.listBox3.Items.AddRange(new object[] {
            "ID"});
            this.listBox3.Location = new System.Drawing.Point(412, 211);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(40, 242);
            this.listBox3.TabIndex = 49;
            this.listBox3.Visible = false;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(30, 241);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(381, 1);
            this.guna2Separator1.TabIndex = 46;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 30;
            this.listBox2.Items.AddRange(new object[] {
            "Price"});
            this.listBox2.Location = new System.Drawing.Point(329, 211);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(84, 242);
            this.listBox2.TabIndex = 48;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Items.AddRange(new object[] {
            "Item"});
            this.listBox1.Location = new System.Drawing.Point(29, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 242);
            this.listBox1.TabIndex = 47;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.BorderColor = System.Drawing.Color.Gray;
            this.Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.FocusedColor = System.Drawing.Color.Black;
            this.Category.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.Category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Category.ItemHeight = 30;
            this.Category.Items.AddRange(new object[] {
            "Drinks",
            "PopCorn",
            "Snacks"});
            this.Category.Location = new System.Drawing.Point(187, 142);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(200, 36);
            this.Category.TabIndex = 44;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 7;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(479, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Enter The Product Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(535, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 52;
            this.label2.Text = "Enter The Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(479, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 31);
            this.label5.TabIndex = 53;
            this.label5.Text = "Enter The Product Size:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PName
            // 
            this.PName.BorderColor = System.Drawing.Color.Gray;
            this.PName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PName.DefaultText = "";
            this.PName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PName.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.PName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PName.Location = new System.Drawing.Point(693, 265);
            this.PName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PName.Name = "PName";
            this.PName.PasswordChar = '\0';
            this.PName.PlaceholderText = "";
            this.PName.SelectedText = "";
            this.PName.Size = new System.Drawing.Size(200, 33);
            this.PName.TabIndex = 54;
            // 
            // Size
            // 
            this.Size.BorderColor = System.Drawing.Color.Gray;
            this.Size.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Size.DefaultText = "";
            this.Size.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Size.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Size.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Size.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Size.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.Size.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Size.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Size.Location = new System.Drawing.Point(693, 328);
            this.Size.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Size.Name = "Size";
            this.Size.PasswordChar = '\0';
            this.Size.PlaceholderText = "";
            this.Size.SelectedText = "";
            this.Size.Size = new System.Drawing.Size(200, 33);
            this.Size.TabIndex = 56;
            // 
            // DeleteRBtn
            // 
            this.DeleteRBtn.AutoSize = true;
            this.DeleteRBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteRBtn.CheckedState.BorderThickness = 0;
            this.DeleteRBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteRBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DeleteRBtn.CheckedState.InnerOffset = -4;
            this.DeleteRBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteRBtn.Location = new System.Drawing.Point(787, 188);
            this.DeleteRBtn.Name = "DeleteRBtn";
            this.DeleteRBtn.Size = new System.Drawing.Size(81, 25);
            this.DeleteRBtn.TabIndex = 57;
            this.DeleteRBtn.Text = "DELETE";
            this.DeleteRBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DeleteRBtn.UncheckedState.BorderThickness = 1;
            this.DeleteRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DeleteRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // AddRBtn
            // 
            this.AddRBtn.AutoSize = true;
            this.AddRBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddRBtn.CheckedState.BorderThickness = 0;
            this.AddRBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddRBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AddRBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AddRBtn.Location = new System.Drawing.Point(530, 188);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(63, 25);
            this.AddRBtn.TabIndex = 58;
            this.AddRBtn.Text = "ADD";
            this.AddRBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AddRBtn.UncheckedState.BorderThickness = 1;
            this.AddRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.AddRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // EditRBtn
            // 
            this.EditRBtn.AutoSize = true;
            this.EditRBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditRBtn.CheckedState.BorderThickness = 0;
            this.EditRBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditRBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.EditRBtn.CheckedState.InnerOffset = -4;
            this.EditRBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EditRBtn.Location = new System.Drawing.Point(669, 188);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(62, 25);
            this.EditRBtn.TabIndex = 59;
            this.EditRBtn.Text = "EDIT";
            this.EditRBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EditRBtn.UncheckedState.BorderThickness = 1;
            this.EditRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.EditRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(463, 45);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(11, 528);
            this.guna2VSeparator1.TabIndex = 60;
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.Maroon;
            this.guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.Tomato;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(811, 480);
            this.guna2GradientCircleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(120, 65);
            this.guna2GradientCircleButton1.TabIndex = 61;
            this.guna2GradientCircleButton1.Text = "Save";
            this.guna2GradientCircleButton1.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 31);
            this.label6.TabIndex = 62;
            this.label6.Text = "Category Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 5;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(12, 48);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(113, 47);
            this.guna2GradientButton3.TabIndex = 63;
            this.guna2GradientButton3.Text = "Back To Main Menu";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(508, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 48);
            this.label3.TabIndex = 64;
            this.label3.Text = "Note:- Please!! For Edit the Menu Or delete something, Select An Item From The Li" +
    "st left side!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopCornSize
            // 
            this.PopCornSize.BackColor = System.Drawing.Color.Transparent;
            this.PopCornSize.BorderColor = System.Drawing.Color.Gray;
            this.PopCornSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PopCornSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PopCornSize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PopCornSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PopCornSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopCornSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PopCornSize.ItemHeight = 30;
            this.PopCornSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "XLarge"});
            this.PopCornSize.Location = new System.Drawing.Point(693, 329);
            this.PopCornSize.Name = "PopCornSize";
            this.PopCornSize.Size = new System.Drawing.Size(200, 36);
            this.PopCornSize.TabIndex = 65;
            this.PopCornSize.Visible = false;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.HidePromptOnLeave = true;
            this.price.Location = new System.Drawing.Point(693, 395);
            this.price.Mask = "0000";
            this.price.Name = "price";
            this.price.ResetOnSpace = false;
            this.price.Size = new System.Drawing.Size(200, 33);
            this.price.TabIndex = 66;
            this.price.ValidatingType = typeof(int);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.OrangeRed;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(942, 42);
            this.guna2CustomGradientPanel1.TabIndex = 80;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(888, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2ControlBox1.Size = new System.Drawing.Size(54, 42);
            this.guna2ControlBox1.TabIndex = 87;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // EditSnacksMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 556);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.PopCornSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.EditRBtn);
            this.Controls.Add(this.AddRBtn);
            this.Controls.Add(this.DeleteRBtn);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Category);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditSnacksMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSnacksMenu";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2ComboBox Category;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox Size;
        private Guna.UI2.WinForms.Guna2TextBox PName;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2RadioButton EditRBtn;
        public Guna.UI2.WinForms.Guna2RadioButton AddRBtn;
        public Guna.UI2.WinForms.Guna2RadioButton DeleteRBtn;
        public Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        public System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        public System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox PopCornSize;
        private System.Windows.Forms.MaskedTextBox price;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}