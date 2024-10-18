using Polimorphizm_Task.Models;

namespace Polimorphizm_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new ("BMW","530i","red",3,360,4,true);
            Car car2 = new("Volkswagen", "passat", "grren", 4, 408, 2, false);
            Bicycle bicycle = new Bicycle("porche", "911gt", "black", 1, 30, "sport");
            Bicycle bicycle2 = new Bicycle("mercedes", "maybach", "blue", 2, 50, "classic");
            car.AverageSpeed();
            bicycle.AverageSpeed();
            car.GetInfo();
            car.NatureHarmness();
            bicycle.GetInfo();
            bicycle.NatureHarmness();
            

            Vehicle[] vehicles =  { car,car2, bicycle,bicycle2 };
            foreach (var item in vehicles)
            {
                Console.WriteLine(item.ToString());
            }






        }
    }
}
