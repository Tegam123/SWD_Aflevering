using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatter2._0.Components
{
    public class RFIDScanner : BaseComponent
    {
        private int _id; 
        public void RfidDetected(int id)
        {
            _id = id;
            _mediator.Notify(this,"RFIDDetected");
        }

        public void SimulateRfid()
        {
            
            string idstring = Console.ReadLine();
            int id = Convert.ToInt32(idstring);
            RfidDetected(id);
        }


    }
}
