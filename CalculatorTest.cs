using System;
using System.Threading.Tasks;
using VerifyTests;
using VerifyXunit;
using Xunit;

namespace VerifySample
{
  [UsesVerify]
  public class CalculatorTest
  {
    [Fact]
    public Task Initial_Empty()
    {
      var c = new Calculator();

      return Verifier.Verify(c.ToString());
    }

    [Fact]
    public Task AddingTwoAmounts()
    {
      var c = new Calculator();
      c.Add(10);
      c.Add(20);

      return Verifier.Verify(c.ToString());
    }

    [Fact]
    public Task AddingTwoAmounts_Case2()
    {
      var c = new Calculator();
      c.Add(9);
      c.Add(550);

      return Verifier.Verify(c.ToString());
    }

    [Fact]
    public Task AddingMultipleAmounts()
    {
      var c = new Calculator();
      c.Add(1505);
      c.Add(15.25m);
      c.Add(90_000);

      return Verifier.Verify(c.ToString());
    }
  }


}
