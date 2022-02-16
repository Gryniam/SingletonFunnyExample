using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Televisor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static string wanted_path = Application.StartupPath;
        public static string pathToFotos = wanted_path + "\\Fotos\\";
        public static string pathToErrorPhoto = pathToFotos + "No image.png";
        public static string blackScreen = pathToFotos + "Black.jpg";
    }
}
