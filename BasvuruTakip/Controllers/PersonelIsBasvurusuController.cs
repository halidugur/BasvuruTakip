using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasvuruTakip.Data;
using BasvuruTakip.Models;

namespace BasvuruTakip.Controllers
{
    public class PersonelIsBasvurusuController : Controller
    {
        private readonly AppDbContext _context;

        public PersonelIsBasvurusuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewBag.Iller = new SelectList(_context.Iller.OrderBy(i => i.Adi), "Id", "Adi");
            ViewBag.Personeller = new SelectList(_context.Personeller, "Id", "AdiSoyadi");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonelIsBasvurusu basvuru)
        {
            basvuru.BasvuruTarihi = DateTime.SpecifyKind(basvuru.BasvuruTarihi, DateTimeKind.Utc);

            if (ModelState.IsValid)
            {
                _context.PersonelIsBasvurulari.Add(basvuru);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }

            ViewBag.Iller = new SelectList(_context.Iller.OrderBy(i => i.Adi), "Id", "Adi");
            ViewBag.Personeller = new SelectList(_context.Personeller, "Id", "AdiSoyadi");
            return View(basvuru);
        }

        public JsonResult GetIlceler(long ilId)
        {
            var ilceler = _context.Ilceler
                .Where(i => i.IlId == ilId)
                .Select(i => new { i.IlceId, i.Adi })
                .ToList();
            return Json(ilceler);
        }



        //*------------------------------



        public IActionResult Listele()
        {
            // 🔐 Eğer giriş yapılmamışsa giriş sayfasına yönlendir
            if (HttpContext.Session.GetString("YetkiliMi") != "evet")
            {
                return RedirectToAction("Giris", "Yetkili");
            }

            ViewBag.Personeller = new SelectList(_context.Personeller.OrderBy(p => p.AdiSoyadi), "Id", "AdiSoyadi");
            return View();
        }



        public JsonResult GetBasvurular(long personelId)
        {
            var basvurular = _context.PersonelIsBasvurulari
                .Where(b => b.PersonelId == personelId)
                .Select(b => new
                {
                    Tarih = b.BasvuruTarihi.ToString("dd.MM.yyyy"),
                    Il = _context.Iller.FirstOrDefault(i => i.Id == b.IlId)!.Adi,
                    Seyahat = b.SeyahatEngeliYok ? "Yok" : "Var",
                    b.IsyeriAdi,
                    b.Pozisyon,
                    b.Aciklama
                }).ToList();

            return Json(basvurular);
        }








    }
}
