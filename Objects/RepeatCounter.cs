using System.Collections.Generic;
using System;

namespace CProject.Objects
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _word;
    private string[] _refactor;
    private int counter = 0;

    public RepeatCounter(string sentence, string word)
    {
      _sentence = sentence;
      _word = word;
    }

    public int HowManyWords()
    {
      _sentence.ToLower();
      _refactor = _sentence.Split(new [] {" "}, StringSplitOptions.RemoveEmptyEntries);
      Console.WriteLine(_refactor[0]);
      for(int i = 0; i <= _refactor.Length - 1; i++)
      {
        if(_refactor[i] == _word)
        {
          counter++;
        }
      }
      Console.WriteLine(counter);
      return counter;
    }
  }
}
