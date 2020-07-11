using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bußgeldrechner.Bussgeld;
using System.IO;

namespace Bußgeldrechner.Modules
{
    public partial class Module1 : UserControl
    {

        private static Module1 _instance;
        public static Module1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Module1();
                }
                return _instance;
            }
        }

        public Module1()
        {
            InitializeComponent();
        }

        private void Module1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (checkOrt.Checked == false)
                checkOrt.Checked = true;
            else
                checkOrt.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (checkProbe.Checked == false)
                checkProbe.Checked = true;
            else
                checkProbe.Checked = false;
        }

        public static string result = "";

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            Fahrplan fahrplan = new Fahrplan();
            try
            {
                fahrplan.gefahren = Convert.ToDouble(textBoxDriven.text);
                fahrplan.erlaubt = Convert.ToDouble(textBoxAllowed.text);
                fahrplan.innerorts = checkOrt.Checked;
                fahrplan.probezeit = checkProbe.Checked;
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            result = fahrplan.Main(fahrplan.gefahren, fahrplan.erlaubt, fahrplan.innerorts, fahrplan.probezeit);
            FormMain.LoadingScreen();
            if(Properties.Settings.Default.FormAutoDel == true)
            {
                textBoxAllowed.text = "";
                textBoxDriven.text = "";
                checkOrt.Checked = false;
                checkProbe.Checked = false;
            }
        }
    }
}
