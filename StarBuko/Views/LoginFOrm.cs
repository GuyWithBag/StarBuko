using StarBuko.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StarBuko.Views
{
    public partial class LoginForm : Form, ILoginForm
    {
        private LoginPresenter _presenter;

        public LoginForm()
        {
            _presenter = new LoginPresenter(this); 
            InitializeComponent();
        }

        public event EventHandler<(string username, string password)> OnLoginAttempt;

        public string Username
        {
            get { return usernameTextBox.Text.Trim(); }
            set { usernameTextBox.Text = value; }
        }

        public string Password
        {
            get { return passwordTextBox.Text.Trim(); }
            set { passwordTextBox.Text = value; }
        }

        

        public void ShowLoginError(string message)
        {
            MessageBox.Show(message); 
        }

        private void LoginUser(object sender, EventArgs e)
        {
            OnLoginAttempt?.Invoke(this, (Username, Password));
        }

        public void LoginSuccessful()
        {
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }
    }
}
