using BatchCopyCore.Connect;
using System;
using BatchCopyCore.UI.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchCopyCore;

namespace BatchFilesCopy.UI
{
    public partial class BatchCopyFiles : Form
    {
        public string SelectedFile { get; set; }
        public List<string> OriginalFileList { get; set; }


        ////╦ ╦╦  ╔═╗┌─┐┌─┐┬┌─┌─┐┌┬┐
        ////║ ║║  ╚═╗│ ││  ├┴┐├┤  │ 
        ////╚═╝╩  ╚═╝└─┘└─┘┴ ┴└─┘ ┴ 
        public UIConnector UI { get; set; }

        ////╔═╗┌─┐┬─┐┌─┐  ┌─┐┌─┐┌┐┌┌┐┌┌─┐┌─┐┌┬┐┌─┐┬─┐
        ////║  │ │├┬┘├┤   │  │ │││││││├┤ │   │ │ │├┬┘
        ////╚═╝└─┘┴└─└─┘  └─┘└─┘┘└┘┘└┘└─┘└─┘ ┴ └─┘┴└─
        public CoreConnector Core { get; set; }

        ////╔═╗┌─┐┬─┐┌┬┐  ┬─┐┌─┐┌─┐┌─┐┬─┐┌┐┌┌─┐┌─┐
        ////╠╣ │ │├┬┘│││  ├┬┘├┤ ├┤ ├┤ ├┬┘││││  ├┤ 
        ////╚  └─┘┴└─┴ ┴  ┴└─└─┘└  └─┘┴└─┘└┘└─┘└─┘
        /// <summary>
        /// Forms reference used in this form. These form reference will be passed to forms which uses them.
        /// Run progress is a form for displaying progress of operations.
        /// </summary>
        public RunDetails RunProgress { get; set; }

        public BatchCopyFiles()
        {
            string err;
            InitializeComponent();
            BatchCopyCore.Help.GetHelpText();
            UI = new UIConnector();
            Core = new CoreConnector();
            UI.AddBatchArgument.BatchName = "";
            ////╔═╗┌─┐┬─┐┌─┐  ╔═╗─┐ ┬┌─┐┌─┐┬ ┬┌┬┐┌─┐
            ////║  │ │├┬┘├┤   ║╣ ┌┴┬┘├┤ │  │ │ │ ├┤ 
            ////╚═╝└─┘┴└─└─┘  ╚═╝┴ └─└─┘└─┘└─┘ ┴ └─┘
            Core.Execute(UI.AddBatchArgument, out err);
            RunProgress = new UI.RunDetails();
            RunProgress.Hide();
            

            HandleCoreError(err);
            RefreshControlBindings();

            //cbBatchSequence.DataSource = Manager.Batches;
            //cbBatchSequence.DisplayMember = "Name";
        }

        private void HandleCoreError(string err)
        {
            if (!string.IsNullOrEmpty(err))
            {
                //handle error here
            }
        }

        private void PopulateGrid()
        {
            //lstCSVList.Items.Clear();
            //lstCSVList.Items.AddRange(Library.Helper.GetOrAdjustFilesList(txtPrefix.Text,txtPostfix.Text).ToArray());
        }



        //  ######## ##     ## ######## ##    ## ########    ##     ##    ###    ##    ## ########  ##       ######## ########   ######  
        //  ##       ##     ## ##       ###   ##    ##       ##     ##   ## ##   ###   ## ##     ## ##       ##       ##     ## ##    ## 
        //  ##       ##     ## ##       ####  ##    ##       ##     ##  ##   ##  ####  ## ##     ## ##       ##       ##     ## ##       
        //  ######   ##     ## ######   ## ## ##    ##       ######### ##     ## ## ## ## ##     ## ##       ######   ########   ######  
        //  ##        ##   ##  ##       ##  ####    ##       ##     ## ######### ##  #### ##     ## ##       ##       ##   ##         ## 
        //  ##         ## ##   ##       ##   ###    ##       ##     ## ##     ## ##   ### ##     ## ##       ##       ##    ##  ##    ## 
        //  ########    ###    ######## ##    ##    ##       ##     ## ##     ## ##    ## ########  ######## ######## ##     ##  ###### 
        // Font - Banner3



        private void button1_Click(object sender, EventArgs e)
        {        }

