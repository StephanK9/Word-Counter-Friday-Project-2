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
  }
}
