using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GTAO_Random_Vehicle_Selector
{
    [XmlRoot("vehicles")]
    public class Vehicles
    {
        [XmlElement("garage")]
        public List<Garage> Garages = new List<Garage>();
    }

    public class Garage
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("vehicle")]
        public List<Vehicle> Vehicles = new List<Vehicle>();
    }

    public class Vehicle
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("class")]
        public string Class { get; set; }
    }
}
