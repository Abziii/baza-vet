using System;

namespace baza_vet.Modele
{
    public class Vaccinations
    {
        public int Id { get; set; }
        public int Animal_Id { get; set; }
        public string Vaccine_Name { get; set; }
        public DateTime? Date_Given { get; set; }
        public Animal animal { get; set; } = null!;
    }
}
