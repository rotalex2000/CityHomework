using System;
using System.Collections.Generic;
using System.Text;

namespace CityHomework
{
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public List<Street> Streets { get; set; }
        public List<Quarter> Quarters { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public void addStreet(string streetName, double streetLength)
        {
            Streets.Add(new Street(streetName, streetLength));
        }

        public void addQuarter(string quarterName, double quarterArea)
        {
            Quarters.Add(new Quarter(quarterName, quarterArea));
        }

        public void incrementPopulation()
        {
            Population++;
        }

        override public String ToString()
        {
            return Name;
        }
    }
}
