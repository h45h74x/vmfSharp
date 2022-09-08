namespace VmfSharp
{
  public struct Vertex
  {
    public decimal X { get; }
    public decimal Y { get; }
    public decimal Z { get; }

    public Vertex(decimal x, decimal y, decimal z)
    {
      X = x;
      Y = y;
      Z = z;
    }

    public override string ToString()
    {
      return $"{X} {Y} {Z}";
    }
  }
}