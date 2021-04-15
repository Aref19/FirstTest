using System;
using Microsoft.AspNetCore.Mvc;

namespace FirstTest.Controllers
{
    [ApiController]
    [Route("api/Home")]
    public class Home : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello world from ";
        }
        
        [HttpPost("pos")]
        public void Post(string na)
        {
            if (!na.Equals(""))
                Console.Write("name dont found"+na);
            else
            {
               Console.Write("name dont found"); ;
            }
        }
    }
}