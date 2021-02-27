using System;
using System.Collections.Generic;
using System.Text;

namespace CityHomework
{
    class Quarter
    {
        public string Name { get; set; }
        public double Area { get; set; }
        
        public Quarter(string name, double area)
        {
            Name = name;
            Area = area;
        }
    }
}
