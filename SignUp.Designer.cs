namespace LatihanProjek01
{
    partial class SignUp
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
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            Username = new TextBox();
            TitleSignUp = new Label();
            Password = new TextBox();
            SignAp = new Button();
            ValidasiPass = new TextBox();
            GkValid = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(768, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 624);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Yellow;
            linkLabel1.Location = new Point(3, 458);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(67, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Masuk";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 433);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 4;
            label2.Text = "Sudah punya akun?";
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightYellow;
            label1.Location = new Point(47, 105);
            label1.Name = "label1";
            label1.Size = new Size(198, 59);
            label1.TabIndex = 0;
            label1.Text = "DAFTAR KE SMK MART";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.FixedSingle;
            Username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(196, 208);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(288, 35);
            Username.TabIndex = 1;
            Username.TextChanged += Username_TextChanged;
            Username.KeyDown += Username_KeyDown;
            // 
            // TitleSignUp
            // 
            TitleSignUp.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleSignUp.ForeColor = Color.CadetBlue;
            TitleSignUp.ImageAlign = ContentAlignment.MiddleLeft;
            TitleSignUp.Location = new Point(38, 36);
            TitleSignUp.Name = "TitleSignUp";
            TitleSignUp.Size = new Size(165, 50);
            TitleSignUp.TabIndex = 4;
            TitleSignUp.Text = "Sign Up";
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(196, 281);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(288, 35);
            Password.TabIndex = 5;
            Password.UseSystemPasswordChar = true;
            Password.KeyDown += Password_KeyDown;
            // 
            // SignAp
            // 
            SignAp.BackColor = Color.GreenYellow;
            SignAp.BackgroundImageLayout = ImageLayout.None;
            SignAp.FlatStyle = FlatStyle.Popup;
            SignAp.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignAp.Location = new Point(297, 416);
            SignAp.Name = "SignAp";
            SignAp.Size = new Size(75, 30);
            SignAp.TabIndex = 6;
            SignAp.Text = "SIGN UP";
            SignAp.UseVisualStyleBackColor = false;
            SignAp.Click += SignAp_Click;
            // 
            // ValidasiPass
            // 
            ValidasiPass.BorderStyle = BorderStyle.FixedSingle;
            ValidasiPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidasiPass.Location = new Point(196, 346);
            ValidasiPass.Name = "ValidasiPass";
            ValidasiPass.PlaceholderText = "Masukkan Passwordmu lagi";
            ValidasiPass.Size = new Size(288, 35);
            ValidasiPass.TabIndex = 7;
            ValidasiPass.UseSystemPasswordChar = true;
            ValidasiPass.TextChanged += ValidasiPass_TextChanged;
            ValidasiPass.KeyDown += ValidasiPass_KeyDown;
            // 
            // GkValid
            // 
            GkValid.ForeColor = Color.Red;
            GkValid.Location = new Point(196, 384);
            GkValid.Name = "GkValid";
            GkValid.Size = new Size(288, 15);
            GkValid.TabIndex = 8;
            GkValid.Text = "Password dan Validasi Password harus sama!";
            GkValid.Visible = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 624);
            Controls.Add(GkValid);
            Controls.Add(ValidasiPass);
            Controls.Add(SignAp);
            Controls.Add(Password);
            Controls.Add(TitleSignUp);
            Controls.Add(Username);
            Controls.Add(panel1);
            Name = "SignUp";
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox Username;
        private Label TitleSignUp;
        private TextBox Password;
        private Button SignAp;
        private TextBox ValidasiPass;
        private Label GkValid;
    }
}