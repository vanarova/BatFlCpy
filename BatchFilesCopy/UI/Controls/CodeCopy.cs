using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BatchFilesCopy.UI;
using BatchFilesCopy.UI.Controls;

namespace BatchCopyCore.UI.Controls
{
    /// <summary>
    /// Copy by code is a user control which shows controls on UI, for copying files from one src to
    /// destination, this copy will be done by code not by DOS command of operating system commands
    /// It was thought that another user control may replace this control if nessecary , that control wil be DOS based 
    /// command version or may be something different.
    /// </summary>
    public partial class CopyByCodeSource : UserControl
    {
       
       
        ////╦ ╦╦  ╔═╗┌─┐┌─┐┬┌─┌─┐┌┬┐
        ////║ ║║  ╚═╗│ ││  ├┴┐├┤  │ 
        ////╚═╝╩  ╚═╝└─┘└─┘┴ ┴└─┘ ┴ 
        public Connect.UIConnector UI { get; set; }

        
        ////╔═╗┌─┐┬─┐┌─┐  ┌─┐┌─┐┌┐┌┌┐┌┌─┐┌─┐┌┬┐┌─┐┬─┐
        ////║  │ │├┬┘├┤   │  │ │││││││├┤ │   │ │ │├┬┘
        ////╚═╝└─┘┴└─└─┘  └─┘└─┘┘└┘┘└┘└─┘└─┘ ┴ └─┘┴└─
        public CoreConnector Core { get; set; }

        
        ////╔═╗┬  ┬┌─┐┌┐┌┌┬┐┌─┐
        ////║╣ └┐┌┘├┤ │││ │ └─┐
        ////╚═╝ └┘ └─┘┘└┘ ┴ └─┘
        public event EventHandler<CodeCopyUpdate> ShowHelp;
        public event EventHandler<EventArgs> StartProgressAnimation;
        public event EventHandler<EventArgs> StopProgressAnimation;
        public event EventHandler<CodeCopyUpdate> ResultMessage;


