using System;

namespace planHeist
{
  class Program
  {

    static public TeamMember userCreateTM()
    {
      string name = "";
      int skillLvl = 0;
      double courage = 0;
      Console.WriteLine("You're creating your Team mate!");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Enter the Name of your Team Mate!");
      while (true)
      {
        string rawUserName = Console.ReadLine();
        name = rawUserName;
        Console.WriteLine($"You chose the Name: {name}.");
        Console.WriteLine("---------------------------");

        while (true)
        {
          Console.WriteLine($"Choose a skill level for {name}. MUST BE A NUMBER");
          string rawSkillLvl = Console.ReadLine();
          try
          {
            skillLvl = Int32.Parse(rawSkillLvl);
            Console.WriteLine($"You chose the Skill Level: {skillLvl}");
            Console.WriteLine("-------------------------------------");
            break;
          }
          catch
          {
            Console.WriteLine("Please enter a REAL WHOLE number");
          }

        }

        while (true)
        {
          Console.WriteLine($"Choose a courage level for {name}. MUST BE A NUMBER BUT CAN BE A DECIMAL IF YOU WANT!");
          string rawCourageLvl = Console.ReadLine();
          try
          {
            courage = Double.Parse(rawCourageLvl);
            Console.WriteLine($"You chose the Courage Level: {courage}");
            Console.WriteLine("-------------------------------------");
            break;
          }
          catch
          {
            Console.WriteLine("Please enter a REAL number");
          }

        }
        TeamMember newTM = new TeamMember(name, skillLvl, courage);
        newTM.printTeamMember();
        return newTM;

      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");
      TeamMember TM = userCreateTM();

    }
  }
}
