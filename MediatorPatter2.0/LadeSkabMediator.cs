using System;
using System.Collections.Generic;
using System.Text;
using MediatorPatter2._0.Components;

namespace MediatorPatter2._0
{
    public class LadeSkabMediator: IMediator
    {
        private Door _door;
        
        private Display _display;
        private Charger _charger;
        private RFIDScanner _rfidScanner;

        public LadeSkabMediator(Door door, Display display, Charger charger, RFIDScanner RfidScanner)
        {
            _display = display;
            _door = door;
            _charger = charger;
            _rfidScanner = RfidScanner;
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "OpenDoor")
            {
                _display.print("Door has been opened");
                _display.print("Connect phone");
            }

            if (ev == "CloseDoor")
            {
                _display.print("Door has been Closed");
                _display.print("Give Pin");
            }

            if (ev == "RFIDDetected")
            {
                _door.
                _door.LockDoor();

                if (_charger.IsConnected)
                {
                    _charger.StartCharge();
                    _display.print("Charge has been started");
                }
                else
                {
                    _display.print("Phone not connected. No charge started");
                }
                
            }



            
        }
    }
}
