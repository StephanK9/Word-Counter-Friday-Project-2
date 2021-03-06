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

    public string GetUserWord()
    {
      return _userInputWord;
    }

    public string GetUserString()
    {
      return _userInputString;
    }

    public int GetWordsCounted()
    {
      return _wordsCounted;
    }


    public int CountRepeats()
    {
      string[] searchForWords = _userInputString.ToLower().Split(' ');
      foreach(string word in searchForWords)
      {
        if(_userInputWord == word.ToLower())
        {
          _wordsCounted += 1;
        }
      }
      return _wordsCounted;
    }
  }
}
