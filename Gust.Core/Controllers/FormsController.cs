﻿using Gust.Core.Models;
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
    [Authorize(Roles = "Administrador, Tec")]
    public class FormsController : Controller
    {
        private readonly ILogger<FormsController> _logger;
        private readonly GustCoreContext _context;
        private readonly UserManager<GustCoreUser> _userManager;

        public FormsController(
            ILogger<FormsController> logger, 
            GustCoreContext context,
            UserManager<GustCoreUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        
        // Metodo Con mismo nombre que la vista
        public IActionResult Prestamo()
        {
            return View();
        }
        public IActionResult Devolucion()
        {
            return View();
        }

        [HttpGet]
        public string GetEquipos()
        {
            try
            {
                var equipos = _context.Equipo
                    .Where(x => x.Activo && x.Prestamos.Where(y => y.FechaDevolucion == null).Count() == 0)
                    .Select(x => new { x.Id, x.NombreEquipo })
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
        public string GetEquiposPrestados()
        {
            try
            {
                var prestamos = _context.Prestamo
                    .Where(x => x.FechaDevolucion == null)
                    .Include(x => x.Equipo)
                    .Select(x => new { x.Id, x.Equipo.NombreEquipo, x.NombrePersona })
                    .ToList();

                return JsonConvert.SerializeObject(prestamos);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        // Metodo para insertar formulario
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

                prestamo.UsuarioEntregaId = User.FindFirstValue(ClaimTypes.NameIdentifier);

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

        // Metodo para insertar formulario
        [HttpPost]
        public string SubmitDevolucion(int data)
        {
            try
            {
                var prestamo = _context.Prestamo.Where(x => x.Id == data).ToList().FirstOrDefault();
                if(prestamo == null)
                {
                    return JsonConvert.SerializeObject(null);
                }

                prestamo.UsuarioRecibeId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                prestamo.FechaDevolucion = DateTime.Now;

                _context.Prestamo.Update(prestamo);
                _context.SaveChanges();

                return JsonConvert.SerializeObject(prestamo);
            }
            catch (Exception e)
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