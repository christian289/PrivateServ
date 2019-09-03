using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serv
{
    public partial class frmMain : Form
    {
        IZONE.MasterCtl ctl;

        public frmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ctl = new IZONE.MasterCtl();
            ctl.Dock = DockStyle.Fill;

            TP_IZONE.Controls.Add(ctl);
        }
    }
}
