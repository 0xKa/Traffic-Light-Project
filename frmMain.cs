using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void ctrlTrafficLight1_RedLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            ctrlTrafficLight2.CurrentLight = ctrlTrafficLight.enLight.Yellow;
            ctrlTrafficLight2.Start();

        }

        private void ctrlTrafficLight2_RedLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            ctrlTrafficLight3.CurrentLight = ctrlTrafficLight.enLight.Yellow;
            ctrlTrafficLight3.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Start();
            ctrlTrafficLight2.Start();
            ctrlTrafficLight3.Start();
        }
    }
}
