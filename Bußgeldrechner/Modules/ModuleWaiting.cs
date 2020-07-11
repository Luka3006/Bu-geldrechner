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
    public partial class ModuleWaiting : UserControl
    {

        private static ModuleWaiting _instance;
        public static ModuleWaiting Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModuleWaiting();
                }
                return _instance;
            }
        }

        public ModuleWaiting()
        {
            InitializeComponent();
        }

        public static Timer timerValue;

        private void ModuleWaiting_Load(object sender, EventArgs e)
        {
            timerValue = timer;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            circle.Value += 1;
            if(circle.Value == 99)
            {
                circle.Value += 1;
                timer.Stop();
                FormMain.ResultScreen();
                circle.Value = 0;
            }
        }
    }
}
