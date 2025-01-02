using System.Collections.Generic;

namespace FrizerskiSalonRezervacija.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty; // Zadana vrijednost
		public string Email { get; set; } = string.Empty; // Zadana vrijednost
		public List<Reservation>? Reservations { get; set; } // Nullable svojstvo
	}

}
