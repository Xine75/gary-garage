using System;
using System.Collections.Generic;

namespace garygarage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance

            Zero fxs = new Zero()
            {
                MainColor = "Midnight Blue",
                MaximumOccupancy = "four",
                CurrentChargePercentage = 40,
            };
            Zero snx = new Zero()
            {
                MainColor = "Black",
                MaximumOccupancy = "four",
                CurrentChargePercentage = 56,
            };

            Tesla modelS = new Tesla()
            {
                MainColor = "Burgandy",
                MaximumOccupancy = "six",
                CurrentChargePercentage = 72,
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = "two",
                CurrentTankPercentage = 88,
            };
            Ram f150 = new Ram()
            {
                MainColor = "Silver",
                MaximumOccupancy = "six",
                CurrentTankPercentage = 27,
            };


            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop("the woman inside");

            snx.Drive();
            snx.Turn("right");
            snx.Stop("a drag queen");


            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop("Ron Howie");

            mx410.Drive();
            mx410.Turn("down");
            mx410.Stop("Big Bird");

            f150.Drive();
            f150.Turn("right");
            f150.Stop("a horse");

            //Interfaces

            List<IElectric> electricVehicles = new List<IElectric>() {
                fxs, snx, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"The {ev.GetType().Name} is currently {ev.CurrentChargePercentage}% full");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"The {ev.GetType().Name} is now {ev.CurrentChargePercentage}% full");
            }

            /***********************************************/


            List<IGas> gasVehicles = new List<IGas>() {
                f150, mx410
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"The {gv.GetType().Name} is currently {gv.CurrentTankPercentage}% full");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"The {gv.GetType().Name} is now {gv.CurrentTankPercentage}% full");
            }



        }

    }
}
