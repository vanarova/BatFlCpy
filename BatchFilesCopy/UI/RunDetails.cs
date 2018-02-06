using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFilesCopy.UI
{
    public partial class RunDetails : Form
    {
        
        private List<string> msg;
       private List<Controls.RunProgress> progressControlList;
        
        public string LastDisplayedMessage { get; set; }
        public Panel ProgressContainer { get { return pnlRunDetails; } }
        //public List<string> Message
        //{
        //    get
        //    { return msg; }
        //    set
        //    { msg = value; }
        //}

        public void AddOperationProgressControl()
        {
            UI.Controls.RunProgress cont = new UI.Controls.RunProgress();
            cont.Dock = DockStyle.Top;
            //progressControlList.Add(cont);
            progressControlList.Add(cont);
            pnlRunDetails.Controls.Add(cont);
        }


        public void UpdateProgress(List<string> messages, int updateProgressCount, string updateProgressMsg, int OperationIndex)
        {
            

            for (int i = 0; i < progressControlList.Count; i++)
            {

                //var j = i - OperationIndex; //this is done to reverse the controls to animate, 
                ////as previously the last added control animates first which is not correct
                //if(j>=0)
                //progressControlList[j].progressLabel = updateProgressCount.ToString() + " " + updateProgressMsg;
                //if (j == OperationIndex && progressControlList[OperationIndex].ProgressAnimation != 100)
                //    progressControlList[j].ProgressAnimation = 100;
                //else if (j != OperationIndex && j>=0)
                //{ progressControlList[j].ProgressAnimation = 0; }

                if (i == OperationIndex)
                {
                    progressControlList[i].progressLabel = updateProgressCount.ToString() + " " + updateProgressMsg;
                    if(progressControlList[i].ProgressAnimation != 100)
                        progressControlList[i].ProgressAnimation = 100;
                }
                else
                {
                    if (progressControlList[i].ProgressAnimation != 0)
                    {
                        progressControlList[i].ProgressAnimation = 0;
                        //here change progress style to non-marquee
                    }
                }
                


            }

            //progressControlList.All(x => {
            //    if(x.ProgressAnimation !=0)
            //        x.ProgressAnimation = 0;
            //    return true;
            //});

            //if(progressControlList[OperationIndex].ProgressAnimation!= 100)
            //progressControlList[OperationIndex].ProgressAnimation = 100;

            //if (progressControlList[OperationIndex].ProgressAnimation == 0)
              //  progressControlList[OperationIndex].ProgressAnimation = 100;


            if (msg.Count != messages.Count)
            {
                msg.Clear();
                msg.AddRange(messages);

                txtProgressLog.Text = string.Empty;
                msg.All(x => { txtProgressLog.Text = txtProgressLog.Text + x + Environment.NewLine; return true; });
            }
        }


        public void StopAnimation()
        {
            for (int i = progressControlList.Count; i < progressControlList.Count; i--)
            {
              progressControlList[i].ProgressAnimation = 0;
            }

        }

        public RunDetails()
        {
            InitializeComponent();

            
            if (progressControlList == null)
                progressControlList = new List<UI.Controls.RunProgress>();
            if (msg == null)
                msg = new List<string>();
        }

        private void RunDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
