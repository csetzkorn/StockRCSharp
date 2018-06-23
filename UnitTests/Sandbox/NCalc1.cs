using Xunit;
using NCalc;

namespace UnitTests.Sandbox
{
  public class NCalc1
  {
    [Fact]
    public void Arithmetric1()
    {
      var e = new Expression("([X1] + [X2])");
      e.Parameters["X1"] = 1;
      e.Parameters["X2"] = 3;

      var result = e.Evaluate();

      Assert.Equal(result, 4);
    }

    [Fact]
    public void Boolean1()
    {
      var e = new Expression("if( 2 > 3, 'sell', 'do nothing')");

      var result = e.Evaluate();

      Assert.Equal(result, "do nothing");
    }

    [Fact]
    public void Boolean2()
    {
      var e = new Expression("if( 3 > 2, 'sell', 'do nothing')");

      var result = e.Evaluate();

      Assert.Equal(result, "sell");
    }

    [Fact]
    public void Boolean3()
    {
      var e = new Expression("if( 2 > 3, 'sell', if( 3 > 2, 'buy', 'do nothing'))");

      var result = e.Evaluate();

      Assert.Equal(result, "buy");
    }

    [Fact]
    public void Boolean4()
    {
      var e = new Expression("if( 2 > 3, 'sell', if( 2 > 3, 'buy', if( 3 > 2, 'hold', 'do nothing')))");

      var result = e.Evaluate();

      Assert.Equal(result, "hold");
    }
  }
}
