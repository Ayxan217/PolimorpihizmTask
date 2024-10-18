using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphizm_Task.Models
{
    internal class Bicycle:Vehicle
    {
        public string Type;

        public Bicycle(string name, string model, string color, int time, int path, string type) : base(name, model, color, time, path)
        {
            Type = type;
        }

       
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Type: {Type}");
        }
        public override void NatureHarmness()
        {
            Console.WriteLine("harmness: None");
        }
        public override string ToString()
        {
            return $"Factory: {FactoryName}, Model: {Model}";
        }

    }
}
