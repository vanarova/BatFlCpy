using BatchCopyCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchCopyCore
{
   public class Batch
    {
        //internal AsyncAwaitHelper asyncHelper;
        //public event EventHandler taskCompleted;
        public Batch()
        {
            //if (asyncHelper == null)
            //    asyncHelper = new BatchCopyCore.Core.AsyncAwaitHelper();
        }
       
        public enum BatchNames
        {
            First = 1,
            Second =2,
            Third =3,
            Forth =4,
            Fifth =5,
            Sixth = 6,
            Seventh = 7,
            Eighth = 8,
            Ninth = 9,
            Tenth = 10
        }

        public string Name { get; set; }

        public string Id { get; set; }
        public Boolean IsCorrect { get; set; }


        //internal void CancelCurrentOperation()
        //{
        //    if(asyncHelper.CancelTask != null)// && asyncHelper.CurrentTask != null && !asyncHelper.CurrentTask.IsCompleted && !asyncHelper.CurrentTask.IsFaulted)
        //    asyncHelper.CancelTask.Cancel();
        //}

    }
}
