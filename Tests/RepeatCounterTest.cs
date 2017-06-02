using Xunit;

namespace CProject.Objects
{
  [Fact]
  public void RepeatCounter_singleWord_wood()
  {
    RepeatCounter newRepeatCounter = new RepeatCounter("wood", "wood");
    Assert.Equal("wood", newRepeatCounter.HowManyWords());
  }
}
