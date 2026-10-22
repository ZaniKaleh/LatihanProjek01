using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LatihanProjek01
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 haha = new Form1();
            haha.Show();
            this.Hide();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidasiPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignAp_Click(object sender, EventArgs e)
        {
            if (Password == ValidasiPass)
            {
                Menu waka = new Menu();
                waka.Show();
                this.Hide();
            }
            else
            {
                GkValid.Visible=true;
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidasiPass.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void ValidasiPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignAp.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
