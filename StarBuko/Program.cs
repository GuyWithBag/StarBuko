using StarBuko.Presenters;
using StarBuko.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarBuko
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        static public ProgramPresenter presenter = new ProgramPresenter(); 

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    presenter.currentUserName = loginForm.Username; 
                    Application.Run(new MainForm()); 
                }
            }
        }
    }
}
