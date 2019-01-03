namespace GeoAppServer.BLL
{
  public class Point
  {
    public double Longitude { get; set; } = 0;
    public double Latitude { get; set; } = 0;
    public int PointId { get; set; } = 0;
    public int NextPointId { get; set; } = 1;

    public override string ToString()
    {
      const string sep = ";";
      return PointId + sep +
             Longitude + sep +
             Latitude + sep +
             NextPointId;
    }
  }
}