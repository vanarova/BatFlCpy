using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchCopyCore
{
    public static class Help
    {
       

        private static int index;
        public static Dictionary<string, string> HelpTexts = new Dictionary<string, string>();


        private static string HelpTextFooter = 
            "Tips : Click play button for tips.," +
            "Step 1 : Choose a source folder / Or choose a CSv files list.," + 
            "Step 2 : Choose destination folder to copy all files.";


        public static string GetHelpText()
        {
            string[] tips = HelpTextFooter.Split(',');
            if (index == tips.Count())
                index = 0;
            string currentTip = tips[index];
            ++index;

            return currentTip;
        }
    }
}
