using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Interfaces
{
    interface IFigure
    {
        IFigure Clone();

        void GetInfo();
    }
}
