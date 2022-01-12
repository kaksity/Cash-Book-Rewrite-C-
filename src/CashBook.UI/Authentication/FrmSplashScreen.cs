using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Services.User;

namespace CashBook.UI.Authentication
{
    public partial class FrmSplashScreen : Form
    {
        private readonly IUserService _userService;
        public FrmSplashScreen(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {

            // Start a timer 
            timer.Interval = 5000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            this.Hide();
            if (_userService.AnyUserExist() == false)
            {
                var frmRegiserNewUser = Program.container.GetInstance<FrmRegisterNewUser>();
                frmRegiserNewUser.ShowDialog();
            }
            else
            {
                var frmLogin = Program.container.GetInstance<FrmLogin>();
                frmLogin.ShowDialog();
            }
        }
    }
}
