using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatter2._0
{
    public class Door : BaseComponent
    {
        public bool IsLocked { get; set; }
        public bool IsOpen { get; set; }
        public void OpenDoor()
        {
            if (IsLocked)
            {
                
            }
            else
            {
                this._mediator.Notify(this, "OpenDoor");
            }
            
        }

        public void CloseDoor()
        {
            this._mediator.Notify(this,"CloseDoor");
        }

        public void LockDoor()
        {
            if (IsOpen)
            {
                
            }
            else
            {
                IsLocked = true;
            }
            
        }
        public void UnLockDoor()
        {
            IsLocked = false;
        }
    }
}
