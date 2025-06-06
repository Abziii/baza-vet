using System;

namespace baza_vet.Modele
{
    public class Doctors
    {
        public int Id { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Specialization { get; set; }

        public string? Username { get; set; }
        public string? Password_Hash { get; set; }
    }
}