using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance.Domain
{
    public class Etudiant : Person
    {
        public int Matricule { get; set; }
        public string? Specialite { get; set; }

        public  void GetMytype()
        {
            Console.WriteLine("Iam a student");
        }

    }
}
