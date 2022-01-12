using CashBook.Dtos.User;
using CashBook.Services.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.UI.Utilities;

namespace CashBook.UI.Authentication
{
    public partial class FrmRegisterNewUser : Form
    {
        private readonly IUserService _userService;
        public FrmRegisterNewUser(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) == true)
            {
                MessageBox.Show("Username is required", Software.GetApplicationName());
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtOrganizationName.Text) == true)
            {
                MessageBox.Show("Organization Name is required", Software.GetApplicationName());
                txtOrganizationName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text) == true)
            {
                MessageBox.Show("Full Name is required", Software.GetApplicationName());
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSecurityQuestion.Text) == true)
            {
                MessageBox.Show("Security Question is required", Software.GetApplicationName());
                txtSecurityQuestion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSecurityAnswer.Text) == true)
            {
                MessageBox.Show("Security Answer is required", Software.GetApplicationName());
                txtSecurityAnswer.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) == true)
            {
                MessageBox.Show("Password is required", Software.GetApplicationName());
                txtPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text) == true)
            {
                MessageBox.Show("Confirm Password is required", Software.GetApplicationName());
                txtConfirmPassword.Focus();
                return;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Length must be 8 or more characters", Software.GetApplicationName());
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password Must Match Confirm Password", Software.GetApplicationName());
                txtConfirmPassword.Focus();
                return;
            }

            //Create a New User Dto
            var newUserDto = new CreateUserDto
            {
                UserName = txtUsername.Text,
                OrganizationName = txtOrganizationName.Text.ToUpper(),
                UserPassword = txtPassword.Text,
                FullName = txtFullName.Text,
                TelePhoneNumber = txtTelephoneNumber.Text,
                EmailAddress = txtEmailAddress.Text,
                SecurityQuestion = txtSecurityQuestion.Text,
                SecurityAnswer = txtSecurityAnswer.Text,
            };

            _userService.CreateNewUser(newUserDto);
            MessageBox.Show("Thank you for using Swift Accounts. User account was created successfully", Software.GetApplicationName());
            this.Hide();
            var frmLogin = Program.container.GetInstance<FrmLogin>();
            frmLogin.ShowDialog();
        }

        private void FrmRegisterNewUser_Load(object sender, EventArgs e)
        {

        }

        private void FrmRegisterNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
