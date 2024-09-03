using Microsoft.AspNetCore.Mvc;
using Movies.API.Models.DTO;
using Movies.API.Services;

namespace Movies.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]   
        public ActionResult<IEnumerable<MovieDto>> GetMovies()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }
    }
}
