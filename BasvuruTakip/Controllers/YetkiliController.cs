using Microsoft.AspNetCore.Mvc;

namespace BasvuruTakip.Controllers
{
    public class YetkiliController : Controller
    {
        [HttpGet]
        public IActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Giris(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "admin" && sifre == "0390")
            {
                HttpContext.Session.SetString("YetkiliMi", "evet");
                return RedirectToAction("Listele", "PersonelIsBasvurusu");
            }
            ViewBag.Hata = "Kullanıcı adı veya şifre hatalı!";
            return View();
        }
        public IActionResult Cikis()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Giris");
        }
    }
}
