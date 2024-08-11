using Microsoft.AspNetCore.Mvc;


/* 8) Reciba un número entero de inicio y un número entero de fin.
Debe verificar que la diferencia entre inicio y fin sea menor a 1000.
Debe retornar una lista de número que inicie en el valor de inicio y termine en el valor de fin.
Usando un bucle while.*/


namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej8Controller : Controller
    {
        [HttpGet]
        public ActionResult<int> Get(int numInit, int numFinal)
        {
            if (numFinal < 1000)
            {
            List<int> numeros = new List<int>();
            int i = numInit;
            while (i <= numFinal)
            {
                    numeros.Add(i);
                     i++;

            }
                return Ok(numeros);
            }
            return BadRequest("El numero final debe ser mayor a 1000");
        }
    }
}
