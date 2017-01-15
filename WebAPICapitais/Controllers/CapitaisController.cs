using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPICapitais.Controllers
{
    [Route("api/[controller]")]
    public class CapitaisController : Controller
    {
        // GET api/values
        [HttpGet("{id}")]
        public List<Capitais> Get([FromServices]CapitaisDAO dao,string id)
        {
            return dao.Obter(id);
        }
    }
}
