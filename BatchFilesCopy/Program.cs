using BatchFilesCopy.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchCopyCore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Help.HelpTexts.Add("Preview", "This will validate and generate preview of files to be copied.");
            Help.HelpTexts.Add("SearchPattern", "Please enter pattern like * for all files (default) or .txt to search only text files in source folder.");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BatchCopyFiles());

        }
    }
}
