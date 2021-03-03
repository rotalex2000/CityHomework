using System;
using System.Collections.Generic;
using System.Text;

namespace CityHomework
{
    abstract class Building
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public DateTime BuildDate { get; set; }
    }
}
