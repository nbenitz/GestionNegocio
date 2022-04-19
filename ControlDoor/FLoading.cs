using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDoor
{
    public partial class FLoading : Form
    {
        public FLoading()
        {
            InitializeComponent();
        }

        private void FLoading_Load(object sender, EventArgs e)
        {
            pbxLoading.Location = new Point(this.Width / 2 - pbxLoading.Width / 2, this.Height / 2 - pbxLoading.Height);
        }
    }
}
