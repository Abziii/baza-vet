using System;


namespace baza_vet.Modele
{
    public class Appointments
    {

        public int Id { get; set; }
        public int Animal_Id { get; set; }

        public int Doctor_Id { get; set; }

        public DateTime? Appointment_Date { get; set; }
        public string Notes { get; set; }

    }
}