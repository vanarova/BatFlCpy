using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BatchCopyCore;
using Moq;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCodeCopy
    {



        [TestMethod]
        public void TestTryGetAllFileDetailsFromDirectory()
        {
           bool isSuccess;
           BatchCopyCore.Core.CodeCopy cc = new BatchCopyCore.Core.CodeCopy();

           //happy case
           IList<FileInfo> flist = cc.TryGetAllFileDetailsFromDirectory(@"..\..\..\SampleDirForTesting\src", "*",SearchOption.AllDirectories,TestCount,true,3, out isSuccess);
           Assert.IsTrue(isSuccess);
           Assert.IsTrue(flist.Count > 0);

            //test case 1: wrong path
            flist = cc.TryGetAllFileDetailsFromDirectory(@"..\..\..\SampleDirForTesting\srcsdf", "*", SearchOption.AllDirectories, TestCount, true, 3, out isSuccess);
            Assert.IsFalse(isSuccess);
            

            //test case 2: Top directory, with no files, only dirs
            flist = cc.TryGetAllFileDetailsFromDirectory(@"..\..\..\SampleDirForTesting\src\User Documentation\Application Help\Controller Configuration", "*", SearchOption.TopDirectoryOnly, TestCount, true, 3, out isSuccess);
            Assert.IsTrue(isSuccess);
            Assert.IsTrue(flist.Count == 0); //no files in top directory


            //test case 3: no callback
            flist = cc.TryGetAllFileDetailsFromDirectory(@"..\..\..\SampleDirForTesting\src", "*", SearchOption.AllDirectories, TestCount, false, 3, out isSuccess);
            Assert.IsTrue(isSuccess);
            Assert.IsTrue(flist.Count > 0);

            
            //test case 3: wrong search pattern
            flist = cc.TryGetAllFileDetailsFromDirectory(@"..\..\..\SampleDirForTesting\src", " * ", SearchOption.AllDirectories, TestCount, false, 3, out isSuccess);
            Assert.IsTrue(isSuccess);

        }

        private void TestCount(long c)
        {
            Assert.IsTrue(c%3==0); //3 is buffer size defined in above func.
            System.Diagnostics.Debug.WriteLine(c);
        }

        [TestMethod]
        public void TestGetPreviewFilesList()
        {
            //Use of Mocking framework here - however, this code is not used.
            /*
            System.Threading.CancellationToken ct = new System.Threading.CancellationToken();
            Mock<IProgressReport> mockIProgress = new Mock<IProgressReport>();
            Mock<IResult> mockIResult = new Mock<IResult>();
            mockIProgress.Setup(m => m.result).Returns(mockIResult.Object);
            mockIProgress.Setup(m => m.progressChanged).Returns(mockIResult.Object);
            Mock<IPreviewList> mockIPreviewList = new Mock<IPreviewList>();
            mockIPreviewList.Setup(m=> m.SourceFolderPath).Returns(@"C:\Users\h175494\Downloads\_Project packs\listings\Lens\Packaging");
            mockIPreviewList.Setup(m => m.SourceFileSearchPattern).Returns("*");
            mockIPreviewList.Setup(m => m.PreviewSearchOption).Returns(System.IO.SearchOption.AllDirectories);
            mockIPreviewList.Setup(m => m.PreviewSrcList).Returns(new System.Collections.Generic.List<string>());
            BatchCopyCore.Core.CodeCopy cc = new BatchCopyCore.Core.CodeCopy();
            */

        }


        //internal bool GetPreviewFilesList(IOperationContainer ui, IProgressReport progress, System.Threading.CancellationToken ct)
        //{
        //    var ipre = ui as IPreviewList;
        //    if (!(Directory.Exists(ipre.SourceFolderPath)))
        //        return false;
        //    int count = 0;
        //    DirectoryInfo srcDirInfo = new DirectoryInfo(ipre.SourceFolderPath);
        //    xFileCabinet cab = new xFileCabinet();
        //    var files = srcDirInfo.EnumerateFiles(ipre.SourceFileSearchPattern, ipre.PreviewSearchOption);
        //    foreach (var item in files)
        //    {
        //        if (ct.IsCancellationRequested)
        //            return false;
        //        count++;

        //        if (ipre.PreviewSrcList == null)
        //            ipre.PreviewSrcList = new List<string>();
        //        ipre.PreviewSrcList.Add(item.FullName);
        //        progress.Count = count;
        //        progress.UnitProgressMessage = "files";
        //        progress.progressChanged.Report(progress);

        //    }
        //    //foreach (var item in srcDirInfo.EnumerateDirectories())
        //    //{
        //    //    cab.boxes.Add(new xFileBox());
        //    //}
        //    progress.result.Message = count.ToString();
        //    return true;
        //}




        [TestMethod]
        public void TestPreviewList()
        {
            string err;
            CoreConnector core = new CoreConnector();
            UnitTestConnector tc = new UnitTestProject1.UnitTestConnector();

            tc.AddBatchArgument.BatchName = "SomeBatch";
            core.Execute(tc.AddBatchArgument, out err);
            Assert.IsTrue(string.IsNullOrEmpty(err),"error in core function");
            Assert.AreEqual(core.BatchManager.Batches.Count, 1);


            // set arguments from UI. These values can also be bounded.
            tc.PreviewListArgumentObject.CopyType =  CoreConnector.DestinationFolderStructure.Maintain_source_folder_structure;
            tc.PreviewListArgumentObject.ActiveBatchIndex = 0;
            tc.PreviewListArgumentObject.DestinationFolderPath = "";
            tc.PreviewListArgumentObject.ExemptedFileExt = "";
            tc.PreviewListArgumentObject.IncludeFileExt = "";
            tc.PreviewListArgumentObject.IncludeFilesFromNestedFolders = true;
            tc.PreviewListArgumentObject.LargeThen = -1;
            tc.PreviewListArgumentObject.LessThen = -1;
            tc.PreviewListArgumentObject.SourceCSVList = "";
            tc.PreviewListArgumentObject.SourceFileSearchPattern = "*";
            //tc.PreviewListArgumentObject.SourceFolderPath = "C://Users//h175494//Documents//Visual Studio 2015//Projects//BatchFilesCopy - Unstable - 1//BatchFilesCopy//Src";
            tc.PreviewListArgumentObject.SourceFolderPath = "C://Sources//OnRAMP";

            if (System.Diagnostics.Debugger.IsAttached)
                System.Diagnostics.Debugger.Log(1, "Status", "Getting results..");

            //call execute
            //core.Execute(tc.PreviewListArgumentObject,new Progress<int>(
            //    (x)=> {
            //        if (System.Diagnostics.Debugger.IsAttached)
            //            System.Diagnostics.Debugger.Log(1, "Status", "Files count: "+x);
            //            }), out err);


            //this below sleep statement, make the test thread sleep but, debugger thread is still attached.
            //System.Threading.Thread.Sleep(10000);

            //Calling below statement without sleep will through error because, preview list was empty and we access it in below statement.
            //thread sleep will fill this list and error will not come.

            //var result = tc.PreviewListArgumentObject.PreviewSrcList;;
            //Assert.IsTrue(result.Count>0, "Command result is null");
            //Assert.IsTrue(string.IsNullOrEmpty(err), "error in core function");
        }



        [Ignore]
        [TestMethod]
        public void TestAbsoluteFileCopy()
        {
            BatchCopyCore.xFile xf = new BatchCopyCore.xFile()
            { SourcePath = @"C:\Sources\Git\vanarovaTestProgs\BatchFilesCopy - Unstable - 1\SampleDirForTesting\src",
                DestinationPath = @"C:\Sources\Git\vanarovaTestProgs\BatchFilesCopy - Unstable - 1\SampleDirForTesting\des",
                IsPathAbsolute = true
            };
           
            //Assert.IsTrue(BatchCopyCore.CodeCopy.xCopyFileAndCreateDirectoryStrc(xf));
        }

        [Ignore]
        [TestMethod]
        public void TestRelativeFileCopy()
        {

            BatchCopyCore.xFile xf = new BatchCopyCore.xFile()
            {
                SourcePath = "Src//BIdea.pptx",
                DestinationPath = "Dest//BIdea.pptx",
                IsPathAbsolute = false,
                WorkingDirectoryPath = "C://Users//h175494//Documents//Visual Studio 2015//Projects//BatchFilesCopy - Unstable - 1//BatchFilesCopy"
            };

            //Assert.IsTrue(BatchCopyCore.CodeCopy.xCopyFileAndCreateDirectoryStrc(xf));
        }

    }
}
