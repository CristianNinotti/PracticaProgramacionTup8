using Microsoft.AspNetCore.Mvc;

/* 7) Reciba un número entero de inicio y un número entero de fin.
Debe verificar que la diferencia entre inicio y fin sea menor a 1000.
Debe retornar una lista de número que inicie en el valor de inicio y termine en el valor de fin.
Usar un bucle for.*/

namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej7Controller : Controller
    {
        [HttpGet]
        public ActionResult<int> Get(int numInit, int numFin)
        {
            if (numFin < 1000)
            {
                List<int> numeros = new List<int>();

                for (int i = numInit; i <= numFin; i++)
                {
                    numeros.Add(i);
                }
                return Ok(numeros);
            }
            return BadRequest("El numero de fin debe ser mayor a 1000");
        }

    }
}
