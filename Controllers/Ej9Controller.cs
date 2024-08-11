using Microsoft.AspNetCore.Mvc;

/* Ejercicio 9 Idem ejercicio 7, pero retornando solo los números pares. Usar el bucle que le resulte más conveniente. */

namespace Practica1.Controllers
{
    [ApiController]
    [Route("/api[controller]")]
    public class Ej9Controller : Controller
    {
        [HttpGet]
        public ActionResult<int> Get(int numInit, int numFinal)
        {
            if (numFinal < 1000)
            {
                List<int> numeros = new List<int>();
                for (int i = numInit; i <= numFinal; i++)
                {
                    if (i%2 == 0)
                    {
                        numeros.Add(i);
                    }
                }
                return Ok(numeros);
            }
            return BadRequest("El numero final debe ser menor a 1000");
        }
    }
}
