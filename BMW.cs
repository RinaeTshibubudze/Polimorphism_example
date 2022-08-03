using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphisnC
{
    public class BMW:Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + "HP: " + "color: " + Color );
        }

        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }
    }
}