using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatchCopyCore.Core
{


    /// <summary>
    /// This class helps in queuing the tasks in queue, and executing tasks. It adds function calls in a queue and that queue is executed and each func call
    /// is ran by async/await operation.
    /// 
    /// Run queue method runs queue, it may have overloads for different number of commands.
    /// </summary>
   public class AsyncAwaitHelper
    {
        public CodeCopy ccopy;
        private CancellationTokenSource CancelTask { get; set; }
        //public Task CurrentTask { get; private set; }
        public AsyncAwaitHelper()
        {
            if (ccopy == null)
                ccopy = new CodeCopy();
        }


        
        ////╔═╗╦ ╦╔╗╔╔═╗╔╦╗╦╔═╗╔╗╔  ╔═╗╔═╗╦  ╦    ╔═╗ ╦ ╦╔═╗╦ ╦╔═╗
        ////╠╣ ║ ║║║║║   ║ ║║ ║║║║  ║  ╠═╣║  ║    ║═╬╗║ ║║╣ ║ ║║╣ 
        ////╚  ╚═╝╝╚╝╚═╝ ╩ ╩╚═╝╝╚╝  ╚═╝╩ ╩╩═╝╩═╝  ╚═╝╚╚═╝╚═╝╚═╝╚═╝
        public Queue<Func<IOperationContainer, IProgressReport, CancellationToken, bool>> qu;


        public void CancelQueueTasks()
        {
            if (CancelTask != null)
                CancelTask.Cancel();
            //var t = TaskQueue.Dequeue();

        }


        public void EnqueueFunc(Func<IOperationContainer, IProgressReport, CancellationToken, bool> funcHandle)
        {
            //if (TaskQueue == null)
            //    TaskQueue = new Queue<Task>();
            if (qu == null)
                qu = new Queue<Func<IOperationContainer, IProgressReport, CancellationToken,  bool>>();
            qu.Enqueue(funcHandle);
        }


        /// <summary>
        /// Run queue for 1 operation.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="progress"></param>
        public async void RunQueue(IOperationContainer c1,IProgressReport progress)
        {
            CancelTask = new CancellationTokenSource();
            Task CurrentTask =null;//= new Task();
            if (qu.Count != 1)
                throw new ArgumentException("Only 1 argument is possible in this function.");
            
            CancellationToken ct = CancelTask.Token;
            ct.Register(progress.Cancelled);
            foreach (var item in qu)
            {
                CurrentTask = new Task(() => item(c1, progress,ct), ct);
                CurrentTask.Start();
                //CurrentTask = Task.Factory.StartNew(() => item(c1, progress, ct), ct);
                //TaskQueue.Enqueue(CurrentTask);
                await CurrentTask;

                if (CurrentTask.Status == TaskStatus.RanToCompletion && CurrentTask.Exception == null)
                {
                    CancelTask = null;
                    progress.Completed();
                }
                else if (CurrentTask.Status == TaskStatus.Canceled)
                {
                    CancelTask = null;
                    //failure of task is taken as cancelled, this can be changes and a new failure action can be added if needed.
                    progress.Cancelled();
                }

            }
            //return CurrentTask;
        }


        /// <summary>
        /// Run queue for 2 operations, c1, c2 are 2 operations, queue will run one by one.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <param name="progress"></param>
        public async void RunQueue(IOperationContainer c1, IOperationContainer c2, IProgressReport progress)
        {
            progress.OperationProgressMessage.Add("starting first operation");
            progress.OperationIndex = 0;
            progress.progressChanged.Report(progress);
            CancelTask = new CancellationTokenSource();
            Task taska = null;//= new Task();
            
            if (qu.Count != 2)
                throw new ArgumentException("Only 2 argument is possible in this function.");

            CancellationToken ct = CancelTask.Token;
            ct.Register(progress.Cancelled);
            //foreach (var item in qu)
            //{
            var first = qu.Dequeue();
            taska = Task.Factory.StartNew(() => first(c1, progress,ct), ct);
            //TaskQueue.Enqueue(CurrentTask);
                
           

            var sec = qu.Dequeue();
            var taskb = taska.ContinueWith((t) => sec(c2, progress,ct), ct);
            //TaskQueue.Enqueue(NextTask);

            await taska;

            progress.OperationIndex = 1;
            progress.OperationProgressMessage.Add("Now starting second operation");
            progress.progressChanged.Report(progress);

            await taskb;

            //if (taskb.Status == TaskStatus.RanToCompletion && taskb.Exception == null)
            //{
            //    CancelTask = null;
            //    progress.Completed();
            //}
            //else if (taskb.Status == TaskStatus.Canceled)
            //{
            //    CancelTask = null;
            //    //failure of task is taken as cancelled, this can be changes and a new failure action can be added if needed.
            //    progress.Cancelled();
            //}



           
            
            if (taska.Status  == TaskStatus.RanToCompletion &&
                 taska.Status == TaskStatus.RanToCompletion && 
                 taska.Exception == null && taskb.Exception == null)
            {
                CancelTask = null;
                progress.Completed();
            }
            else if (taska.Status == TaskStatus.Canceled || taskb.Status == TaskStatus.Canceled)
            {
                CancelTask = null;
                //failure of task is taken as cancelled, this can be changes and a new failure action can be added if needed.
                progress.Cancelled();
            }

            progress.OperationProgressMessage.Add("Completed processing queue");
            progress.progressChanged.Report(progress);

            //System.Threading.Thread.Sleep(2000);


            //}
            //return CurrentTask;
        }




        //public void Run<If,p,Comp,Canl>(Action<If, p, Comp, Canl> method)
        //{
        //    if (CancelTask == null)
        //        CancelTask = new CancellationTokenSource();
        //    CancellationToken ct = CancelTask.Token;
        //    //Following cancel action will directly call the action delegate. 
        //    //Register method is registering this delegate to be called in case cancellation event.
        //    ct.Register(Cancelled);
        //    //Action method = ccopy.GetPreviewFilesList(T, progress, ct);
        //    CurrentTask = new Task(() => ccopy.GetPreviewFilesList(ui, progress, ct), ct);
        //    CurrentTask.Start();
        //    await CurrentTask;
        //    if (CurrentTask.Status == TaskStatus.RanToCompletion && CurrentTask.Exception == null)
        //    {
        //        CancelTask = null;
        //        Completed();
        //    }
        //    else
        //    {
        //        CancelTask = null;
        //        //failure of task is taken as cancelled, this can be changes and a new failure action can be added if needed.
        //        Cancelled();
        //    }
        //    return ui.PreviewSrcList.Count;
        //}





        //Task queue implementaion using Blocking collection.
        //BlockingCollection<Task<bool>> TaskQueue = new BlockingCollection<Task<bool>>();



        //private void AddMethodToQueue(Task<bool> method)
        //{
        //    if (!TaskQueue.IsAddingCompleted)
        //        TaskQueue.Add(method);
        //}

        //private void Run()
        //{
        //    //Func<>
        //    CancelTask = new CancellationTokenSource();
        //    CancellationToken ct = CancelTask.Token;
        //    //TaskQueue.All(async x => { x.Start(); await x; return true; });
        //    foreach (var task in TaskQueue)
        //    {
        //        Task.Run(task, ct);
        //    }

        //}



        //public async Task<int> GetPreviewListAsync(IPreviewList ui, IProgress<int> progress)
        //{
        //    Task t = new Task(() => ccopy.GetPreviewFilesList(ui, progress));
        //    t.Start();
        //    await t;
        //    return ui.PreviewSrcList.Count;
        //}


        //public void GetPreviewListSync(IPreviewList ui)
        //{
        //    ccopy.GetPreviewFilesList(ui,this);
        //}


    }
}
