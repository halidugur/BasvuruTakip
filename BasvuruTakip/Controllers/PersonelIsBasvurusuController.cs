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
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var basvuru = await _context.PersonelIsBasvurulari.FindAsync(id);
            if (basvuru != null)
            {
                _context.PersonelIsBasvurulari.Remove(basvuru);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Listele"); 
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
                    Id = b.Id,

                    Tarih = b.BasvuruTarihi.ToString("dd.MM.yyyy"),
                    Il = _context.Iller.FirstOrDefault(i => i.Id == b.IlId)!.Adi,
                    Seyahat = b.SeyahatEngeliYok ? "Yok" : "Var",
                    b.IsyeriAdi,
                    b.Pozisyon,
                    b.Aciklama
                }).ToList();
            return Json(basvurular);
        }
        public JsonResult GetPersonelBilgi(long personelId)
        {
            var personel = _context.Personeller
                .Where(p => p.Id == personelId)
                .Select(p => new
                {
                    p.AdiSoyadi,
                    p.Cinsiyet,
                    DogumTarihi = p.DogumTarihi.ToString("dd.MM.yyyy"),
                    Il = _context.Iller.FirstOrDefault(i => i.Id == p.IlId)!.Adi,
                    Ilce = _context.Ilceler.FirstOrDefault(il => il.IlceId == p.IlceId && il.IlId == p.IlId)!.Adi,
                    p.Aciklama
                }).FirstOrDefault();

            return Json(personel);
        }









    }
}
