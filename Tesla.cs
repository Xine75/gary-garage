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
            Console.WriteLine();
            Console.WriteLine($"The {MainColor} Tesla sweeps past you. Ssssssssss..");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"It veered alarmingly to the {direction}.");
        }

        public override void Stop(string person)
        {
            Console.WriteLine($"And did three flips before coming to a stop and allowing {person} to escape unscathed.");
        }



    }


}