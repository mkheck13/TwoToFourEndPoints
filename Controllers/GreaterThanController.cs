using Microsoft.AspNetCore.Mvc;
using TwoToFourEndPoints.Services;

namespace TwoToFourEndPoints.Controllers
{
    [ApiController]
    [Route("TwoToFourEndPoints")]
    public class GreaterThanController : ControllerBase
    {
        private readonly IGreaterService _greaterService;

        public GreaterThanController(IGreaterService greaterService)
        {
            _greaterService = greaterService;
        }
        
        [HttpGet]
        [Route("GreaterThanController")]

        public string compare(int x, int y)
        {
            return _greaterService.compare(x,y);
        }
        
    }
}