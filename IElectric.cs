using System;
using System.Collections.Generic;

namespace garygarage
{
    public interface IElectric
    {
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }

        void ChargeBattery();

    }


}