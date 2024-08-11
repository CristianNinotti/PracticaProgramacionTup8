using Microsoft.AspNetCore.Mvc;

/* 3) Reciba un nombre y un valor de edad y retorne el siguiente mensaje:
“Te llamas ” <nombre> ” y tienes ” <años> ” años”*/


namespace Practica1Programacion3CristianNinotti.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej3Controller
    { 
        [HttpGet("NombreyEdad")]
        public string Get(string nombre, string edad)
        {
            return $"Hola {nombre}, y tienes {edad} años";
        }
    }
}
