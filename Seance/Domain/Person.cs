using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance.Domain
{
    public class Person
    {
        public Person(string nom, string prenom, string email, string password, DateTime dateNaissance)

        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
            DateNaissance = dateNaissance;
        }

        public Person()
        {
        }
        
        public int Id { get; set; }
        public string Nom { get; set; }


        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateNaissance { get; set; }

        public override string ToString()
        {
            return $"id={Id};Nom={Nom},Prenom={Prenom},Email={Email},Password={Password},Datedenaissance={DateNaissance}";
        }

        public bool Login(string nom, string password)
        {
            return (nom == Nom && password == Password);
            
        }

        public bool login(string nom, string password,string email=null)
        {
            return (nom == Nom && password == Password && (email == Email || email == null)) ; 

        }
        public  void GetMytype() {
            Console.WriteLine("Iam a Person");
        }









    }
}
