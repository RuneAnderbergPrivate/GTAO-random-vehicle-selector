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

            // Makes a list of garages with nrs of them in the list proportional with the amount of vehicles in the garage
            List<Garage> garages = new List<Garage>();
            foreach (Garage t in _vehicles.Garages)
            {
                for (int j = 0; j < t.Vehicles.Count; j++)
                {
                    garages.Add(t);
                }
            }

            // Selects a random garage and chooses a random vehicle from that garage. The chance of getting a specific car is the same regardless of the size of the garage the car is in
            Garage garage = garages[random.Next(garages.Count)];
            Vehicle vehicle = garage.Vehicles[random.Next(garage.Vehicles.Count)];

            return vehicle;
        }
    }
}
