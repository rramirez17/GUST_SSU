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
using Gust.Core.Areas.Identity.Data.Tasks;
using Microsoft.Win32;

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
        public IActionResult PrestamoLab()
        {
            return View();
        }
        public IActionResult Devolucion()
        {
            return View();
        }
        public IActionResult DevolucionLab()
        {
            return View();
        }

        public IActionResult Tareas()
        {
            return View();
        }

        public IActionResult RegistrarTarea()
        {
            return View();
        }

        public IActionResult ActualizarTarea()
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

        public string GetEquiposInventario()
        {
            try
            {
                var equipos = _context.Equipo
                    .Select(x => new { x.Id, x.NombreEquipo, x.CodigoBienesPatrimoniales})
                    .ToList();

                return JsonConvert.SerializeObject(equipos);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        // Metodo para mostrar tareas
        [HttpGet]
        public string GetTareas()
        {
            try
            {
                var tareas = _context.Tarea
                    .Where(x => x.EstadoTarea == "En progreso" || x.EstadoTarea == "Sin iniciar")
                    .Select(x => new { x.Id, x.Nombre, x.Especificacion, x.FechaAsignacion, x.FechaFinalizacion, x.EstadoTarea, x.PersonaEncargadaId })
                    .ToList();

                return JsonConvert.SerializeObject(tareas);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        
        public string GetTareasActualizar()
        {
            try
            {
                var tareas = _context.Tarea
                    .Select(x => new { x.Id,x.Nombre, x.FechaAsignacion})
                    .ToList(); 

                return JsonConvert.SerializeObject(tareas);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

       

        public string GetTareaByCodigo(string data)
        {
            if (data == null)
            {
                return JsonConvert.SerializeObject(null);
            }

            try
            {
                var tarea = JsonConvert.DeserializeObject<Tarea>(data);
                if (tarea == null)
                {
                    throw new Exception("Null Object");
                }

                var tareaConsultada = _context.Tarea
                    //.Where(x => x.Id == tarea.Id)
                    .Select(x => new { x.Id, x.Nombre, x.Especificacion, x.FechaAsignacion, x.FechaFinalizacion, x.EstadoTarea, x.PersonaEncargadaId})
                    .ToList();

                return JsonConvert.SerializeObject(tareaConsultada);

            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        // Metodo para crear tarea
        [HttpPost]
        public string SubmitTarea(string data)
        {
            if (data == null)
            {
                return JsonConvert.SerializeObject(null);
            }


            try
            {
                var tarea = JsonConvert.DeserializeObject<Tarea>(data);
                if (tarea == null)
                {
                    throw new Exception("Null Object");
                }

                tarea.PersonaEncargadaId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                tarea.FechaAsignacion = DateTime.Now;
                

                _context.Tarea.Add(tarea);
                _context.SaveChanges();

                return JsonConvert.SerializeObject(tarea);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

       

        // Metodo para modificar tarea 
        [HttpPut]
        public string ModificarTarea(string data)
        {

            if (data == null)
            {
                return JsonConvert.SerializeObject(null);
            }

            try
            {
                var info = JsonConvert.DeserializeObject<Tarea>(data);
                if (info == null)
                {
                    throw new Exception("Null Object");
                }

                _context.Tarea.Update(info);
                _context.SaveChanges();

                return JsonConvert.SerializeObject(info);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }



        public string GetLaboratorios()
        {
            try
            {
                var laboratorios = _context.Laboratorio
                    .Where(x => x.Activo && x.Reservas.Where(y => y.FechaDevolucion == null).Count() == 0)
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

        [HttpGet]
        public string GetSalones()
        {
            try
            {
                var reservas = _context.Reserva
                    .Where(x => x.FechaDevolucion == null)
                    .Include(x => x.Laboratorio)
                    .Select(x => new { x.Id, x.Laboratorio.Codigo, x.NombrePersona })
                    .ToList();

                return JsonConvert.SerializeObject(reservas);
            }
            catch (Exception e)
            {
                _logger.LogError("Error: {e}", e.Message);
                return JsonConvert.SerializeObject(null);
            }
        }

        public string GetReservas()
        {
            try
            {
                var reservas = _context.Reserva
                    .Include(x => x.Laboratorio)
                    .Select(x => new { x.Id,x.FechaInicio,x.Descripcion ,x.NombrePersona,x.CedulaPersona, x.Laboratorio.Codigo, x.Duracion ,x.UsuarioEntrega.UserName , x.FechaDevolucion, x.UsuarioRecibe.Email })
                    .ToList();

                return JsonConvert.SerializeObject(reservas);
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

       
        // Metodo para insertar formulario reserva lab
        [HttpPost]
        public string SubmitReserva(string data)
        {
            if (data == null)
            {
                return JsonConvert.SerializeObject(null);
            }

            try
            {
                var reserva = JsonConvert.DeserializeObject<Reserva>(data);
                if (reserva == null)
                {
                    throw new Exception("Null Object");
                }

                reserva.UsuarioEntregaId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                reserva.FechaInicio = DateTime.Now.ToString("dd/MM/yyyy");
                reserva.Duracion = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);



                _context.Reserva.Add(reserva);
                _context.SaveChanges();

                return JsonConvert.SerializeObject(reserva);
            }
            catch (Exception e)
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

        // Metodo para insertar formulario
        [HttpPost]
        public string SubmitDevolucionLab(int data)
        {
            try
            {
                var reserva = _context.Reserva.Where(x => x.Id == data).ToList().FirstOrDefault();
                if (reserva == null)
                {
                    return JsonConvert.SerializeObject(null);
                }

                reserva.UsuarioRecibeId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                reserva.FechaDevolucion = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

                _context.Reserva.Update(reserva);
                _context.SaveChanges();

                return JsonConvert.SerializeObject(reserva);
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

