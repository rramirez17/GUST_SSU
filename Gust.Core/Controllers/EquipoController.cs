using Gust.Core.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Gust.Core.Data;
using Gust.Core.Areas.Identity.Data.Forms;
using Microsoft.AspNetCore.Identity;
using Gust.Core.Areas.Identity.Data;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Gust.Core.Controllers
{
    public class EquipoController : Controller
    {
        private readonly ILogger<EquipoController> _logger;
        private readonly GustCoreContext _context;
        private readonly UserManager<GustCoreUser> _userManager;

        public EquipoController(
            ILogger<EquipoController> logger,
            GustCoreContext context,
            UserManager<GustCoreUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        //Metodos de Navegacion
        public IActionResult Inventario()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }

        public IActionResult Eliminar()
        {
            return View();
        }

        public IActionResult Actualizar()
        {
            return View();
        }
    }
}
