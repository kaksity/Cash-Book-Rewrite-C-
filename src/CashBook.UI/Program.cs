using CashBook.DataAccess.Account;
using CashBook.DataAccess.BankReconcilation;
using CashBook.DataAccess.MaintainBalance;
using CashBook.DataAccess.Transaction;
using CashBook.DataAccess.TransactionDescription;
using CashBook.DataAccess.User;
using CashBook.Services.Account;
using CashBook.Services.BankReconcilation;
using CashBook.Services.MaintainBalance;
using CashBook.Services.Transaction;
using CashBook.Services.TransactionDescription;
using CashBook.Services.User;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using System;
using System.Windows.Forms;
using CashBook.Services.Utility;
using CashBook.Services.Reports;
using CashBook.DataAccess.Reports;
using CashBook.Services.Reports.BankReconcilations;
using CashBook.DataAccess.Reports.BankReconcilations;
using CashBook.DataAccess.Reports.TransactionDescriptions;
using CashBook.Services.Reports.TransactionDescriptions;
using CashBook.DataAccess.Reports.Accounts;
using CashBook.Services.Reports.Accounts;
using CashBook.UI.Authentication;
using CashBook.DataAccess.BinCardItem;
using CashBook.Services.BinCardItem;
using CashBook.DataAccess.BinCard;
using CashBook.Services.BinCard;
using CashBook.DataAccess.Reports.BinCards;
using CashBook.Services.Reports.BinCards;
using CashBook.UI.MainMenu;
using CashBook.DataAccess.Debtor;
using CashBook.Services.Debtor;
using CashBook.DataAccess.DebtorLedger;
using CashBook.UI.DebtorLedger;
using CashBook.Services.DebtorLedger;
using CashBook.DataAccess.Reports.DebtorLedger;
using CashBook.Services.Reports.DebtorLedgers;
using CashBook.DataAccess.DataRecovery;
using CashBook.Services.DataRecovery;

namespace CashBook.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Container container;
        public static string accountId;
        public static string debtorId;
        public static string binCardItemId;
        public static string userId = "49fdbfcb-15b0-444a-ad0b-9f86c0909d27";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            container = Bootstrap();

            Application.Run(container.GetInstance<FrmSplashScreen>());
        }

        private static Container Bootstrap()
        {
            // Create the container as usual.
            var container = new Container();

            container.Register<IAccountService,AccountService>();
            container.Register<IAccountRepository, AccountRepository>();
            container.Register<IMaintainBalanceRepository, MaintainBalanceRepository>();
            container.Register<IMaintainBalanceService, MaintainBalanceService>();
            container.Register<ITransactionDescriptionRepository, TransactionDescriptionRepository>();
            container.Register<ITransactionDescriptionService, TransactionDescriptionService>();
            container.Register<ITransactionRepository,TransactionRepository>();
            container.Register<ITransactionService, TransactionService>();
            container.Register<IBankReconcilationRepository, BankReconcilationRepository>();
            container.Register<IBankReconcilationService, BankReconcilationService>();
            container.Register<IUserRepository, UserRepository>();
            container.Register<IUserService, UserService>();
            container.Register<IUtilityService,UtilityService>();
            container.Register<ITransactionReportRepository, TransactionReportRepository>();
            container.Register<ITransactionReportService, TransactionReportService>();
            container.Register<IBankReconcilationReportService, BankReconcilationReportService>();
            container.Register<IBankReconcilationReportRepository, BankReconcilationReportRepository>();
            container.Register<ITransactionDescriptionReportRepository, TransactionDescriptionReportRepository>();
            container.Register<ITransactionDescriptionReportService, TransactionDescriptionReportService>();
            container.Register<IAccountReportRepository,AccountReportRepository>();
            container.Register<IAccountReportService, AccountReportService>();
            container.Register<IBinCardItemRepository, BinCardItemRepository>();
            container.Register<IBinCardItemService, BinCardItemService>();
            container.Register<IBinCardRepository, BinCardRepository>();
            container.Register<IBinCardService, BinCardService>();
            container.Register<IBinCardReportRepository, BinCardReportRepository>();
            container.Register<IBinCardReportService, BinCardReportService>();
            container.Register<IDebtorRepository, DebtorRepository>();
            container.Register<IDebtorService, DebtorService>();
            container.Register<IDebtorLedgerRepository, DebtorLedgerRepository>();
            container.Register<IDebtorLedgerService, DebtorLedgerService>();
            container.Register<IDebtorLedgerReportRepository, DebtorLedgerReportRepository>();
            container.Register<IDebtorLedgerReportService, DebtorLedgerReportService>();
            container.Register<IDataRecoveryRepository, DataRecoveryRepository>();
            container.Register<IDataRecoveryService, DataRecoveryService>();
            AutoRegisterWindowsForms(container);

            container.Verify();

            return container;
        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration = Lifestyle.Transient.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }
    }
}
