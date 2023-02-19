using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string Passportnumber { get; set; }
        public string Emailadress { get; set; }
            
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public  int Telnumber { get; set; }

        public List<Flight> Flights { get; set; }

        public override string? ToString()
        {
            return FirstName + LastName ;
        }


        //public bool CheckProfile(string nom , string prenom)
        //{
        //    return (nom==FirstName && prenom==LastName);
        //}
        //public bool CheckProfile(string nom, string prenom,string email)
        //{
        //    return (nom == FirstName && prenom == LastName && email==Emailadress);

        //}
        public bool Checkprofile(string nom, string prenom, string email=null)
        {
            if (email == null)
            {
              return (nom == FirstName && prenom == LastName);

            }
            else
                return (nom == FirstName && prenom == LastName && email == Emailadress);
        }

        public virtual void  PassengerType()
        {
            Console.WriteLine("I am Passenger");
        }


    }
}
