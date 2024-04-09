using dsdttphcm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dsdttphcm.Controllers
{
    public class DetailsController : Controller
    {
        private readonly ILogger<DetailsController> _logger;

        public DetailsController(ILogger<DetailsController> logger)
        {
            _logger = logger;
        }

        

        public IActionResult Page1()
        {
            return View();
        }

        public IActionResult The_thong_hanh()
        {
            return View();
        }

        public IActionResult Ky_niem_68_nam()
        {
            return View();
        }
        
        public IActionResult Pho_thu_tuong_hoang_trung_hai()
        {
            return View();
        }
        
        public IActionResult Thong_bao_moi_thau()
        {
            return View();
        }
        
        public IActionResult Sang_tao_doi_moi()
        {
            return View();
        }

        public IActionResult QLDSDT_hop_bao_nam_2015()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
