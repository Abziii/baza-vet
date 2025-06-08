using System;
using System.Numerics;
using baza_vet.Modele;
namespace baza_vet.Modele
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Species { get; set; }
        public string Breed { get; set; }
        public DateTime? Birth_Date { get; set; }
        public string? Owner_Name { get; set; }
        public ICollection<Doctors> doctors { get; set; } = new List<Doctors>();
        public ICollection<Vaccinations> vaccinations { get; set; } = new List<Vaccinations>();
        public ICollection<Appointments> appointments { get; set; } = new List<Appointments>(); public override string ToString()
        {
            return $"Imie: {Name}    Gatunek: {Species} Rasa: {Breed}   Właściciel:{Owner_Name}"; // albo coś bardziej czytelnego
        }
    }
}