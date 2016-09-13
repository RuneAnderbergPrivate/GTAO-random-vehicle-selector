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

            Vehicle vehicle = new Vehicle();

            int nrOfVehicles = _vehicles.Garages.Sum(t => t.Vehicles.Count);

            int rndVehicle = random.Next(nrOfVehicles);

            if (rndVehicle < 10)
            {
                vehicle = _vehicles.Garages[0].Vehicles[random.Next(_vehicles.Garages[0].Vehicles.Count)];
            }
            else if (rndVehicle < 20)
            {
                vehicle = _vehicles.Garages[1].Vehicles[random.Next(_vehicles.Garages[1].Vehicles.Count)];
            }
            else if (rndVehicle < 30)
            {
                vehicle = _vehicles.Garages[2].Vehicles[random.Next(_vehicles.Garages[2].Vehicles.Count)];
            }
            else if (rndVehicle < 40)
            {
                vehicle = _vehicles.Garages[3].Vehicles[random.Next(_vehicles.Garages[3].Vehicles.Count)];
            }
            else if (rndVehicle < 46)
            {
                vehicle = _vehicles.Garages[4].Vehicles[random.Next(_vehicles.Garages[4].Vehicles.Count)];
            }

            return vehicle;
        }
    }
}
