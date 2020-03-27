using System;
using MediatorPatter2._0.Components;

namespace MediatorPatter2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            Display display = new Display();
            RFIDScanner rfid = new RFIDScanner();
            Charger charger = new Charger();

            new LadeSkabMediator(door, display, charger, rfid);

            door.OpenDoor();
        }
    }
}
