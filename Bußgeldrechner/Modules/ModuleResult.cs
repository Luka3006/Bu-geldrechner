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
    public partial class ModuleResult : UserControl
    {

        private static ModuleResult _instance;
        public static ModuleResult Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModuleResult();
                }
                return _instance;
            }
        }

        public ModuleResult()
        {
            InitializeComponent();
        }

        public static TextBox res;

        private void ModuleResult_Load(object sender, EventArgs e)
        {
            res = textBoxResult;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormMain.CalcScreen();
        }

        public static void Refresh()
        {
            res.Text = Module1.result;
        }

    }
}