        private void button2_Click(object sender, EventArgs e)
        {        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {        }

        private void button3_Click(object sender, EventArgs e)
        {        }

        private void txtPostfix_TextChanged(object sender, EventArgs e)
        {        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {        }

        private void label8_Click(object sender, EventArgs e)
        {        }

        private void saveBatchAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {        }

        private void btnSelectCSVFile_Click(object sender, EventArgs e)
        {        }

        private void lstCSVList_SelectedIndexChanged(object sender, EventArgs e)
        {        }

        private void BatchCopyFiles_Load(object sender, EventArgs e)
        {
            CopyByCodeSource ccs = new CopyByCodeSource(RunProgress);
            ccs.ShowHelp += Ccs_ShowHelp;
            ccs.Dock = DockStyle.Fill;
            panel2.Controls.Add(ccs);

            ccs.UI = UI;
            ccs.Core = Core;
            //ccs.UpdateFileCountStatus += Ccs_UpdateFileCountStatus;
            ccs.StartProgressAnimation += Ccs_StartProgressAnimation;
            ccs.StopProgressAnimation += Ccs_StopProgressAnimation;
            ccs.ResultMessage += Ccs_ResultMessage;
        }

        private void Ccs_ResultMessage(object sender, CodeCopyUpdate e)
        {
            lblFooter.Text = e.ResultMsg;
        }

        private void Ccs_StopProgressAnimation(object sender, EventArgs e)
        {
            toolStripProgBar.MarqueeAnimationSpeed = 0;// (e as CodeCopyUpdate).ArgKey;
            toolStripProgBar.Style = ProgressBarStyle.Blocks;
        }

        private void Ccs_StartProgressAnimation(object sender, EventArgs e)
        {
            toolStripProgBar.Style = ProgressBarStyle.Marquee;
            toolStripProgBar.MarqueeAnimationSpeed = 100;// (e as StatusArgs).ArgKey;
        }

        private void Ccs_ShowHelp(object sender, EventArgs e)
        {
            lblFooter.Text = BatchCopyCore.Help.HelpTexts[(e as CodeCopyUpdate).HelpMessage];
        }

        private void btnFooterTip_ButtonClick(object sender, EventArgs e)
        {
           lblFooter.Text = BatchCopyCore.Help.GetHelpText();
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            CreateANewBatch();
        }


        private void CreateANewBatch()
        {
            string err;
            OneTextBoxInput bName = new OneTextBoxInput();
            if (bName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UI.AddBatchArgument.BatchName = bName.BatchName;
                Core.Execute(UI.AddBatchArgument, out err);
                HandleCoreError(err);
            }
            RefreshControlBindings();
        }

        private void btnRemoveBatch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete: "  + (cbBatchSequence.SelectedItem as Batch).Name, "Confirmation",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string err;
                UI.RemoveBatchArgument.BatchName = (cbBatchSequence.SelectedItem as Batch).Name;
                ////╔═╗┌─┐┬─┐┌─┐  ╔═╗─┐ ┬┌─┐┌─┐┬ ┬┌┬┐┌─┐
                ////║  │ │├┬┘├┤   ║╣ ┌┴┬┘├┤ │  │ │ │ ├┤ 
                ////╚═╝└─┘┴└─└─┘  ╚═╝┴ └─└─┘└─┘└─┘ ┴ └─┘
                Core.Execute(UI.RemoveBatchArgument, out err);
                HandleCoreError(err);
                if (!string.IsNullOrEmpty(err))
                    MessageBox.Show(err);
                RefreshControlBindings();
            }
        }


        private void RefreshControlBindings()
        {
            if (cbBatchSequence.Items.Count !=  Core.BatchManager.Batches.Count)
            {
                cbBatchSequence.DataSource = null;
                cbBatchSequence.DataSource = Core.BatchManager.Batches;
                cbBatchSequence.DisplayMember = "Name";
            }

        }

        private void toolStripSplitbtnCancel_ButtonClick(object sender, EventArgs e)
        {
            string err;
            UI.CancelOperationArgument.ActiveBatchIndex = cbBatchSequence.SelectedIndex;
            ////╔═╗┌─┐┬─┐┌─┐  ╔═╗─┐ ┬┌─┐┌─┐┬ ┬┌┬┐┌─┐
            ////║  │ │├┬┘├┤   ║╣ ┌┴┬┘├┤ │  │ │ │ ├┤ 
            ////╚═╝└─┘┴└─└─┘  ╚═╝┴ └─└─┘└─┘└─┘ ┴ └─┘
            Core.Execute(UI.CancelOperationArgument,out err);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BatchFilesCopy.UI.TestForm t = new BatchFilesCopy.UI.TestForm();
            t.Show();
        }

        private void toolStripBtnDetails_Click(object sender, EventArgs e)
        {
            if(!RunProgress.Visible)
            RunProgress.Show();
        }
    }
}
