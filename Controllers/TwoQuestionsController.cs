using Microsoft.AspNetCore.Mvc;
using TwoToFourEndPoints.Services;

namespace TwoToFourEndPoints.Controllers
{
    [ApiController]
    [Route("TwoToFourEndPoints")]
    public class TwoQuestionsController : ControllerBase
    {
        private readonly ITwoQuestionsService _twoQuestionsService;

        public TwoQuestionsController(ITwoQuestionsService twoQuestionsService)
        {
            _twoQuestionsService = twoQuestionsService;
        }

        [HttpGet]
        [Route("TwoQuestions/{name}/{time}")]
        public string twoQuestions(string name, int time)
        {
            return _twoQuestionsService.twoQuestions(name, time);
        }
        
    }
}