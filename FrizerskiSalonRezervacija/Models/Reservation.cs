using System;

namespace FrizerskiSalonRezervacija.Models
{
	public class Reservation
	{
		public int Id { get; set; }
		public string TimeSlot { get; set; } = string.Empty; // Zadana vrijednost
		public User? User { get; set; } // Nullable svojstvo
		public Service? Service { get; set; } // Nullable svojstvo
		public DateTime Date { get; set; }
	}

}
