namespace Shapes.Models
{
  public class Cube
  {
    public Rectangle Face { get; set; }

    public Cube (Rectangle side)
    {
      Face = side;
    }

    public int GetVolume()
    {
      int length = Face.Length;
      return length * length * length; // length * width * height
    }

    public int GetSurfaceArea()
    {
      int length = Face.Length;
      return (length * length) * 6; // faces of cube
    }
  }
}