using Microsoft.AspNetCore.Mvc;
using Movies.API.Models.MovieDtos;
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

        [HttpGet]
        [Route("{id}")]
        public ActionResult<MovieDto> GetMovieById(int id)
        {
            var movieDto = _movieService.GetMovieById(id);
            if (movieDto == null) { return NotFound(); }
            return Ok(movieDto);
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] MovieForCreationDto movieForCreationDto)
        {
            var addedMovie = _movieService.AddMovie(movieForCreationDto);
            return Ok(addedMovie);
        }
    }
}
