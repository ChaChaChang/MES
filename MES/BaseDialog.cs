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
    public partial class BaseDialog : Form
    {
        bool bCanClose = false;

        public BaseDialog()
        {
            InitializeComponent();
        }

        private void BaseDialog_Load(object sender, EventArgs e)
        {

        }

        public bool CanClose
        {
            get { return bCanClose; }
            set { bCanClose = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bCanClose = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BaseDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (!bCanClose);
        }
    }
}
