using System;

namespace garygarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Midnight Blue",
                MaximumOccupancy = "four"
            };
            Zero snx = new Zero()
            {
                MainColor = "Black",
                MaximumOccupancy = "four"
            };

            Tesla modelS = new Tesla()
            {
                MainColor = "Burgandy",
                MaximumOccupancy = "six"
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = "two"
            };
            Ram f150 = new Ram()
            {
                MainColor = "Silver",
                MaximumOccupancy = "six"
            };

            fxs.Drive();
            snx.Drive();
            modelS.Drive();
            mx410.Drive();
            f150.Drive();
        }
    }
}
