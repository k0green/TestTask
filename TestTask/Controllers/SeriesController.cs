using Microsoft.AspNetCore.Mvc;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeriesController : ControllerBase
    {
        private static readonly List<TVSeries> _seriesList = new()
        {
            new TVSeries("Series1", 1, 1, 1),
            new TVSeries("Series2", 2, 2, 2),
            new TVSeries("Series3", 3, 3, 3),
            new TVSeries("Series4", 4, 4, 4),
            new TVSeries("Series5", 5, 5, 5),
            new TVSeries("Series6", 6, 6, 6),
            new TVSeries("Series7", 7, 7, 7),
        };

        [HttpGet(Name = "GetSeries")]
        public async Task<ActionResult<IEnumerable<TVSeries>>> Get(int firstIndex, int secondIndex)
        {
            List<TVSeries> seriesList;
            if (firstIndex >= 0 && secondIndex >= 0 && firstIndex <= secondIndex && secondIndex < _seriesList.Count)
            {
                if (firstIndex < secondIndex)
                {
                    seriesList = _seriesList.GetRange(firstIndex, secondIndex - firstIndex);
                }
                else
                {
                    seriesList = _seriesList.GetRange(secondIndex, firstIndex - secondIndex);
                }
                return seriesList;
            }
            else
                return StatusCode(400);



        }
    }
}