using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bußgeldrechner.Modules
{
    public partial class ModuleSettings : UserControl
    {

        private static ModuleSettings _instance;
        public static ModuleSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModuleSettings();
                }
                return _instance;
            }
        }

        public ModuleSettings()
        {
            InitializeComponent();
        }

        private void checkAutoDel_OnChange(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormAutoDel = checkAutoDel.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
