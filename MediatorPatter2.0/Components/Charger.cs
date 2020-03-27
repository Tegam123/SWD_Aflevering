using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatter2._0
{
    public class Charger : BaseComponent
    {
        public bool IsConnected { get; set; }
        private bool IsCharging { get; set;  }
        
        public void StartCharge()
        {
            IsCharging = true;
        }

        public void StopCharge()
        {
            IsCharging = false;
        }

        public void SimulateconnectingPhone(bool val)
        {
            IsConnected = val;
        }
    }
}
