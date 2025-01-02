using Microsoft.AspNetCore.Mvc;
using FrizerskiSalonRezervacija.Data;
using FrizerskiSalonRezervacija.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

public class ReservationController : Controller
{
    private readonly ApplicationDbContext _context;

    public ReservationController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Akcija za prikaz dostupnih termina
    public async Task<IActionResult> Index()
    {
        var reservations = await _context.Reservations
            .Include(r => r.User)
            .Include(r => r.Service)
            .ToListAsync();
        return View(reservations);
    }

    // Akcija za dodavanje nove rezervacije (GET)
    public IActionResult Create()
    {
        // Učitavanje korisnika i usluga iz baze
        ViewBag.Services = _context.Services.ToList();
        ViewBag.Users = _context.Users.ToList();
        return View();
    }

    // Akcija za dodavanje nove rezervacije (POST)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Reservation reservation)
    {
        if (ModelState.IsValid)
        {
            _context.Add(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Ako postoji greška, ponovno proslijedi korisnike i usluge
        ViewBag.Services = _context.Services.ToList();
        ViewBag.Users = _context.Users.ToList();
        return View(reservation);
    }
}
