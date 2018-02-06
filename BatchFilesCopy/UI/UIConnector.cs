using BatchCopyCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BatchCopyCore.Connect
{
    /// <summary>
    /// This class connects with Core and pass the objects Core needs, these objects are actually instances of core interfaces.
    /// </summary>
   public class UIConnector
    {

        private IPreviewList topPreviewList;
        private IPreviewList fullPreviewList;
        private IRemoveBatchOp removeBatch;
        private IAddBatchOp addBatch;
        private ICancelOp cancelOp;
        private IResult result;
        private IProgressReport progress;


        public IProgressReport ProgressArgument
        {
            get
            {
                if (progress == null)
                    progress = new ProgressInterfaceImplementation();
                return progress;
            }
        }

        public IAddBatchOp AddBatchArgument
        {
            get
            {
                if (addBatch == null)
                    addBatch = new AddBatchInterfaceImplementation();
                return addBatch;
            }
        }

        public IRemoveBatchOp RemoveBatchArgument
        {
            get
            {
                if (removeBatch == null)
                    removeBatch = new RemoveBatchInterfaceImplementation();
                return removeBatch;
            }
        }

        public IPreviewList PreviewListArgumentObject
        {
            get
            {
                if (fullPreviewList == null)
                    fullPreviewList = new PreviewListInterfaceImplementation();
                return fullPreviewList;
            }
        }


        public IPreviewList TopFolderFilesPreviewListArgumentObject
        {
            get
            {
                if (topPreviewList == null)
                    topPreviewList = new PreviewListInterfaceImplementation();
                return topPreviewList;
            }
        }

        public ICancelOp CancelOperationArgument
        {
            get
            {
                if (cancelOp == null)
                    cancelOp = new CancelOpInterfaceImplementation();
                return cancelOp;
            }
        }


        public IResult ResultArgument
        {
            get
            {
                if (result == null)
                    result = new ResultInterfaceImplementation();
                return result;
            }
        }



        public class ResultInterfaceImplementation : IResult
        {
            public string Message {get; set;}
        }

        public class CancelOpInterfaceImplementation : ICancelOp
        {
            public int ActiveBatchIndex
            {
                get; set;
            }
        }

        public class ProgressInterfaceImplementation : IProgressReport
        {
            public ProgressInterfaceImplementation()
            {
                OperationProgressMessage = new List<string>();
            }
            public Action Cancelled { get; set; }
          
            public Action Completed { get; set; }

            public int Count { get; set; }

            public string UnitProgressMessage { get; set; }

            public int OperationIndex { get; set; }

            public IProgress<IProgressReport> progressChanged { get; set; }

            public IResult result { get; set; }

            public List<string> OperationProgressMessage { get; set; }
           
        }

        public class AddBatchInterfaceImplementation : IAddBatchOp
        {
            public string BatchName { get; set; }
        }


        public class RemoveBatchInterfaceImplementation : IRemoveBatchOp
        {
            public string BatchName { get; set; }

        }

        public class PreviewListInterfaceImplementation : IPreviewList
        {
            public int ActiveBatchIndex
            {
                get; set;
            }

            public CoreConnector.DestinationFolderStructure CopyType
            {
                get; set;
            }

            public string DestinationFolderPath
            {
                get; set;
            }

            public string ExemptedFileExt
            {
                get; set;
            }

            public string IncludeFileExt
            {
                get; set;
            }

            public bool IncludeFilesFromNestedFolders
            {
                get; set;
            }

            public int LargeThen
            {
                get; set;
            }

            public int LessThen
            {
                get; set;
            }

            public IList<string> PreviewDestList
            {
                get; set;
            }

            public SearchOption PreviewSearchOption
            {
                get; set;
            }

            public IList<string> PreviewSrcList
            {
                get; set;
            }

            public string SourceCSVList
            {
                get; set;
            }

            public string SourceFileSearchPattern
            {
                get; set;
            }

            public string SourceFolderPath
            {
                get; set;
            }
        }

    }

    

}
