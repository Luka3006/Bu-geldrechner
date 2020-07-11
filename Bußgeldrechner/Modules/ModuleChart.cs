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
    public partial class ModuleChart : UserControl
    {

        private static ModuleChart _instance;
        public static ModuleChart Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModuleChart();
                }
                return _instance;
            }
        }

        public ModuleChart()
        {
            InitializeComponent();
        }
    }
}