        ////╔═╗┌─┐┬─┐┌┬┐  ┬─┐┌─┐┌─┐┌─┐┬─┐┌┐┌┌─┐┌─┐
        ////╠╣ │ │├┬┘│││  ├┬┘├┤ ├┤ ├┤ ├┬┘││││  ├┤ 
        ////╚  └─┘┴└─┴ ┴  ┴└─└─┘└  └─┘┴└─┘└┘└─┘└─┘
        public RunDetails RunProgressForm { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="runProgess"></param>
        public CopyByCodeSource(RunDetails runProgess)
        {
            RunProgressForm = runProgess;
            InitializeComponent();
        }

      


        private void cbCSVSourceList_CheckedChanged(object sender, EventArgs e)
        {
            txt_srcFolder.Text = "";
            txtFileSearchPattern.Enabled = !cbCSVSourceList.Checked;
            lblFileSearchPattern.Enabled = !cbCSVSourceList.Checked;
            if (!cbCSVSourceList.Checked)
            {
                lblSourceList.Text = "Select source folder";
                Errorhighlight("reset");
            }
            else
            {
                lblSourceList.Text = "Source files list";
                Errorhighlight("reset");
            }
        }

     

        private void CopyByCodeSource_Load(object sender, EventArgs e)
        {
            cb_destFolderStructure.SelectedIndex = 0;
            cbCSVSourceList.Checked = false;


            cbCSVExemptedList.Checked = true;
            cbCSVExemptedList.Checked = false;
        }

        private void cbCSVExemptedList_CheckedChanged(object sender, EventArgs e)
        {
            btnExemptedFiles.Enabled = cbCSVExemptedList.Checked;
            btnExemptedFileExtensions.Enabled = !cbCSVExemptedList.Checked;
            if (cbCSVExemptedList.Checked)
            { lblExemptedFile.Text = "Exemption CSV File";  }
            else
            { lblExemptedFile.Text = "Exempted file extensions";  }
        }

        private void btnIncludeFileExtensions_Click(object sender, EventArgs e)
        {
            Extensions ex = new Extensions();
            if (ex.ShowDialog() == DialogResult.OK)
            {
                txtIncludeFiles.Text = ex.CSVList;
            }
        }

        private void btnExemptedFiles_Click(object sender, EventArgs e)
        {

        }

        private void btnExemptedFileExtensions_Click(object sender, EventArgs e)
        {
            Extensions ex = new Extensions();
            if(ex.ShowDialog() == DialogResult.OK)
            {
                txtExemptedList.Text = ex.CSVList;
            }
        }

        private void btnSelectCSVFile_Click(object sender, EventArgs e)
        {

        }

        private void btn_SrcFolder_Click(object sender, EventArgs e)
        {
            string errorMsg;
            //this functionality was introduced to remember last browse folder location, it needs some control on UI to fill this value
            // it is working currently, state manager manages this.
            var obj = StateManager.GetStateVariable("folder_path", out errorMsg) as Dictionary<string,object>;
            
            if (cbCSVSourceList.Checked)
            {
                if (fbd_SrcFileBrowse.ShowDialog() == DialogResult.OK)
                    txt_srcFolder.Text = fbd_SrcFileBrowse.FileName;
            }
            else
            {
                //if (obj != null)
                //{
                // //   fbd_SrcFolderBrowse = obj["folder_path"] as string;
                //}
                if (fbd_SrcFolderBrowse.ShowDialog() == DialogResult.OK)
                                txt_srcFolder.Text = fbd_SrcFolderBrowse.SelectedPath;
                StateManager.SaveStateVariable("folder_path", fbd_SrcFolderBrowse.SelectedPath, out errorMsg);
            }
            
        }

        private void btn_destFolder_Click(object sender, EventArgs e)
        {
            if (fbd_destFolderBrowse.ShowDialog() == DialogResult.OK)
                txtDestination.Text = fbd_destFolderBrowse.SelectedPath;
        }

        private void btnPreviewCopy_Click(object sender, EventArgs e)
        {
            string err;
            
            if (string.IsNullOrWhiteSpace(txt_srcFolder.Text))
                Errorhighlight("input");
            else if (!Common.DirExists(txt_srcFolder.Text))
                Errorhighlight("input");
            else
            {
                Errorhighlight("reset");

                //UI.AddBatchArgument.BatchName = "SomeBatch";
                //Core.Execute(UI.AddBatchArgument, out err);
                //Assert.IsTrue(string.IsNullOrEmpty(err), "error in core function");
                //Assert.AreEqual(core.BatchManager.Batches.Count, 1);



                ///Following calls prepare UI connector to connect to core by getting class objects needed for core connection,
                ///Since core connector expose interfaces and calling core need objects of these interfaces.

                UI.PreviewListArgumentObject.IncludeFilesFromNestedFolders = true;
                UI.PreviewListArgumentObject.SourceFileSearchPattern = "*";
                //UI.PreviewListArgumentObject.SourceFolderPath = "C://Users//h175494//Documents//Visual Studio 2015//Projects//BatchFilesCopy - Unstable - 1//BatchFilesCopy//Src";
                UI.PreviewListArgumentObject.SourceFolderPath = @"C:\Users\h175494\Downloads";
                UI.PreviewListArgumentObject.ActiveBatchIndex = 0;
                UI.PreviewListArgumentObject.PreviewSearchOption = SearchOption.AllDirectories;
                if (System.Diagnostics.Debugger.IsAttached)
                    System.Diagnostics.Debugger.Log(1, "Status", "Getting results..");



                UI.TopFolderFilesPreviewListArgumentObject.IncludeFilesFromNestedFolders = true;
                UI.TopFolderFilesPreviewListArgumentObject.SourceFileSearchPattern = "*";
                UI.TopFolderFilesPreviewListArgumentObject.SourceFolderPath = @"C:\Users\h175494\Downloads";
                UI.TopFolderFilesPreviewListArgumentObject.ActiveBatchIndex = 0;
                UI.TopFolderFilesPreviewListArgumentObject.PreviewSearchOption = SearchOption.TopDirectoryOnly;
                if (System.Diagnostics.Debugger.IsAttached)
                    System.Diagnostics.Debugger.Log(1, "Status", "Getting results..");



                //Run single func
                //StartProgressAnimation(this, new BatchCopyCore.StatusArgs() { ArgKey = 100, Msg = " files found" });
                //Core.Execute(UI.PreviewListArgumentObject, new Progress<int>(
                //    (x) =>
                //    {
                //        if (x % 500 == 0)
                //        {
                //            UpdateFileCountStatus(this, new BatchCopyCore.StatusArgs() { ArgKey = x, Msg = " files found" });
                //        }
                //    }), new Action(PreviewCompleted), new Action(PreviewCancelled), out err);


                //Run both funcs


                UI.ProgressArgument.progressChanged =
                    new Progress<IProgressReport>(
                    (x) =>
                    {
                        if (x.Count % 500 == 0)
                        {
                            //UpdateFileCountStatus(this, new StatusArgs() { ArgKey = x.Count, UnitProgressMsg = x.UnitProgressMessage, OperationProgressMsg = x.OperationProgressMessage });

                            if (x.OperationProgressMessage != null)
                            {
                                RunProgressForm.UpdateProgress(x.OperationProgressMessage, x.Count, x.UnitProgressMessage,x.OperationIndex);
                            }
                        }
                    });
                
                UI.ProgressArgument.Completed = new Action(PreviewCompleted);
                UI.ProgressArgument.Cancelled = new Action(PreviewCancelled);
                UI.ProgressArgument.result = UI.ResultArgument;
                StartProgressAnimation(this, new EventArgs());

                RunProgressForm.AddOperationProgressControl();
                RunProgressForm.AddOperationProgressControl();

                //Top folder and then whole folder files.
                //Core.Execute(UI.TopFolderFilesPreviewListArgumentObject, UI.PreviewListArgumentObject, UI.ProgressArgument, out err);

                //this should be added inside run progree form only..
                //RunProgressForm.ProgressContainer.Controls.Add(new RunProgress());


                ////╔═╗┌─┐┬─┐┌─┐  ╔═╗─┐ ┬┌─┐┌─┐┬ ┬┌┬┐┌─┐
                ////║  │ │├┬┘├┤   ║╣ ┌┴┬┘├┤ │  │ │ │ ├┤ 
                ////╚═╝└─┘┴└─└─┘  ╚═╝┴ └─└─┘└─┘└─┘ ┴ └─┘
                Core.Execute(UI.PreviewListArgumentObject, UI.PreviewListArgumentObject, UI.ProgressArgument, out err);


            }
        }

      

        private void PreviewCancelled()
        {
            ResultMessage(this, new CodeCopyUpdate() {  ResultMsg ="The operation was cancelled" });
            StopProgressAnimation(this, new EventArgs());
        }

        private void PreviewCompleted()
        {
            //UpdateFileCountStatus(this, new CodeCopyUpdate() { ArgKey = int.Parse(UI.ResultArgument.Message), UnitProgressMsg = " files found..." });
            //UpdateFileCountStatus(this, new CodeCopyUpdate() { ArgKey = int.Parse(UI.ResultArgument.Message), UnitProgressMsg = " files found..." });
            ResultMessage(this, new CodeCopyUpdate() { ResultMsg = "The operation was completed" });
            StopProgressAnimation(this, new EventArgs());
            RunProgressForm.StopAnimation();
        }

        private void Errorhighlight(string v)
        {
            lblSourceList.ForeColor = Color.Black;
            switch (v)
            {
                case "input":
                    lblSourceList.ForeColor = Color.Red;

                    break;
                    //lblSourceList
                default:
                    break;
            }
        }

        private void btnPreviewCopy_MouseHover(object sender, EventArgs e)
        {
            ShowHelp(this,new CodeCopyUpdate() { HelpMessage="Preview" } );
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ShowHelp(this, new CodeCopyUpdate() { HelpMessage = "SearchPattern" });
        }

        private void txtLarge_Enter(object sender, EventArgs e)
        {
            if (txtLarge.Text == "-")
            {
                txtLarge.Text = "";
            }
        }

        private void txtLarge_Leave(object sender, EventArgs e)
        {
            if (txtLarge.Text == "")
            {
                txtLarge.Text = "-";
            }
        }

        private void txtLess_Leave(object sender, EventArgs e)
        {
            if (txtLess.Text == "")
            {
                txtLess.Text = "-";
            }
        }

        private void txtLess_Enter(object sender, EventArgs e)
        {
            if (txtLess.Text == "-")
            {
                txtLess.Text = "";
            }
        }
    }


    /// <summary>
    /// Eventargs implementation class. Send update status from CodeCopy control to parent form.
    /// </summary>
    public class CodeCopyUpdate : EventArgs
    {
        public string HelpMessage { get; set; }
        public string ResultMsg { get; set; }
        public string ProgressMessage { get; set; }
    }


}
