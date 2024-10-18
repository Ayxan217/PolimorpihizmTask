using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphizm_Task.Models
{
    internal class Car:Vehicle
    {
        public int DoorCount;
        public bool IsElectiricCar;

        public Car(string name, string model, string color, int time, int path, int door, bool isElectric)
       : base(name, model, color, time, path)
        {
            DoorCount = door;
            IsElectiricCar = isElectric;
        }

    
        public  void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Doorcount: { DoorCount}, electiric: {IsElectiricCar}");
            
        }
        public override void NatureHarmness()
        {
            if (IsElectiricCar)
            {
                Console.WriteLine("harmness: Low");
            }
            else
            {
                Console.WriteLine("harmness: High");
            }
        }
        public override string ToString()
        {
            return $"Factory: {FactoryName}, Model: {Model}";
        }
    }
}
