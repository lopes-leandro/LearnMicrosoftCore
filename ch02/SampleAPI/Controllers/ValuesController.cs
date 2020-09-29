using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{

  [ApiController]
  [Route("[controller]")]
  public class ValuesController : ControllerBase
  {
    [HttpPost]
    public IActionResult Post() => Ok();

    public ValuesController(){ }

    [HttpGet]
    public ActionResult<string> Get([FromServices] IPaymentService paymentService)
    {
      return paymentService.GetMessage();
    }
  }
}