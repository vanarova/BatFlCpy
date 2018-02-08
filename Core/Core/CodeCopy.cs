using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using BatchCopyCore;
using NLog;

namespace BatchCopyCore.Core
{
    public class CodeCopy
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        ///////////////////////////////////////////////////////////////////////////////////////////////
        /*
         * Batch file copy helper methods
         */
        ///////////////////////////////////////////////////////////////////////////////////////////////
        private  List<string> _FilesList;
        private  List<string> _ResetFileList;

      

        public  List<string> GetOriginalFilesList()
        {
            return _ResetFileList;
        }
        //public static List<string> GetOrAdjustFilesList(string prefix, string postfix)
        //{
        //    _FilesList = new List<string>(_ResetFileList);
        //    for (int i = 0; i < _FilesList.Count; i++)
        //    {
        //        _FilesList[i] = prefix + _FilesList[i] + postfix;
        //    }
        //    return _FilesList;
        //}


        public  bool SimpleTextFileRead(string src, out string errorMessage)
        {
            bool success = true; ;
            errorMessage = string.Empty;
            _FilesList = new List<string>();
           
            //List<string> text = new List<string>();
            if (File.Exists(src))
            {
                using (TextReader tr = File.OpenText(src))
                {
                    while (true)
                    {
                        string text = tr.ReadLine();
                        if(!string.IsNullOrEmpty(text))
                        _FilesList.Add(text);
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                success = false;
                errorMessage = "source file doesnt exist";
                throw new FileNotFoundException();
            }
            _ResetFileList =  new  List<string>(_FilesList);
            return success;

        }

        

        //public static bool xCopyFilesInList(string src, string dest, out string errorMessage)
        //{
        //    bool success = true;
        //    errorMessage = string.Empty;
        //    string emsg;
        //    try
        //    {
        //        //SimpleTextFileRead(src, out emsg);
        //        List<string> destList = new List<string>();
        //        foreach (var item in _ResetFileList)
        //        {
        //            destList.Add(dest + item);
        //        }
        //        for (int i = 0; i < _ResetFileList.Count; i++)
        //        {
        //            xCopyFileAndCreateDirectoryStrc(_FilesList[i], destList[i], out emsg);
        //        }


        //        //foreach (var item in _FilesList)
        //        //{
        //        //    xCopyFileAndCreateDirectoryStrc(item, dest, out emsg);
        //        //}
        //    }
        //    catch (Exception e)
        //    {   
        //        success = false;
        //        errorMessage = e.Message;
        //    }

        //    return success;
        //}





        public  bool xCopyFileCabinet(xFileCabinet cabinet)
        {
            foreach (var box in cabinet.boxes)
            {
                xCopyFileBox(box);
            }
            return true; 
        }



        public  bool xCopyFileBox(xFileBox box)
        {
            foreach (var file in box.Files)
            {
                if (!xCopyFileAndCreateDirectoryStrc(file) && box.AbortOnError)
                    return false;
            }
            return true;
        }





        public  bool xCopyFileAndCreateDirectoryStrc(xFile file)
        {
            
            bool success = true; ;
            if(File.Exists(file.SourcePath))
            {
                DirectoryInfo srcDirInfo = new DirectoryInfo(file.SourcePath);
                FileInfo destFileInfo = new FileInfo(file.DestinationPath);            

                if (Directory.Exists(destFileInfo.Directory.FullName))
                {
                    File.Copy(file.SourcePath, Path.Combine(destFileInfo.Directory.FullName, srcDirInfo.Name), true);
                }
                else
                {
                    Directory.CreateDirectory(destFileInfo.Directory.FullName);
                    File.Copy(file.SourcePath, Path.Combine(destFileInfo.Directory.FullName, srcDirInfo.Name),true);
                }
            }
            else
            {
                success = false;
                file.error = "source file doesnt exist";
                throw new FileNotFoundException();
            }
            return success;

        }



        internal bool GetPreviewFilesList(IOperationContainer ui, IProgressReport progress, System.Threading.CancellationToken ct)//, IProgress<IProgressReport> progressChanged, System.Threading.CancellationToken ct, IResult result)
        {
            var ipre = ui as IPreviewList;
            if (!(Directory.Exists(ipre.SourceFolderPath)))
                return false;
            int count = 0;
            DirectoryInfo srcDirInfo = new DirectoryInfo(ipre.SourceFolderPath);
            xFileCabinet cab = new xFileCabinet();
            var files = srcDirInfo.EnumerateFiles(ipre.SourceFileSearchPattern, ipre.PreviewSearchOption);
            foreach (var item in files)
            {
                if (ct.IsCancellationRequested)
                    return false;
                count++;
                //if(cab.files == null)
                //cab.files = new List<xFile>();
                //cab.files.Add(new xFile() { SourcePath = item.FullName, IsPathAbsolute = true });
                if (ipre.PreviewSrcList == null)
                    ipre.PreviewSrcList = new List<string>();
                ipre.PreviewSrcList.Add(item.FullName);
                progress.Count = count;
                progress.UnitProgressMessage = "files";
                progress.progressChanged.Report(progress);

            }
            //foreach (var item in srcDirInfo.EnumerateDirectories())
            //{
            //    cab.boxes.Add(new xFileBox());
            //}
            progress.result.Message = count.ToString();
            return true;
        }



        //.%%%%%%..%%%%%%...%%%%...%%%%%%..%%%%%%..%%%%%..........
        //...%%....%%......%%........%%....%%......%%..%%.........
        //...%%....%%%%.....%%%%.....%%....%%%%....%%..%%.........
        //...%%....%%..........%%....%%....%%......%%..%%.........
        //...%%....%%%%%%...%%%%.....%%....%%%%%%..%%%%%..........
        //........................................................                              


        public bool TryCopyFileAndCreateDirectoryStrc(
            string srcPath,
            string destPath,
            Action<long, string> fileDetails,
            bool IsInteractivelyCallBack,
            int callBackBufferSize,
            out bool IsSuccessful)
        {
            bool success = true; ;
            if (File.Exists(srcPath))
            {
                DirectoryInfo srcDirInfo = new DirectoryInfo(srcPath);
                FileInfo destFileInfo = new FileInfo(destPath);

                if (Directory.Exists(destFileInfo.Directory.FullName))
                {
                    File.Copy(srcPath, Path.Combine(destFileInfo.Directory.FullName, srcDirInfo.Name), true);
                }
                else
                {
                    Directory.CreateDirectory(destFileInfo.Directory.FullName);
                    File.Copy(srcPath, Path.Combine(destFileInfo.Directory.FullName, srcDirInfo.Name), true);
                }
            }
            else
            {
                success = false;
                file.error = "source file doesnt exist";
                throw new FileNotFoundException();
            }
            return success;

        }





        //.%%%%%%..%%%%%%...%%%%...%%%%%%..%%%%%%..%%%%%..........
        //...%%....%%......%%........%%....%%......%%..%%.........
        //...%%....%%%%.....%%%%.....%%....%%%%....%%..%%.........
        //...%%....%%..........%%....%%....%%......%%..%%.........
        //...%%....%%%%%%...%%%%.....%%....%%%%%%..%%%%%..........
        //........................................................                              

        /// <summary>
        /// Tries to Get all files from a directory, logs error in case it fails.
        /// Also returns success flag.
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="searchPattern"></param>
        /// <param name="searchOption"></param>
        /// <param name="count"></param>
        /// <param name="IsInteractivelyCallBack"></param>
        /// <param name="callBackBufferSize"></param>
        /// <param name="IsSuccessful"></param>
        /// <returns></returns>
        internal IList<FileInfo> TryGetAllFileDetailsFromDirectory(
            String dirPath,
            string searchPattern, 
            SearchOption searchOption,
            Action<long> count,
            bool IsInteractivelyCallBack,
            int callBackBufferSize,
            out bool IsSuccessful)
        {
            logger.Log(NLog.LogLevel.Info, "Inside: TryGetAllFileDetailsFromDirectory()");
            IsSuccessful = true;
            if (!Directory.Exists(dirPath))
            {
                logger.Log(NLog.LogLevel.Error, "dirPath: doesnt exist.");
                IsSuccessful = false;
                return null;
            }

            IEnumerable<FileInfo> files = null;
            DirectoryInfo srcDirInfo = new DirectoryInfo(dirPath);
            try
            {
               files = srcDirInfo.EnumerateFiles(searchPattern, searchOption);
            }
            catch (ArgumentNullException ae)
            { IsSuccessful = false; logger.Log(NLog.LogLevel.Error, ae.Message); }
            catch(ArgumentOutOfRangeException aoe)
            { logger.Log(NLog.LogLevel.Error, aoe.Message); IsSuccessful = false; }
            catch(DirectoryNotFoundException dnf)
            { logger.Log(NLog.LogLevel.Error, dnf.Message); IsSuccessful = false; }
            catch(System.Security.SecurityException se)
            { logger.Log(NLog.LogLevel.Error, se.Message); IsSuccessful = false; }

            List<FileInfo> fileList = new List<FileInfo>();
            long i = 0;
            foreach (var item in files)
            {
                
                i++;
                fileList.Add(item);
                if (IsInteractivelyCallBack && i%callBackBufferSize == 0)
                    count(i);
            }
            return fileList;
        }




        //internal void GetTopLevelFolderFilesList(IPreviewList ui, IProgress<int> progress, System.Threading.CancellationToken ct)
        //{
        //    if (!(Directory.Exists(ui.SourceFolderPath)))
        //        return;
        //    int count = 0;
        //    DirectoryInfo srcDirInfo = new DirectoryInfo(ui.SourceFolderPath);
        //    xFileCabinet cab = new xFileCabinet();
        //    var files = srcDirInfo.EnumerateFiles(ui.SourceFileSearchPattern, SearchOption.TopDirectoryOnly);
        //    foreach (var item in files)
        //    {
        //        if (ct.IsCancellationRequested)
        //            return;
        //        count++;
        //        if (ui.PreviewSrcList == null)
        //            ui.PreviewSrcList = new List<string>();
        //        ui.PreviewSrcList.Add(item.FullName);
        //        progress.Report(count);

        //    }
        //    //foreach (var item in srcDirInfo.EnumerateDirectories())
        //    //{
        //    //    cab.boxes.Add(new xFileBox());
        //    //}

        //}


        ///////////////////////////////////////////////////////////////////////////////////////////////

    }
  
}
