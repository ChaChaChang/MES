using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class frmMain : Form
    {

        public static bool bPowerCheck = false;
        public static string sUserId, sUserName;

        private void miClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miCascad_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            frmAboutBox frmAboutBox = new frmAboutBox();
            frmAboutBox.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        public frmMain()
        {
            InitializeComponent();
            SQLUtility ocommon = new SQLUtility();
            DataTable dt=ocommon.GetDataTable_BySQLString("select count(1) cnt from tmp1 ");
            lblWipCount.Text = string.Format("| Current Wip: {0}", dt.Rows[0]["CNT"].ToString());
        }

    }
}
