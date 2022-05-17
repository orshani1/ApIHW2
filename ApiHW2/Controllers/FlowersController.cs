using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHW2.Controllers
{
    [Route("api/flowers")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        [Route("Sun")]
        public string SunFlower()
        {
            return "SunFlower";
        }
        [Route("narkis")]

        public string Narkis()
        {
            return "Narkis";
        }
        [Route("rose")]

        public string Rose()
        {
            return "Rose";
        }
        [Route("violete")]

        public string Violete()
        {
            return "Violete";
        }
    }
}
