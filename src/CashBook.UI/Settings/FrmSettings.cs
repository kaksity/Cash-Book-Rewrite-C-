using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Dtos.User;
using CashBook.Services.User;
using CashBook.UI.Utilities;

namespace CashBook.UI.Settings
{
    public partial class FrmSettings : Form
    {
        private readonly IUserService _userService;
        public FrmSettings(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void LoadUserData()
        {
            var user = _userService.GetUserByUserId(Program.userId);
            ToForm(user);
        }
        private void ToForm(ReadUserDto user)
        {
            lblUsername.Text = user.UserName;
            txtOrganizationName.Text = user.OrganizationName;
            txtFullName.Text = user.FullName;
            txtTelephoneNumber.Text = user.TelePhoneNumber;
            txtEmailAddress.Text = user.EmailAddress;
            txtSecurityQuestion.Text = user.SecurityQuestion;
            txtSecurityAnswer.Text = user.SecurityAnswer;
        }

        private void Enable()
        {
            lblUsername.Enabled = true;
            txtOrganizationName.Enabled = true;
            txtFullName.Enabled = true;
            txtTelephoneNumber.Enabled = true;
            txtEmailAddress.Enabled = true;
            txtSecurityQuestion.Enabled = true;
            txtSecurityAnswer.Enabled = true;
            txtPassword.Enabled = true;

            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnAddPhoto.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void Disable()
        {
            lblUsername.Enabled = false;
            txtOrganizationName.Enabled = false;
            txtFullName.Enabled = false;
            txtTelephoneNumber.Enabled = false;
            txtEmailAddress.Enabled = false;
            txtSecurityQuestion.Enabled = false;
            txtSecurityAnswer.Enabled = false;
            txtPassword.Enabled = false;

            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnAddPhoto.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable();
        }
        private void Reset()
        {
            Clear();
            LoadUserData();
            Disable();
        }
        private void Clear()
        {
            lblUsername.Text = "";
            txtOrganizationName.Text = "";
            txtFullName.Text = "";
            txtTelephoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtSecurityQuestion.Text = "";
            txtSecurityAnswer.Text = "";
            txtPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "" && txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be 8 or more characters",Software.GetApplicationName());
                return;
            }
            var updateUser = new UpdateUserDto 
            {
                UserId = Program.userId,
                OrganizationName = txtOrganizationName.Text.ToUpper(),
                UserName = lblUsername.Text,
                FullName = txtFullName.Text.ToUpper(),
                TelePhoneNumber = txtTelephoneNumber.Text.ToUpper(),
                EmailAddress = txtEmailAddress.Text.ToLower(),
                SecurityQuestion = txtSecurityQuestion.Text.ToUpper(),
                SecurityAnswer = txtSecurityAnswer.Text.ToUpper(),
                UserPassword = txtPassword.Text
            };
                _userService.UpdateUser(updateUser);
            MessageBox.Show("Setting was updated successfully", Software.GetApplicationName());
            Reset();
        }
    }
}
