using Xunit;

namespace CProject.Objects
{
  public class RepeatCounterTests
  {
    [Fact]
    public void RepeatCounter_singleWord_wood()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("wood wood wood", "wood");
      Assert.Equal(3, newRepeatCounter.HowManyWords());
    }
  }
}
