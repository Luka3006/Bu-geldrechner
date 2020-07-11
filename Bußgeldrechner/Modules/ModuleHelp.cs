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
    public partial class ModuleHelp : UserControl
    {
        private static ModuleHelp _instance;
        public static ModuleHelp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModuleHelp();
                }
                return _instance;
            }
        }

        public ModuleHelp()
        {
            InitializeComponent();
        }
    }
}
