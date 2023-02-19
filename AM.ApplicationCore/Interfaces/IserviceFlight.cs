using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IserviceFlight
    {

        public List<DateTime> DateTimes(string d);
        public IEnumerable<DateTime> DateTimes2(string d);

        // public void GetFlights(string filtertype, string filtervalue);
        public void GetFlights(string filtervalue, Func<string, Flight, Boolean> func);

    }
}
