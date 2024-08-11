using Microsoft.AspNetCore.Mvc;

/* 5) Reciba el nombre del día y retorne si es fin de semana o no. En caso de error, debe retornar un status code del grupo de los 400 si es error del 
 * cliente o un status code del grupo de los 500 si es un error interno.
Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /        	“  lunes” y debería funcionar */

namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej5Controller : Controller
    {
        [HttpGet]
        public ActionResult<string> Get(string dia)
        {
            string nuevoDia = dia.ToLower().Trim();
            string mensaje;
            switch (nuevoDia)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    mensaje = "Es dia de semana";
                    break;
                case "sabado":
                case "domingo":
                    mensaje = "Es dia de Fin de Semana";
                    break;
                default:
                    return BadRequest("Ese día es invalido");

            }
            return Ok(mensaje);
        }

    }
}
