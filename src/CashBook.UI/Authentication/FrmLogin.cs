﻿using CashBook.Services.User;
using CashBook.UI.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBook.UI.Authentication
{
    public partial class FrmLogin : Form
    {
        private readonly IUserService _userService;
        public FrmLogin(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) == true)
            {
                MessageBox.Show("Username is required","Cash Book");
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) == true)
            {
                MessageBox.Show("Password is required", "Cash Book");
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text.Length < 8 )
            {
                MessageBox.Show("Invalid Login Credentials", "Cash Book");
                txtUsername.Focus();
                return;
            }

            var userReadDto = _userService.GetUserByUsername(txtUsername.Text);

            if (userReadDto == null)
            {
                MessageBox.Show("Invalid Login Credentials", "Cash Book");
                txtUsername.Focus();
                return;
            }

            if (userReadDto.UserPassword != txtPassword.Text)
            {
                MessageBox.Show("Invalid Login Credentials", "Cash Book");
                txtUsername.Focus();
                return;
            }

            // Get the Main Menu Form from the DI Container and then display the Main Menu
            var mainMenuForm = Program.container.GetInstance<FrmMainMenu>();
            this.Hide();
            mainMenuForm.ShowDialog();
        }
    }
}
