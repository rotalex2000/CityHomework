using System;
using System.Collections.Generic;
using System.Text;

namespace CityHomework
{
    class Street
    {
        public string Name { get; set; }
        public double Length { get; set; }

        public Street(string name, double length)
        {
            Name = name;
            Length = length;
        }
    }
}
