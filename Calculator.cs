using System.Collections.Generic;
using System.Linq;

namespace VerifySample
{
  public class Calculator
  {
    private List<decimal> amounts = new List<decimal>();

    public void Add(decimal amount)
    {
      amounts.Add(amount);
    }

    public override string ToString()
    {
      if (amounts.Count == 0) return "No calculation";

      var s = "";
      var max = amounts.Max().ToString("n2").Length; 

      foreach (var amount in amounts)
      {
        s += $"{amount.ToString("n2").PadLeft(max)} +\n";
      }
      s += new string('-', max) + "\n";
      s += $"{amounts.Sum().ToString("n2").PadLeft(max)} =";


      return s;
    }
  }
}
