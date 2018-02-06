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
    public partial class Extensions : Form
    {
        public string CSVList
        {
            get { return txtExtensions.Text; }
            
        }
        public Extensions()
        {
            InitializeComponent();
        }
    }
}
