﻿namespace VmfSharp
{
  public class VmfVertex : Vmf<Vertex>
  {
    public VmfVertex(string name) : base(name)
    {
    }

    public VmfVertex(string name, Vertex value) : base(name, value)
    {
    }

    public override string GetValueString()
    {
      return $"({Value.ToString()})";
    }
  }
}