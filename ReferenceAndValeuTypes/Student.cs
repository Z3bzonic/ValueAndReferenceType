using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValeuTypes
{
    internal class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Woonplaats { get; set; }

        public Student(string naam, int leeftijd, string woonplaats)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Woonplaats = woonplaats;
        }


        public override string ToString() // om alle values weer te geven in het object
        {
            return $"naam: {Naam}, leeftijd: {Leeftijd}, woonplaats: {Woonplaats}";
        }
    }
}
