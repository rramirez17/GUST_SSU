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


        // Metodo para registrar un equipo
        [HttpPost]
        public string registrarEquipo(string data)
        {
            if (data == null)
            {
                return JsonConvert.SerializeObject(null);
            }

            try
            {
                var registro = JsonConvert.DeserializeObject<Equipo>(data);
                if (registro == null)
                {
                    throw new Exception("Null Object");
                }

                _context.Equipo.Add(registro);
                _context.SaveChanges();

                return JsonConvert.SerializeObject(registro);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }


        [HttpGet]
        public string GetEquiposInventario()
        {
            try
            {
                var equipos = _context.Equipo
                    .Select(x => new { x.Id, x.NombreEquipo, x.Modelo })
                    .ToList();

                return JsonConvert.SerializeObject(equipos);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        [HttpGet]
        public string GetEquipoByCodigo (string data)
        {
            if (data == null)
            {
                return JsonConvert.SerializeObject(null);
            }

            try
            {
                var registro = JsonConvert.DeserializeObject<Equipo>(data);
                if (registro == null)
                {
                    throw new Exception("Null Object");
                }

                var equipoConsultado = _context.Equipo
                    .Where(x => x.CodigoBienesPatrimoniales == registro.CodigoBienesPatrimoniales)
                    .Select(x => new { x.Id, x.NombreEquipo, x.Modelo, x.VidaUtilEstimada })
                    .ToList();

                return JsonConvert.SerializeObject(equipoConsultado);

            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        [HttpGet]
        public string GetLaboratorios()
        {
            try
            {
                var laboratorios = _context.Laboratorio
                    .Select(x => new { x.Id, x.Codigo })
                    .ToList();

                return JsonConvert.SerializeObject(laboratorios);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }
    }
}
