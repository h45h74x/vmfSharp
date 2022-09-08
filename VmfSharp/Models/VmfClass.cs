using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VmfSharp
{
  public class VmfClass : Vmf<ICollection<IVmf>>
  {
    public VmfClass(string name) : base(name, new List<IVmf>())
    {
    }

    public VmfClass(string name, IEnumerable<IVmf> properties) : base(name, new List<IVmf>(properties))
    {
    }

    public override string ToString(string indentPadding)
    {
      var stringBuilder = new StringBuilder();
      
      stringBuilder.Append(indentPadding);
      stringBuilder.AppendLine(Name);
      
      stringBuilder.Append(indentPadding);
      stringBuilder.AppendLine("{");

      var props = Value.Select(prop => prop.ToString(indentPadding + '\t'));
      foreach (var prop in props)
      {
        stringBuilder.AppendLine(prop);
      }

      stringBuilder.Append(indentPadding);
      stringBuilder.Append("}");

      return stringBuilder.ToString();
    }
  }
}