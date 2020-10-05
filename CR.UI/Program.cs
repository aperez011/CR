using CR.Services;
using CR.UI.Login;
using CR.Utilities.Infraestructure;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace CR.UI
{
    static class Program
    {

        private static Container _con;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ServicesInjection();

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            Application.Run(_con.GetInstance<frmMain>());
        }   

        public static void ServicesInjection()
        {
            _con = new Container();
            _con.Register<ILoginServices, LoginServices>();
            _con.Register<ICoinServices, CoinServices>();
            _con.Register<ICashRegisterServices, CashRegisterServices>();
            _con.Register<ICashExpenseServices, CashExpenseServices>();
            _con.Register<IReportServices, ReportServices>();
            _con.Register<IExpenseTypesServices, ExpenseTypeServices>();

            _con.Verify();
        }

    }
}
