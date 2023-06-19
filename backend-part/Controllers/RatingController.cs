using backend_part.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRating repo;

        public RatingController(IRating _repo)
        {

            repo = _repo;
        }

        [HttpPost]
        public ActionResult AddRating(RatingModel rating)
        {
            try
            {
                repo.AddRating(rating);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        public ActionResult<Meeting> UpdateRating(RatingModel rating)
        {
            try
            {
                repo.UpdateRating(rating);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

