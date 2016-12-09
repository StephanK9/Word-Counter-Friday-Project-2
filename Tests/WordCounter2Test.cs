using System;
using Xunit;
using WordCounter2.Objects;

namespace WordCounter2
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounterTest1_RecognizeSame_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("snow", "snow");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void RepeatCounterTest2_RecognizeSame_False()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("snow", "portland");
      Assert.Equal(0, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void RepeatCounterTest3_CountHowMany_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("snow", "lots of snow snow snow");
      Assert.Equal(3, testRepeatCounter.CountRepeats());
    }
  }
}
