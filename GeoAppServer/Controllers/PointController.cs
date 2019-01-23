using System.Collections.Generic;
using System.Linq;
using GeoAppServer.BLL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GeoAppServer.Controllers
{
  [Route("api/[controller]")]
  public class PointController : Controller
  {
    private static readonly List<Point> _path = new PathReader().GeneratePath();

    // GET: api/Point 49.822394, 19.044731

    [HttpGet]
    public IEnumerable<string> Get() => _path.Select(item => item.ToString());

    // GET: api/Point/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id) => _path.SingleOrDefault(x => x.PointId == id)?.ToString();
  }
}