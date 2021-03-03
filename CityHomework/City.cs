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
        public List<Building> Buildings { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public void addStreet(Street street)
        {
            Streets.Add(street);
        }

        public void addQuarter(Quarter quarter)
        {
            Quarters.Add(quarter);
        }

        public void addBuilding(Building building)
        {
            Buildings.Add(building);
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
