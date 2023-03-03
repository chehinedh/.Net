using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing,Airbus
    }
    public class Plane
    {
        public Plane() { }
<<<<<<< HEAD
        [Key]

        public int PlaneId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive integer")]
=======
        public int PlaneId { get; set; }    
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }

        public IList<Flight> flights { get; set; }
        public override string ToString()
        {
            return $"PlaneID: {PlaneId}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType}";
        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }
    }
}
