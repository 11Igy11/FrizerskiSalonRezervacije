using System;

namespace FrizerskiSalonRezervacija.Models
{
    public class Reservation
    {
        public int Id { get; set; } // Primarni ključ
        public string TimeSlot { get; set; } = string.Empty; // Termin rezervacije
        public DateTime Date { get; set; } // Datum rezervacije

        // Strani ključ za korisnika
        public int UserId { get; set; }
        public User User { get; set; } = null!; // Navigacijsko svojstvo prema korisniku

        // Strani ključ za uslugu
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!; // Navigacijsko svojstvo prema usluzi
    }
}
