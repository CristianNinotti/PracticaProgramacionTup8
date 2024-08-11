using Microsoft.AspNetCore.Mvc;

/* Idem ejercicio 7, pero creando dos listas, una con los números pares y otra con los números impares.
Retornar las dos listas. */


namespace Practica1.Controllers
{
    [ApiController]
    [Route("/api[controller]")]
    public class Ej10Controller : Controller
    {
        [HttpGet]
        public ActionResult<int> Get(int numInit, int numFin)
        {
            if (numFin < 1000)
            {
                List<int> numerosPares = new List<int>();
                List<int> numerosImpares = new List<int>();
                for(int i = numInit; i <= numFin; i++)
                {
                    if (i % 2 == 0)
                    {
                        numerosPares.Add(i);
                    }
                    else
                    {
                        numerosImpares.Add(i);
                    }
                }

                var Listas = new
                {
                    Pares = numerosPares,
                    Impares = numerosImpares
                };

                return Ok(Listas);
 
            }
            return BadRequest("El numero final debe ser menor a 1000");
        }
    }
}
