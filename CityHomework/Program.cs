using System;

namespace CityHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            City oradea = new City("Oradea", 201500);

            Quarter cantemir = new Quarter("Cantemir", 200);
            Quarter nufarul = new Quarter("Nufarul", 500);
            Quarter iosia = new Quarter("Oncea", 400);

            oradea.addQuarter(cantemir);
            oradea.addQuarter(nufarul);
            oradea.addQuarter(iosia);

            Street bvdCantemir = new Street("Bvd. Dimitrie Cantemir", 90);

            oradea.addStreet(bvdCantemir);

            School uo = new School("Universitatea din Oradea", 800, SchoolLevel.University);

            oradea.addBuilding(uo);

            oradea.incrementPopulation();

            Console.WriteLine(oradea);
        }
    }
}
