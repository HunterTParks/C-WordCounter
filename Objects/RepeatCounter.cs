using System.Collections.Generic;
using System;

namespace CProject.Objects
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _word;
    private string[] _refactor;

    public RepeatCounter(string sentence, string word)
    {
      _sentence = sentence;
      _word = word;
    }

    public string HowManyWords()
    {
      _refactor = _sentence.Split(new [] {" "}, StringSplitOptions.RemoveEmptyEntries);
      Console.WriteLine(_refactor[0]);
      return _refactor[0];
    }
  }
}
