using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CountriesUseAjax.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CountriesUseAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CountriesUseAjaxContext _context;


        public HomeController(ILogger<HomeController> logger, CountriesUseAjaxContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Province = _context.Provinces.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            return View();
        }

        [HttpGet]
        public JsonResult GetDistricts(int provinceId)
        {
            var temp = _context.Districts.Where(x => x.ProvinceId == provinceId).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();

            return Json(temp);
        }

        [HttpGet]
        public JsonResult GetWards(int districtId)
        {
            var temp = _context.Wards.Where(x => x.DistrictId == districtId).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();

            return Json(temp);
        }

        public IActionResult Privacy()
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
