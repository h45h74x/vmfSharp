﻿namespace VmfSharp
{
  public interface IVmfSerializable
  {
    public IVmf ToVmf(int indentation);
  }
}