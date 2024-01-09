using Microsoft.AspNetCore.Mvc;
using TwoToFourEndPoints.Services;

namespace TwoToFourEndPoints.Controllers
{
    [ApiController]
    [Route("TwoToFourEndPoints")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly IAddTwoService _addTwoService;

        public AddTwoNumbersController(IAddTwoService addTwoService)
        {
            _addTwoService = addTwoService;
        }

        [HttpGet]
        [Route("Add")]

        public string addTwo(int x, int y)
        {
            return _addTwoService.addTwo(x,y);
        }

    }
}