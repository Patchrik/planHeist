using System;

namespace planHeist
{
  class Bank
  {
    public int difficulty { get; set; }
    public double luck { get; set; }

    public Bank(int inputDifficulty, double inputLuck)
    {
      difficulty = inputDifficulty;
      luck = inputLuck;
    }

    public void printBank()
    {
      Console.WriteLine($"Difficulty: {difficulty}");
      Console.WriteLine($"Luck: {luck}");
    }


  }
}
