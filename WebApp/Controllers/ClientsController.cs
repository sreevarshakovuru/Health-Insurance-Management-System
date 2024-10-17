using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthInsuranceManagement.Data;
using HealthInsuranceManagement.Models;

namespace HealthInsuranceManagement.Controllers
{
    public class ClientsController : Controller
    {
        private readonly HealthInsuranceDbContext _context;

        public ClientsController(HealthInsuranceDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Clients.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,DateOfBirth,Address,PhoneNumber,Email")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }
    }
}
