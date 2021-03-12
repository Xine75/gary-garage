using System;

namespace garygarage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine();
        }

    }


}