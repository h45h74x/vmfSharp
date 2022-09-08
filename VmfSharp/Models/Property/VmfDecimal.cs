namespace VmfSharp
{
  public class VmfDecimal : Vmf<decimal>
  {
    public VmfDecimal(string name) : base(name)
    {
    }

    public VmfDecimal(string name, decimal value) : base(name, value)
    {
    }
  }
}