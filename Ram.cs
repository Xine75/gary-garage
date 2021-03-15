using System;

namespace garygarage
{
    public class Ram : Vehicle, IGas  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("The tank is filling up!");
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine();
            Console.WriteLine($"The {MainColor} Ram thunders past you. Assholes.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The damn thing did a hard {direction} and cut me off.");
        }

        public override void Stop(string person)
        {
            Console.WriteLine($"Things got scary when the Ram stopped and {person} got out.");
        }
    }

}
