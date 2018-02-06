using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BatchCopyCore
{
   public class Common
    {

        public static bool DirExists(string path)
        {
            return Directory.Exists(path);

        }
    }
}
