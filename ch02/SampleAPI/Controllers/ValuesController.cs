using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{

  [ApiController]
  [Route("[controller]")]
  public class ValuesController : ControllerBase
  {
    private IPaymentService paymentService { get; set; }

    public ValuesController(IPaymentService paymentService)
    {
      this.paymentService = paymentService;
    }

    public string Get()
    {
      return paymentService.GetMessage();
    }
  }
}