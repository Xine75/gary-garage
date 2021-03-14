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
            Cessna fairy = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = "two"
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


        }
    }
}
