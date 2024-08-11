using Microsoft.AspNetCore.Mvc;

/* 1) Reciba 3 valores numéricas y retorne la suma de las mismas. */

namespace Practica1Programacion3CristianNinotti.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej1Controller : Controller
    {
        [HttpGet("numeros")]
        public int Get(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
