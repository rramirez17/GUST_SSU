using Gust.Core.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Gust.Core.Data;
using Gust.Core.Areas.Identity.Data.Forms;
using Microsoft.AspNetCore.Identity;
using Gust.Core.Areas.Identity.Data;

namespace Gust.Core.Controllers
{
    [Authorize(Roles = "Administrador, Tec")]
    public class FormsController : Controller
    {
        private readonly ILogger<FormsController> _logger;
        private readonly GustCoreContext _context;
        private readonly SignInManager<GustCoreUser> _signInManager;

        public FormsController(
            ILogger<FormsController> logger, 
            GustCoreContext context, 
            SignInManager<GustCoreUser> signInManager)
        {
            _logger = logger;
            _context = context;
            _signInManager = signInManager;
        }
        
        // Index
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string IndexSubmit(string data)
        {
            _logger.LogInformation("Model: {data}", data);

            if(data == null)
            {
                return JsonConvert.SerializeObject(null);
            }

            var pruebaForms = JsonConvert.DeserializeObject<PruebaFormsModel>(data);

            if(string.IsNullOrEmpty(pruebaForms.FirstName)) {
                return JsonConvert.SerializeObject(null);
            }

            return JsonConvert.SerializeObject(pruebaForms);
        }

        public IActionResult IndexResult(PruebaFormsModel pruebaForms)
        {
            ViewBag.PruebaForms = pruebaForms;
            return View();
        }

        // Prestamo
        public IActionResult Prestamo()
        {
            return View();
        }

        // Prestamo
        [HttpGet]
        public string GetEquipos()
        {
            try
            {
                var equipos = _context.Equipo.Select(x => new { x.Id, x.NombreEquipo }).ToList();
                return JsonConvert.SerializeObject(equipos);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        [HttpPost]
        public string SubmitPrestamo(string data)
        {
            if (data == null)
            {
                return JsonConvert.SerializeObject(null);
            }

            try
            {
                var prestamo = JsonConvert.DeserializeObject<Prestamo>(data);
                if (prestamo == null)
                {
                    throw new Exception("Null Object");
                }

                prestamo.PersonaEntregaId = _signInManager.UserManager.GetUserId(User);
                
                _context.Prestamo.Add(prestamo);
                _context.SaveChanges();

                return JsonConvert.SerializeObject(prestamo);
            }
            catch(Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}