using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;

namespace WikiCrafteo
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path="";
            string []args = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            foreach (string item in args)
            {
                if(item.Contains("Backup.xml"))
                {
                    path = item;
                    break;
                }
            }

            Wiki wiki = Archivos.DeserializarXml(path);
            Application.Run(new frm_WikiCrafteo(wiki,path));
        }
    }
}
