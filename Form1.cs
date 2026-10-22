namespace LatihanProjek01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LihatPass_CheckedChanged(object sender, EventArgs e)
        {
            if (LihatPass.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "Ambatublow" && Password.Text == "CumBucket")
            {
                Menu suki = new Menu();
                suki.Show();
                this.Hide();
            }
            else
            {
                GkValid.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignIn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp Suka = new SignUp();
            Suka.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}