using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBoxPass.BackColor = SystemColors.Control;
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBoxUser.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void buttonExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
