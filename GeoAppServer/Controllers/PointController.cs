using System.Collections.Generic;
using System.Linq;
using GeoAppServer.BLL;
using Microsoft.AspNetCore.Mvc;

namespace GeoAppServer.Controllers
{
  [Route("api/[controller]")]
  public class PointController : Controller
  {
    private static readonly List<Point> _path = new List<Point>
    {
      new Point {Latitude = 49.829506, Longitude = 19.044247, NextPointId = 1, PointId = 0},
      new Point {Latitude = 49.827107, Longitude = 19.039393, NextPointId = 2, PointId = 1},
      new Point {Latitude = 49.824903, Longitude = 19.044350, NextPointId = 3, PointId = 2},
      new Point {Latitude = 49.822394, Longitude = 19.044731, NextPointId = -1, PointId = 3}
    };

    // GET: api/Point 49.822394, 19.044731

    [HttpGet]
    public IEnumerable<string> Get() => _path.Select(item => item.ToString());

    // GET: api/Point/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id) => _path.SingleOrDefault(x => x.PointId == id)?.ToString();
  }
}