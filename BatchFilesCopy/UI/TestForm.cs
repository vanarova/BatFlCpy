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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            List<string> ex = new List<string>() { "Filea", "Fileb", "Filec" };
            ex.All(x => {
                fileTreeView.Nodes.Add(x);

                return true;
            });
            fileTreeView.ImageIndex = 0;
            fileTreeView.Nodes[0].Nodes.Add("ok");
            fileTreeView.Nodes[0].Nodes[0].ImageIndex = 1;
        }
    }
}
