using backend_part.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharePointController : ControllerBase
    {
        private readonly ISharePoint repo;

        public SharePointController(ISharePoint _repo)
        {

            repo = _repo;
        }

        [HttpPost]
        public ActionResult AddSharePoint(SharePoint sharePoint)
        {
            try
            {
                repo.AddSharePoint(sharePoint);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<SharePoint> GetSharePoint(int id, int InnovativeId)
        {
            try
            {
                var product = repo.GetSharePoint(id);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpPut]
        public ActionResult<SharePoint> UpdateSharePoint(int Id, int sharepoint )
        {
            try
            {
                repo.UpdateSharePoint(Id,sharepoint);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
