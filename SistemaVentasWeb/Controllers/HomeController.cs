using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SistemaVentasWeb.Data;
using SistemaVentasWeb.Models;

namespace SistemaVentasWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ProductosContext _context;

        public HomeController(ProductosContext context)
        {
            _context = context;
        }


        /*  public HomeController(ILogger<HomeController> logger)
          {
              _logger = logger;
          }
          */

        public async Task<IActionResult> IndexAsync()
        {
            List<Producto> myList = new List<Producto>();
            var productos = await _context.Productos.Include(d => d.Detalle).AsNoTracking().ToListAsync();
            foreach (var item in productos)
            {
                myList.Add(item);
            }
            ViewBag.List = myList;
            
            return View();
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
