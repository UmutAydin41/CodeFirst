using Microsoft.AspNetCore.Mvc;
using CodeFirst.Models;
namespace CodeFirst.Controllers

{
    public class UrunController : Controller
    {
        private readonly UrunDbContext _context;
        public UrunController(UrunDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var urunler = _context.Uruns.ToList();
            return View(urunler);
        }
        public IActionResult VeriEkle()
        {
            var yeniUrun = new Urun
            {
                UrunAd = "Oyuncu Klavyesi",
                Fiyat = 2500,
                Stok = 15
            };
            _context.Uruns.Add(yeniUrun);
            _context.SaveChanges();
            return Content("Veri Eklendi");
        }
    }
}
