using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BatchCopyCore
{
   public class xFile
    {
        public bool? IsPathAbsolute { get; set; }

        public string WorkingDirectoryPath { get; set; }

        private string _sourcePath;
        public string SourcePath
        {
            get
            {
                if (!IsPathAbsolute.Value)
                    return Path.Combine(WorkingDirectoryPath, _sourcePath);
                else
                    return _sourcePath;
            }
            set { _sourcePath = value; }
        }

        private string _destinationPath;
        public string DestinationPath {
            get
            {
                if (!IsPathAbsolute.Value)
                    return Path.Combine(WorkingDirectoryPath, _destinationPath);
                else
                    return _destinationPath;
            }
            set { _destinationPath = value; }
        }

        public string error { get; set; }




        // IsSrcPathValid()

        // IsDestPathValid()



    }
}
