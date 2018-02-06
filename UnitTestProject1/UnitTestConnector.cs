using BatchCopyCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitTestProject1
{
   public class UnitTestConnector
    {

        private IPreviewList previewList;
        private IRemoveBatchOp removeBatch;
        private IAddBatchOp addBatch;


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

        public IPreviewList PreviewListArgumentObject {
            get {
                if (previewList == null)
                    previewList = new PreviewListInterfaceImplementation();
                return previewList;
            }
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
                get;set;
            }
        }
    }

    

}
