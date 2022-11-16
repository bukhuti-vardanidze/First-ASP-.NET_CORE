using Microsoft.AspNetCore.Mvc;
using WebApplication1_WEB_API.models;

namespace WebApplication1_WEB_API.Controllers;

[ApiController]
[Route("[controller]")]
public class CalcullatorController : ControllerBase
{
   [HttpPost]
   [HttpGet]
   [Route("test")]
   public decimal Add([FromBody]calculatorRequest request)
   {
      return request.number1 + request.number2;
   }
}