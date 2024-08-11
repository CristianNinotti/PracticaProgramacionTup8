using Microsoft.AspNetCore.Mvc;

/* 2) Reciba el nombre de una persona y el nombre de una ciudad, y retorne el siguiente mensaje:
“Hola ” <nombre> ” bienvenido a ” <ciudad>”. Utilizar Interpolación. */

namespace Practica1Programacion3CristianNinotti.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej2Controller
    {
        [HttpGet("NombreCiudad")]
        public string Get(string nombre, string ciudad)
        {
             return $"Hola {nombre}, Bienvenido a {ciudad}";
           
        }
    }
}

