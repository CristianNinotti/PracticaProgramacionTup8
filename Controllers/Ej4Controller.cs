using Microsoft.AspNetCore.Mvc;

/* 4) Reciba dos números y retorne el mayor. */

namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej4Controller
    {
        [HttpGet("MayorNumero")]
        public int Get(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
