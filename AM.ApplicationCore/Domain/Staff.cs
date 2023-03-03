using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passanger
    {
       public DateTime EmployementDate { get; set; }
       public string Function { get; set; }
<<<<<<< HEAD
        [DataType(DataType.Currency)]

        public int Salary { get; set; }
        public override string ToString()
        {
            return base.ToString()+ $"EmployementDate : {EmployementDate}, Function: {Function}, Salary: {Salary}";
=======
       public int Salary { get; set; }
        public override string ToString()
        {
            return base.ToString()+ $"EmployementDate: {EmployementDate}, Function: {Function}, Salary: {Salary}";
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
        }

        public override void PassangerType()
        {
            base.PassangerType();
            Console.WriteLine("staf");

        }

    }
}
