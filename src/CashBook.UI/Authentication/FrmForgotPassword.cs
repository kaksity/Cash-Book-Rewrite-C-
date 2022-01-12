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
    public partial class FrmForgotPassword : Form
    {
        private IUserService _userService;
        private ReadUserDto userReadDto = null;
        public FrmForgotPassword(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void FrmForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckUsername_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) == true)
            {
                MessageBox.Show("Username is required", Software.GetApplicationName());
                txtUsername.Focus();
                return;
            }

             userReadDto = _userService.GetUserByUsername(txtUsername.Text);

            if (userReadDto == null)
            {
                MessageBox.Show("Username does not exist", Software.GetApplicationName());
                txtUsername.Focus();
                return;
            }
            txtSecurityQuestion.Text = userReadDto.SecurityQuestion;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) == true )
            {
                MessageBox.Show("Username is required",Software.GetApplicationName());
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSecurityQuestion.Text) == true )
            {
                MessageBox.Show("Click on Check Username", Software.GetApplicationName());
                txtSecurityQuestion.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSecurityAnswer.Text) == true )
            {
                MessageBox.Show("Security Answer is required", Software.GetApplicationName());
                txtSecurityAnswer.Focus();
                return;
            }

            if (txtSecurityAnswer.Text.ToUpper().Trim() != userReadDto.SecurityAnswer)
            {
                MessageBox.Show("Security Answer given is not correct", Software.GetApplicationName());
                txtSecurityAnswer.Focus();
                return;
            }

            var newPassword = GenerateNewRandomPassword();
            var updateUser = new UpdateUserDto
            {
                UserId = userReadDto.UserId,
                OrganizationName = userReadDto.OrganizationName,
                FullName = userReadDto.FullName,
                UserName = userReadDto.UserName,
                UserPassword = newPassword,
                EmailAddress = userReadDto.EmailAddress,
                TelePhoneNumber = userReadDto.TelePhoneNumber,
                SecurityQuestion = userReadDto.SecurityQuestion,
                IsDeleted = userReadDto.IsDeleted,
                SecurityAnswer = userReadDto.SecurityAnswer
            };

            _userService.UpdateUser(updateUser);
            MessageBox.Show($"New random password is {newPassword}");
        }
        private string GenerateNewRandomPassword()
        {
            var randomNumber = new Random();
            return randomNumber.Next(11111111, 99999999).ToString();
        }
    }
}
