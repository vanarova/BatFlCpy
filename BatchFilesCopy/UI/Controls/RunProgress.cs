using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFilesCopy.UI.Controls
{
    public partial class RunProgress : UserControl
    {
        int animationSpeed;
        public string progressLabel { set { lblProgress.Text = value; } }
        public int  ProgressAnimation { get { return progressBar.MarqueeAnimationSpeed; } set { progressBar.MarqueeAnimationSpeed = value; } }


        public RunProgress()
        {
            
            InitializeComponent();
            progressBar.Style = ProgressBarStyle.Marquee;
        }
    }
}
