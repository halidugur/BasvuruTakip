using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BasvuruTakip.Data;
using BasvuruTakip.Models;

namespace BasvuruTakip.Controllers
{
    public class PersonelController : Controller
    {
        private readonly AppDbContext _context;

        public PersonelController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            ViewBag.Iller = new SelectList(_context.Iller.OrderBy(i => i.Adi), "Id", "Adi");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Personel personel)
        {
            personel.DogumTarihi = DateTime.SpecifyKind(personel.DogumTarihi, DateTimeKind.Utc);
            if (ModelState.IsValid)
            {
                _context.Add(personel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            ViewBag.Iller = new SelectList(_context.Iller.OrderBy(i => i.Adi), "Id", "Adi");
            return View(personel);
        }
        public JsonResult GetIlceler(long ilId)
        {
            var ilceler = _context.Ilceler
                .Where(i => i.IlId == ilId)
                .Select(i => new { i.IlceId, i.Adi })
                .ToList();
            return Json(ilceler);
        }
    }
}
