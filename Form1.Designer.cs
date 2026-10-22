namespace LatihanProjek01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Username = new TextBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            Tekswelcome = new Label();
            TitleSignIn = new Label();
            Password = new TextBox();
            SignIn = new Button();
            LihatPass = new CheckBox();
            GkValid = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.FixedSingle;
            Username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(427, 219);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(288, 35);
            Username.TabIndex = 0;
            Username.TextChanged += Username_TextChanged;
            Username.KeyDown += Username_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Tekswelcome);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 628);
            panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Yellow;
            linkLabel1.Location = new Point(12, 515);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Buat";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 490);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 3;
            label1.Text = "Belum punya akun?";
            label1.Click += label1_Click_1;
            // 
            // Tekswelcome
            // 
            Tekswelcome.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tekswelcome.ForeColor = Color.Wheat;
            Tekswelcome.ImageAlign = ContentAlignment.MiddleLeft;
            Tekswelcome.Location = new Point(3, 116);
            Tekswelcome.Name = "Tekswelcome";
            Tekswelcome.Size = new Size(292, 76);
            Tekswelcome.TabIndex = 2;
            Tekswelcome.Text = "SELAMAT DATANG DI SMK MART";
            Tekswelcome.Click += label1_Click;
            // 
            // TitleSignIn
            // 
            TitleSignIn.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleSignIn.ForeColor = Color.DarkSlateGray;
            TitleSignIn.ImageAlign = ContentAlignment.MiddleLeft;
            TitleSignIn.Location = new Point(345, 69);
            TitleSignIn.Name = "TitleSignIn";
            TitleSignIn.Size = new Size(145, 50);
            TitleSignIn.TabIndex = 3;
            TitleSignIn.Text = "Sign In";
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(427, 299);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(288, 35);
            Password.TabIndex = 4;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            Password.KeyDown += Password_KeyDown;
            // 
            // SignIn
            // 
            SignIn.BackColor = Color.GreenYellow;
            SignIn.BackgroundImageLayout = ImageLayout.None;
            SignIn.FlatStyle = FlatStyle.Popup;
            SignIn.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignIn.Location = new Point(537, 372);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(75, 30);
            SignIn.TabIndex = 5;
            SignIn.Text = "SIGN IN";
            SignIn.UseVisualStyleBackColor = false;
            SignIn.Click += button1_Click;
            // 
            // LihatPass
            // 
            LihatPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LihatPass.Location = new Point(721, 299);
            LihatPass.Name = "LihatPass";
            LihatPass.Size = new Size(123, 35);
            LihatPass.TabIndex = 6;
            LihatPass.Text = "Lihat Password";
            LihatPass.UseVisualStyleBackColor = true;
            LihatPass.CheckedChanged += LihatPass_CheckedChanged;
            // 
            // GkValid
            // 
            GkValid.ForeColor = Color.Red;
            GkValid.Location = new Point(427, 337);
            GkValid.Name = "GkValid";
            GkValid.Size = new Size(228, 15);
            GkValid.TabIndex = 7;
            GkValid.Text = "Username atau Password anda tidak valid!";
            GkValid.Visible = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1045, 624);
            Controls.Add(GkValid);
            Controls.Add(LihatPass);
            Controls.Add(SignIn);
            Controls.Add(Password);
            Controls.Add(TitleSignIn);
            Controls.Add(panel1);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private Panel panel1;
        private Label Tekswelcome;
        private Label TitleSignIn;
        private TextBox Password;
        private Button SignIn;
        private CheckBox LihatPass;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label GkValid;
    }
}
