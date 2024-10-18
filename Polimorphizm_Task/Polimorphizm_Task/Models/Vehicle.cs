using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphizm_Task.Models
{
    internal abstract class Vehicle
    {
        public string FactoryName;
        public string Model;
        public string Color;
        public int DriveTime;
        public int DrivePath;

        public Vehicle(string name, string model, string color, int time, int path)
        {
            FactoryName = name;
            Model = model;
            Color = color;
            DriveTime = time;
            DrivePath = path;
        }


        public  void AverageSpeed()
        {
            int speed = DrivePath / DriveTime;
            Console.WriteLine($"{Model}'s average speed: {speed}");
        }
        
        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory: {FactoryName}, Model: {Model}, Color:{Color}, Distance:{DrivePath} km/h, Time: {DriveTime} Hours");

        }
     

        public abstract void NatureHarmness();

     
    }
}
