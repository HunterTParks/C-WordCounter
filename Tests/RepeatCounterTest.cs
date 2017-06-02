using Xunit;

namespace CProject.Objects
{
  public class RepeatCounterTests
  {
    [Fact]
    public void RepeatCounter_singleWord_one()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("wood", "wood");
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }

    [Fact]
    public void RepeatCounter_sentence_three()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("wood wood wood", "wood");
      Assert.Equal(3, newRepeatCounter.CountRepeats());
    }
  }
}
