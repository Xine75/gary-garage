using System;

namespace garygarage
{
    public class Cessna : Vehicle, IGas  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            Console.WriteLine("The tank is filling up!");
        }
        public override void Drive()
        {
            Console.WriteLine();
            Console.WriteLine($"The {MainColor} Cessna flies over you. Zeeeeeeeeer!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"It glided {direction}.");
        }

        public override void Stop(string person)
        {
            Console.WriteLine($"{person} brought it to a smooth stop on the runway.");
        }
    }

}