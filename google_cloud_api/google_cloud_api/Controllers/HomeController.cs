using google_cloud_api.Data;
using google_cloud_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace google_cloud_api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;
        public HomeController(ILogger<HomeController> logger,MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<Person> Index()
        {
            return _context.Person.ToList();
        }
        public IEnumerable<Locations> Get()
        {
            return _context.Locations.ToList();
        }
        public int Sil([FromBody] IdList id_list)
        {
            int id = id_list.Id;
            var x=_context.Locations.Find(id);
            _context.Locations.Remove(x);
            _context.SaveChanges();
            return id_list.Id;
        }

        public async Task<ActionResult<string>> Post([FromBody] Person person)
        {
            _context.Person.Add(person);
            await _context.SaveChangesAsync();
            return person.Name;
        }
        public async Task<ActionResult<int>> Konum([FromBody] Locations location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return location.Id;
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
