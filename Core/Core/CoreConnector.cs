using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchCopyCore
{
    /// <summary>
    /// This class should connect core functionality with UI. It will translate users UI
    /// preferences into class objects which will be used by core.
    /// </summary>
   public class CoreConnector
    {
        private BatchManager batchManager;
        private Core.CodeCopy ccopy;
        private Core.AsyncAwaitHelper asyncHelper;
        //public event EventHandler<BatchIdArgs> BatchActionOccurredInConnector;

        public CoreConnector()
        {
            if (batchManager == null)
                batchManager = new BatchCopyCore.BatchManager();
            //if (ccopy == null)
            //    ccopy = new BatchCopyCore.CodeCopy();
        }


        public BatchManager BatchManager {
            get
            {
                if (batchManager == null)
                    batchManager = new BatchCopyCore.BatchManager();
                if (ccopy == null)
                    ccopy = new Core.CodeCopy();
                if (asyncHelper == null)
                    asyncHelper = new Core.AsyncAwaitHelper();
                return batchManager;
            }
        }

        public enum DestinationFolderStructure
        {
            Maintain_source_folder_structure,
            Create_folders_according_to_time_stamps_ranges,
            Create_dictionary_style_folders_from_az,
            Remove_all_sub_folders_copy_all_files_to_destination_folder_only,
        }
        
        public enum CommandToExecute
        {
            AddBatch,AddBatchWithName,RemoveBatch
        }


        public void Execute(IAddBatchOp arg, out string err)
        {
            err = "";
            if (string.IsNullOrEmpty((arg as IAddBatchOp).BatchName))
                batchManager.AddBatch();
            else
                batchManager.AddBatch((arg as IAddBatchOp).BatchName);
        }

        public void Execute(ICancelOp arg, out string err)
        {
            err = "";
            asyncHelper.CancelQueueTasks();
            //if(batchManager.Batches[(arg as ICancelOp).ActiveBatchIndex].asyncHelper!= null)
            //batchManager.Batches[(arg as ICancelOp).ActiveBatchIndex].asyncHelper.CancelTask.Cancel();
        }

        public void Execute(IRemoveBatchOp arg, out string err)
        {
            err = "";
            batchManager.RemoveBatch((arg as IRemoveBatchOp).BatchName, out err);
        }

        public void Execute(IPreviewList arg, IProgressReport progress, out string err)
        {
            err = "";
            var args = (arg as IPreviewList);
            //Task<int> task;
            //if(batchManager.Batches[args.ActiveBatchIndex].asyncHelper.CurrentTask!= null &&
            //    batchManager.Batches[args.ActiveBatchIndex].asyncHelper.CurrentTask.GetAwaiter().IsCompleted)
            //task = batchManager.Batches[args.ActiveBatchIndex].asyncHelper.GetPreviewListAsync(arg, progress, Completed, Cancelled);

            //var activeBatch = batchManager.Batches[args.ActiveBatchIndex];
            ccopy = new Core.CodeCopy();
            asyncHelper = new Core.AsyncAwaitHelper();
            var hdl = new Func<IOperationContainer,IProgressReport, System.Threading.CancellationToken, bool>(ccopy.GetPreviewFilesList);
            asyncHelper.EnqueueFunc(hdl);
            asyncHelper.RunQueue(arg, progress);// progressChanged, result, Completed, Cancelled);

            //var async = batchManager.Batches[args.ActiveBatchIndex].asyncHelper;
            //async.EnqueueFunc(async.ccopy.GetPreviewFilesList);

            //batchManager.Batches[args.ActiveBatchIndex].GeneratePreviewList(args.CopyType,
            //   args.DestinationFolderPath,
            //   args.ExemptedFileExt,
            //   args.IncludeFileExt,
            //   args.IncludeFilesFromNestedFolders,
            //   args.LargeThen,
            //   args.LessThen,
            //   args.SourceCSVList,
            //   args.SourceFileSearchPattern,
            //   args.SourceFolderPath
            //   );
            //return task;
        }

        /// <summary>
        /// Executes multiple commands. Fills each command in func queue and runs queue.
        /// Run queue creates tasks to run each func.
        /// </summary>
        /// <param name="cmdFirst"></param>
        /// <param name="cmdSecond"></param>
        /// <param name="progress"></param>
        /// <param name="Completed"></param>
        /// <param name="Cancelled"></param>
        /// <param name="err"></param>
        public void Execute(IPreviewList cmdFirst, IPreviewList cmdSecond, IProgressReport progress,out string err )//, IProgress<IProgressReport> progressChanged,IResult result, Action Completed, Action Cancelled, out string err)
        {
            err = "";
            ccopy = new Core.CodeCopy();
            asyncHelper = new Core.AsyncAwaitHelper();
            var hdl1 = new Func<IOperationContainer,IProgressReport, System.Threading.CancellationToken,  bool>(ccopy.GetPreviewFilesList);
            //same function call, with search depth changed.
            var hdl2 = new Func<IOperationContainer, IProgressReport, System.Threading.CancellationToken, bool>(ccopy.GetPreviewFilesList);
            asyncHelper.EnqueueFunc(hdl1);
            asyncHelper.EnqueueFunc(hdl2);
            asyncHelper.RunQueue(cmdFirst, cmdSecond, progress);//, progressChanged, result, Completed, Cancelled);

        }


        //private  string SourceFolderPath { get; set; }
        //private  string SourceFileSearchPattern { get; set; }
        //private  bool IncludeFilesFromNestedFolders { get; set; }
        //private  string  SourceCSVList { get; set; }
        
        
        //private  string DestinationFolderPath { get; set; }
        //private  DestinationFolderStructure CopyType { get; set; }
        //private  int LargeThen { get; set; }
        //private  int LessThen { get; set; }
        //private  string ExemptedFileExt { get; set; }
        //private  string IncludeFileExt { get; set; }
        //private  CommandToExecute Commands { get; set; }
        //public object CommandResult { get; set; }

    }

    /// <summary>
    /// This interface is used to update operation progress on UI, all the updates, result, events for completion & cancellation
    /// 
    /// </summary>
    public interface IProgressReport
    {
        int OperationIndex { get; set; }
        int Count { get; set; }
        String UnitProgressMessage { get; set; }
        List<String> OperationProgressMessage { get; set; }
        IProgress<IProgressReport> progressChanged { get; set; }
        IResult result { get; set; }
        Action Completed { get; set; }
        Action Cancelled { get; set; }
    }


    /// <summary>
    /// This result shows final result message shown on main form.
    /// </summary>
    public interface IResult
    {
         string Message { get; set; }
        
    }

    /// <summary>
    /// This interface is used by interfaces which will contain, operation commands and its results.
    /// It is not having any definition coz its implementation will be different for different scenarios.
    /// In other words, this interface will be used as an argument in core layer functions and it will contain
    /// both operation and its result.
    /// </summary>
    public interface IOperationContainer
    {
    }

    /// <summary>
    /// An example of implementation of IOperationContainer, here we have only command with no result.
    /// </summary>
    public interface IAddBatchOp :IOperationContainer
    {
         string BatchName { get; set; }
    }

    public interface ICancelOp : IOperationContainer
    {
        int ActiveBatchIndex { get; set; }
    }

    public interface IRemoveBatchOp: IOperationContainer
    {
        string BatchName { get; set; }
    }

    public interface IGeneratePreviewListOp : IOperationContainer
    {
        
    }


    /// <summary>
    /// Contains all UI controls values, user selcted on form.
    /// </summary>
   public interface IUISettings:IOperationContainer
    {
        string SourceFolderPath { get; set; }
        string SourceFileSearchPattern { get; set; }
        bool IncludeFilesFromNestedFolders { get; set; }
        string SourceCSVList { get; set; }


        string DestinationFolderPath { get; set; }
        CoreConnector.DestinationFolderStructure CopyType { get; set; }


        int LargeThen { get; set; }
        int LessThen { get; set; }

        string ExemptedFileExt { get; set; }
        string IncludeFileExt { get; set; }

        int ActiveBatchIndex { get; set; }
    }

    /// <summary>
    /// An typical example of IOperationContainer, here we have both operation parameters and results.
    /// 
    /// This operation will fill preview lists based on search option.
    /// </summary>
    public interface IPreviewList:IUISettings,IOperationContainer
    {
        IList<string> PreviewSrcList { get; set; }
        IList<string> PreviewDestList { get; set; }

        SearchOption PreviewSearchOption { get; set; }
    } 

}
