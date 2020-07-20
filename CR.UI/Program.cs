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

            Application.Run(_con.GetInstance<frmMain>());
        }   

        public static void ServicesInjection()
        {
            _con = new Container();
            _con.Register<ILoginServices, LoginServices>();
            _con.Register<ICoinServices, CoinServices>();
            _con.Register<ICashRegisterServices, CashRegisterServices>();

            _con.Verify();
        }

    }
}
