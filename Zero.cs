using System;

namespace garygarage
{

    public class Zero : Vehicle, IElectric  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging the battery!");
        }
        public override void Drive()
        {
            Console.WriteLine();
            Console.WriteLine($"The {MainColor} Zero zips by you. ZZZZZZZZZzzzzzzzzz");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"She drifted to the {direction} and into the shoulder.");
        }

        public override void Stop(string person)
        {
            Console.WriteLine($"But it was OK, {person} was just doing her makeup.");
        }

    }

}