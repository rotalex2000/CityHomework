using System;
using System.Collections.Generic;
using System.Text;

namespace CityHomework
{
    class School : Building
    {
        public SchoolLevel Level { get; set; }
        public School(string name, double height, SchoolLevel level)
        {
            Name = name;
            Height = height;
            Level = level;
        }
    }
}
