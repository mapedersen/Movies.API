using Microsoft.AspNetCore.Mvc;

namespace Movies.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        
        public ActionResult<string> GetMovies()
        {
            return Ok("Getting movies");
        }
    }
}
