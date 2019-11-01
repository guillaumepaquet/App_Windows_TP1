using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceDeJeu.Presenter;
using InterfaceDeJeu.View;

namespace InterfaceDeJeu
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainView aMainView = new MainView();
            MainViewPresenter aMainViewPresenter = new MainViewPresenter(aMainView);
            Application.Run(aMainView);
        }
    }
}
