using System;

namespace garygarage
{

    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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