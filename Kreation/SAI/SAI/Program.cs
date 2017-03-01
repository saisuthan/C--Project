using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAI.Branch.Borrella;
using SAI.Branch.Bamba;
using SAI.Branch.Wattala;

namespace SAI
{
    static class Program
    {
        ///// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new POS(""));
        }
    }
}
