using Bußgeldrechner.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bußgeldrechner
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Dictionary<Panel, Color> menuColors = new Dictionary<Panel, Color>();
        public static Panel infoPanel;
        Panel active;

        private void FormMain_Load(object sender, EventArgs e)
        {
            infoPanel = panelInfo;
            active = panelMenuCalc;
            CalcScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            DialogResult dialog = MessageBox.Show("Möchtest du das Programm wirklich beenden?", "Programm schließen?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public static void LoadingScreen()
        {
            infoPanel.Controls.Add(ModuleWaiting.Instance);
            ModuleWaiting.Instance.Dock = DockStyle.Fill;
            ModuleWaiting.Instance.BringToFront();
            ModuleWaiting.timerValue.Start();
        }

        public static void ResultScreen()
        {
            infoPanel.Controls.Add(ModuleResult.Instance);
            ModuleResult.Instance.Dock = DockStyle.Fill;
            ModuleResult.Instance.BringToFront();
            ModuleResult.Refresh();
        }

        public static void CalcScreen()
        {
            infoPanel.Controls.Add(Module1.Instance);
            Module1.Instance.Dock = DockStyle.Fill;
            Module1.Instance.BringToFront();
        }

        public static void ChartScreen()
        {
            infoPanel.Controls.Add(ModuleChart.Instance);
            ModuleChart.Instance.Dock = DockStyle.Fill;
            ModuleChart.Instance.BringToFront();
        }

        public static void SettingsScreen()
        {
            infoPanel.Controls.Add(ModuleSettings.Instance);
            ModuleSettings.Instance.Dock = DockStyle.Fill;
            ModuleSettings.Instance.BringToFront();
        }

        public static void HelpScreen()
        {
            infoPanel.Controls.Add(ModuleHelp.Instance);
            ModuleHelp.Instance.Dock = DockStyle.Fill;
            ModuleHelp.Instance.BringToFront();
        }

        //Button Menu Calc
        private void pictureBoxCalc_MouseEnter(object sender, EventArgs e)
        {
            MenuEvent(panelMenuCalc, true);
        }

        private void pictureBoxCalc_MouseLeave(object sender, EventArgs e)
        {
            MenuEvent(panelMenuCalc, false);
        }

        private void pictureBoxCalc_Click(object sender, EventArgs e)
        {
            MenuActivate(panelMenuCalc);
            CalcScreen();
        }

        //Button Menu Info
        private void pictureBoxInfo_MouseEnter(object sender, EventArgs e)
        {
            MenuEvent(panelMenuInfo, true);
        }

        private void pictureBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            MenuEvent(panelMenuInfo, false);
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            MenuActivate(panelMenuInfo);
            HelpScreen();
            labelTitle.Text = "Bußgeldrechner - Hilfe";
        }

        //Button Menu Chart
        private void pictureBoxChart_MouseEnter(object sender, EventArgs e)
        {
            MenuEvent(panelMenuChart, true);
        }

        private void pictureBoxChart_MouseLeave(object sender, EventArgs e)
        {
            MenuEvent(panelMenuChart, false);
        }

        private void pictureBoxChart_Click(object sender, EventArgs e)
        {
            MenuActivate(panelMenuChart);
            ChartScreen();
        }
        
        //Button Menu Settings
        private void pictureBoxSettings_MouseEnter(object sender, EventArgs e)
        {
            MenuEvent(panelMenuSettings, true);
        }

        private void pictureBoxSettings_MouseLeave(object sender, EventArgs e)
        {
            MenuEvent(panelMenuSettings, false);
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            MenuActivate(panelMenuSettings);
            SettingsScreen();
            labelTitle.Text = "Bußgeldrechner - Einstellungen";
        }
        //

        public void MenuEvent(Panel panel, Boolean enter)
        {
            if(enter)
            {
                menuColors[panel] = panel.BackColor;
                panel.BackColor = Color.FromArgb(50, 50, 50);
            }else
            {
                if(panel == active)
                {
                    panel.BackColor = Color.FromArgb(40, 40, 40);
                    menuColors[panel] = panel.BackColor;
                }
                else
                {
                    panel.BackColor = menuColors[panel];
                }
            }
        }

        public void MenuActivate(Panel panel)
        {
            if(panel != active)
            {
                labelTitle.Text = "Bußgeldrechner";
                active.BackColor = Color.FromArgb(48, 48, 48);
                panel.BackColor = Color.FromArgb(40, 40, 40);
                active = panel;
            }
        }

        private void buttonSrc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Luka3006/Bussgeldrechner");
        }
    }
}
