using System;
using System.Collections.Generic;
using System.Text;

namespace ProductRWGillFisherErik
{
    class Apparel : Product
    {
        public Apparel() { }

        public Apparel(string type, string id, string desc, double price, int qty, string material, 
                            string color, string manufacturer) : base(type, id, desc, price, qty)
        {
            this.Material = material;
            this.Color = color;
            this.Manufacturer = manufacturer;
        }

        public string Material { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }

        public override string GetDisplayText(string sep) => base.GetDisplayText(sep) + sep + this.Material + sep + this.Color + sep + this.Manufacturer;

        public override string ToString()
        {
            return this.GetDisplayText("\r\n");
        }

        public override string ToCSV() => this.GetDisplayText(",");
    }
}
