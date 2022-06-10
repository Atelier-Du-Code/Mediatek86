using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediatek86.controleur;
using Mediatek86.vue;


namespace Mediatek86
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

            
            int lesDroits = authentification();

            if (lesDroits>0)
            {
                new Controle(lesDroits);
            }
        }

        static int authentification()
        {
            ControleurAuth monAuthentification = new ControleurAuth();
            return monAuthentification.lesDroits;
        }
    }
}
