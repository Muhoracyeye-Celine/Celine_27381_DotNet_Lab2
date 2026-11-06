using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            Hide();
            using (ChooseForm chooseForm = new ChooseForm())
            {
                chooseForm.ShowDialog(this);
            }

            if (!IsDisposed && !Disposing)
            {
                txtPassword.Clear();
                Show();
                txtPassword.Focus();
            }
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
