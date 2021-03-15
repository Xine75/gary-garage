using System;
using System.Collections.Generic;

namespace garygarage
{

    public interface IGas
    {
        void RefuelTank();
        int CurrentTankPercentage { get; set; }

    }
}