using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }  
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
<<<<<<< HEAD

        [ForeignKey("Plane")]
        public int PlaneId { get; set; }
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
        public Plane plane { get; set; }
        
        public IList<Passanger> passangers { get; set; }
        public override string ToString()
        {
            return $"FlightId: {FlightId}, Destination: {Destination}, Departure: {Departure}, FlightDate: {FlightDate}, EffectiveArrival: {EffectiveArrival}, EstimatedDuration: {EstimatedDuration}";
        }
    }
}
