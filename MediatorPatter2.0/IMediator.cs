using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatter2._0
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
