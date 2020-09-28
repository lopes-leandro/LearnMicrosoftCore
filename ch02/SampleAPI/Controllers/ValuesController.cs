using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{

  [ApiController]
  [Route("[controller]")]
    public class ValuesController: ControllerBase
    {
        public string Get() {
          return "Olá Mundo!!!";
        }
    }
}