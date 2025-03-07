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
    public partial class ctrlTrafficLight : UserControl
    {
        public enum enLight { Red = 0, Yellow = 1, Green = 2 };
        
        private enLight _CurrentLight = enLight.Red;
        public enLight CurrentLight
        {
            get { return _CurrentLight; }
        
            set 
            { 
                _CurrentLight = value; 
                
                switch (value)
                {
                    case enLight.Red:
                        pbLight.Image = Properties.Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                        break;
                        
                    case enLight.Yellow:
                        pbLight.Image = Properties.Resources.Yellow;
                        lblCountDown.ForeColor = Color.Yellow;
                        break;
                        
                    case enLight.Green:
                        pbLight.Image = Properties.Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                        break;

                    default:
                        pbLight.Image = Properties.Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                        break;

                }

            }
        }

        private int _CurrentCountDownValue = 0;

        private int _RedLightTime = 10;
        private int _YellowLightTime = 3;
        private int _GreenLightTime = 10;
        
        public int RedLightTime { get { return _RedLightTime; } set { _RedLightTime = value; } }
        public int YellowLightTime { get { return _YellowLightTime; } set { _YellowLightTime = value; } }
        public int GreenLightTime { get { return _GreenLightTime; } set { _RedLightTime = value; } }

        public class TrafficLightEventArgs : EventArgs
        {
            public enLight CurrentLight { get; }
            public int LightDuration { get; }

            public TrafficLightEventArgs(enLight currentLight, int lightDuration)
            {
                CurrentLight = currentLight;
                LightDuration = lightDuration;
            }
        }

        public event EventHandler<TrafficLightEventArgs> TrafficLightChanged;
        public event EventHandler<TrafficLightEventArgs> RedLightOn;
        public event EventHandler<TrafficLightEventArgs> RedLightOff;
        public event EventHandler<TrafficLightEventArgs> YellowLightOn;
        public event EventHandler<TrafficLightEventArgs> YellowLightOff;
        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        public event EventHandler<TrafficLightEventArgs> GreenLightOff;

        protected virtual void RaiseTrafficLightChanged(TrafficLightEventArgs e)
        {
            TrafficLightChanged.Invoke(this, e);
        }
        protected virtual void RaiseRedLightOn(TrafficLightEventArgs e)
        {
            RedLightOn.Invoke(this, e);
        }
        protected virtual void RaiseRedLightOff(TrafficLightEventArgs e)
        {
            RedLightOff.Invoke(this, e);
        }
        protected virtual void RaiseYellowLightOn(TrafficLightEventArgs e)
        {
            YellowLightOn.Invoke(this, e);
        }
        protected virtual void RaiseYellowLightOff(TrafficLightEventArgs e)
        {
            YellowLightOff.Invoke(this, e);
        }
        protected virtual void RaiseGreenLightOn(TrafficLightEventArgs e)
        {
            GreenLightOn.Invoke(this, e);
        }
        protected virtual void RaiseGreenLightOff(TrafficLightEventArgs e)
        {
            GreenLightOff.Invoke(this, e);
        }

        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        public int GetCurrentTime()
        {
            switch (_CurrentLight)
            {
                case enLight.Red:
                    return RedLightTime;
                    
                case enLight.Yellow:
                    return YellowLightTime;
                    
                case enLight.Green:
                    return GreenLightTime;

                default:
                    return RedLightTime;

            }
        }

        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            LightTimer.Start();
        }
        public void Stop()
        {
            LightTimer.Stop();
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
