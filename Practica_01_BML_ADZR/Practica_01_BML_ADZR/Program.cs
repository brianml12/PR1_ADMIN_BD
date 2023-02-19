using Practica_01_BML_ADZR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_01_BML_ADZR
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmProductosInventario());
            frmMenu frm = new frmMenu();
            frm.Show();
            Application.Run();
        }
    }
}
