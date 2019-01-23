using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeoAppServer.BLL
{
  public class PathReader
  {
    public List<Point> GeneratePath()
    {
      using (StreamReader r = new StreamReader(Path.Combine("wwwroot", "paths", "path.json")))
        return JsonConvert.DeserializeObject<List<Point>>(r.ReadToEnd());
    }
  }
}
