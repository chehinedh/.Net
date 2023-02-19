using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>()
        {
            new Plane{Capacity=150,ManufactureDate=new DateTime(2015,02,03),Planetyp=Planetype.Boing },
            new Plane{Capacity=250,ManufactureDate=new DateTime(2015,11,11),Planetyp=Planetype.Airbus}
        };
        public static List<Staff> Staffs { get; set; } = new List<Staff>()
        {
            new Staff{FirstName="captain",LastName="captain",Emailadress="captain.captain@gmail.com",EmployeementDate=new DateTime(1999,01,01),Salary=99999,BirthDate=new DateTime(1965,01,01)}
        };
        public static List<Traveller> Travellers { get; set; } = new List<Traveller>()
        {
            new Traveller{FirstName="Traveller1",LastName="Traveller1",Emailadress="traveller1.traveller1@gmail.com",
            BirthDate=new DateTime(1980,01,01),Healthinformations="no trobules",Nationality="americain"}
        };
        public static List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight{FlightDate=new DateTime(2022,01,01,15,10,10),Destination="Paris",EffectiveArrival=new DateTime(2022,01,01,17,10,10),EstimatedDuration=110,plane=Planes[1],Passengers=new List<Passenger>(Travellers)}

            
        };
    }
}
