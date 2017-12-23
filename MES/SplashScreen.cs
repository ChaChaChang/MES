using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace MES
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            lbApp.Text = null;
            lbCompany.Text = null;
            object[] oAttributes;

            lbAppVer.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            oAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(
                typeof(AssemblyProductAttribute),false);
            if (oAttributes.Length != 0 )
            {
                lbApp.Text = ((AssemblyProductAttribute)oAttributes[0]).Product;
            }

            oAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(
                typeof(AssemblyCompanyAttribute), false);
            if (oAttributes.Length ==0)
            {
                lbCompany.Text = ((AssemblyCompanyAttribute)oAttributes[0]).Company;
            }

        }
    }
}
