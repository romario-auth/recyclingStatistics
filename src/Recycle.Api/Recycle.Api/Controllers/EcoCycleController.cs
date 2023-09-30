using Microsoft.AspNetCore.Mvc;

namespace Recycle.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class EcoCycleController : ControllerBase
    {
        public EcoCycleController()
        {
        }

        [HttpGet(Name = "FirstPoint")]
        public string EcoPoint()
        {
            return "Segundo ponto";
            
        }
    }

}