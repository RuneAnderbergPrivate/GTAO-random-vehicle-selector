using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAO_Random_Vehicle_Selector
{
    public class Randomizer
    {
        public Randomizer(Vehicles vehicles)
        {
            _vehicles = vehicles;
        }

        private Vehicles _vehicles;
        
        public Vehicle RandomVehicle ()
        {
            Random random = new Random();

            // List of garages with nrs of them propotional with the amount of vehicles in them
            List<Garage> garages = new List<Garage>();

            foreach (Garage t in _vehicles.Garages)
            {
                for (int j = 0; j < t.Vehicles.Count; j++)
                {
                    garages.Add(t);
                }
            }

            // Randomizes a garage, chance of a garage getting selected is based on the nr of vehicles in them, i.e a 10 car garage is more likely to get selected than a 6 car garage
            Garage garage = garages[random.Next(garages.Count)];

            Vehicle vehicle = garage.Vehicles[random.Next(garage.Vehicles.Count)];

            //Vehicle vehicle = _vehicles.Garages.Find(g => g.Equals(garageName)).Vehicles[random.Next(garageName.Vehicles.Count)];

            //if (rndVehicle < 10)
            //{
            //    vehicle = _vehicles.Garages[0].Vehicles[random.Next(_vehicles.Garages[0].Vehicles.Count)];
            //}
            //else if (rndVehicle < 20)
            //{
            //    vehicle = _vehicles.Garages[1].Vehicles[random.Next(_vehicles.Garages[1].Vehicles.Count)];
            //}
            //else if (rndVehicle < 30)
            //{
            //    vehicle = _vehicles.Garages[2].Vehicles[random.Next(_vehicles.Garages[2].Vehicles.Count)];
            //}
            //else if (rndVehicle < 40)
            //{
            //    vehicle = _vehicles.Garages[3].Vehicles[random.Next(_vehicles.Garages[3].Vehicles.Count)];
            //}
            //else if (rndVehicle < 46)
            //{
            //    vehicle = _vehicles.Garages[4].Vehicles[random.Next(_vehicles.Garages[4].Vehicles.Count)];
            //}

            return vehicle;
        }
    }
}
