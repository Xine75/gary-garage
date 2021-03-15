using System;

namespace garygarage
{
    public class Tesla : Vehicle, IElectric  // Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine("Charging the battery!");
            CurrentChargePercentage = 100;
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