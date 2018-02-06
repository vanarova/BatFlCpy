using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchCopyCore
{
    public class BatchManager
    {
        public List<Batch> Batches;// = new List<Batch>();
       // public event EventHandler<BatchIdArgs> BatchActionOccuredInBatchManager;

        public  BatchManager()
        {
            Batches = new List<BatchCopyCore.Batch>();
            //Batches.All(x => {
            //    x.taskCompleted += Batch_taskCompleted;
            //    return true;
            //});
        }

        //private void Batch_taskCompleted(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private string GetNewBatchId()
        {
            if (Batches.Count == 0)
                return "Batch_1";
            var number = Convert.ToInt32(Batches.Last().Id.Split('_')[1]) + 1;
            return "Batch_" + number;
        }

        private string GetBatchName(string batchId)
        {
            if (Batches.Count == 0)
                return "First Batch";
            string number = batchId.Split('_')[1];
            return  (Batch.BatchNames)Enum.Parse(typeof(Batch.BatchNames), number) + " Batch";// number;
        }

        public void AddBatch(string batchName)
        {
            var newBatchID = GetNewBatchId();
            Batches.Add(new BatchCopyCore.Batch() {Id= newBatchID, Name = batchName });
        }

        public  void AddBatch()
        {
            var newBatchID = GetNewBatchId();
            Batches.Add(new BatchCopyCore.Batch() { Id = newBatchID, Name = GetBatchName(newBatchID) });
        }

        public void RemoveBatch(Batch batch)
        {
            if(Batches.Count>1)
            Batches.Remove(batch);
        }

        public void RemoveBatch(string batchName, out string err)
        {
            err = string.Empty;
            if (Batches.Count > 1)
            { 
            var b = Batches.Where(x => x.Name == batchName).FirstOrDefault();
            Batches.Remove(b);
            }
            else
            {
                err = "Cannot delete last batch.";
            }
        }

        



    }
}
