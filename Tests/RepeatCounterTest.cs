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

    // [Fact]
    // public void RepeatCounter_displaysentenceinbold_string()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter("How much wood would a woodchuck chuck if a woodchuck could chuck wood?", "wood");
    //   Assert.Equal("How much WOOD would a woodchuck chuck if a woodchuck could chuck WOOD?", newRepeatCounter.highlightWords());
    // }
  }
}
