using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend_part.SERVICES.Innovatives;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InnovativesController : ControllerBase
    {
        private IInnovativeRepository _innovativeService;

        public InnovativesController(IInnovativeRepository innovative)
        {
            _innovativeService = innovative;
        }

        [HttpGet()]
        public IActionResult GetInnovatives()
        {
            var Innovatives = _innovativeService.AllInnovatives();


            Innovatives = Innovatives.ToList();

            return Ok(Innovatives);
        }
        [HttpGet("{InnovativeId?}")]
        public IActionResult GetUsers(int? InnovativeId)
        {
            var Innovatives = _innovativeService.AllInnovatives();

            if (Innovatives == null) return Ok(Innovatives);

            Innovatives = Innovatives.Where(i => i.InnovativeId == InnovativeId).ToList();

            return Ok(Innovatives);
        }
    }
}
