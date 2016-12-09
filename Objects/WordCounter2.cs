using System;

namespace WordCounter2.Objects
{
  public class RepeatCounter
  {
    private string _userInputWord;
    private string _userInputString;
    private int _wordsCounted = 0;

    public RepeatCounter(string userInputWord, string userInputString)
    {
      _userInputWord = userInputWord;
      _userInputString = userInputString;
    }

    public int CountRepeats()
    {
      return 0;
    }
  }
}
