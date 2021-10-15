using CashBook.DataAccess.Account;
using CashBook.Services.Account;
using CashBook.UI.Account;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CashBook.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Container container;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            container = Bootstrap();

            Application.Run(container.GetInstance<FrmAccount>());
        }

        private static Container Bootstrap()
        {
            // Create the container as usual.
            var container = new Container();

            container.Register<IAccountService,AccountService>();
            container.Register<IAccountRepository, AccountRepository>();
            
            AutoRegisterWindowsForms(container);

            container.Verify();

            return container;
        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Transient.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }
    }
}
