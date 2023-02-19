using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum Planetype
    {
        Boing,
        Airbus
    }
    public class Plane    {
        public int Planeid { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public  Planetype Planetyp { get; set; }

        public List<Flight> flights { get; set; }

        public override string? ToString()
        {
            return Planeid + Capacity +"date:"+ ManufactureDate + Planetyp;
        }

        public Plane(int capacity, DateTime manufactureDate, Planetype planetype)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            Planetyp = planetype;
        }

        public Plane()
        {
        }
    }
}

