using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreSample.Common;

namespace AspNetCoreSample.Controllers
{
    [Route("dostuff")]
    public class DoStuffController : Controller
    {
        [HttpGet("more")]
        public string Get()
        {
            return DoStuff.moreStuff();
        }   
    }
}
