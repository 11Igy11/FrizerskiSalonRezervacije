using FrizerskiSalonRezervacija.Models;
using Microsoft.EntityFrameworkCore;

namespace FrizerskiSalonRezervacija.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Service> Services { get; set; }
	}
}
