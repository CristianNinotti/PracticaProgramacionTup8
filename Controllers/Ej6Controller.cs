using Microsoft.AspNetCore.Mvc;

/* 6) Reciba el precio de un producto (valor positivo), la cantidad a comprar y la forma de pagar (efectivo o tarjeta).
Si la forma de pago es mediante tarjeta, debe recibir también el número de la misma(inventado), verificar que sean 16 dígitos y retornar el valor a pagar con un 10% de recargo.
Si la forma de pago es mediante efectivo, retorna el valor a pagar.
Si la forma de pago no es tarjeta ni efectivo, debe retornar un status code del grupo de los 400
*/


namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ejercicio6 : ControllerBase
    {
        [HttpGet("PrecioProducto")]
        public ActionResult<string> Get(int precio, int cantidad, string pago, string numeroTarjeta = null)
        {
            string tipoPago = pago.ToLower().Trim();
            int precioTotal = precio * cantidad;
            int precioFinal;

                if (tipoPago == "tarjeta")
                {
                    if (numeroTarjeta != null && numeroTarjeta.Length <= 16)
                    { 
                    precioFinal = precioTotal + (precioTotal * 10 / 100);
                    return Ok(precioFinal.ToString());
                    }
                    else
                    {
                        return BadRequest("Numero de tarjeta Incorrecto");
                    }      

            }
            
            else if (tipoPago == "efectivo")
            {
                precioFinal = precioTotal;
                return Ok(precioFinal.ToString());

            }
            else
            {
                return BadRequest("Medio de pago incorrecto");
            }

        }
    }
}

