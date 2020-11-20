using System;
using System.Collections.Generic;

namespace planHeist
{
  class Program
  {


    static public int getLuck()
    {
      int luck = new Random().Next(-10, 11);
      return luck;
    }

    static public void playGame(List<TeamMember> Team, Bank bank)
    {
      int bankLuckRoll = bank.difficulty + getLuck();

      if (TeamStrength(Team) > bankLuckRoll)
      {
        Console.WriteLine($"Your Team's Skill is {TeamStrength(Team)} VS The Bank's level of {bankLuckRoll}");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(@"

 __       __           __                         _______   __            __              __    __                                             
/  |  _  /  |         /  |                       /       \ /  |          /  |            /  |  /  |                                            
$$ | / \ $$ |  ______ $$/______    ______        $$$$$$$  |$$/   _______ $$ |____        $$ |  $$ |  ______   _____  ____    ______    _______ 
$$ |/$  \$$ | /      \$//      \  /      \       $$ |__$$ |/  | /       |$$      \       $$ |__$$ | /      \ /     \/    \  /      \  /       |
$$ /$$$  $$ |/$$$$$$  |/$$$$$$  |/$$$$$$  |      $$    $$< $$ |/$$$$$$$/ $$$$$$$  |      $$    $$ |/$$$$$$  |$$$$$$ $$$$  |/$$$$$$  |/$$$$$$$/ 
$$ $$/$$ $$ |$$    $$ |$$    $$ |$$ |  $$/       $$$$$$$  |$$ |$$ |      $$ |  $$ |      $$$$$$$$ |$$ |  $$ |$$ | $$ | $$ |$$    $$ |$$      \ 
$$$$/  $$$$ |$$$$$$$$/ $$$$$$$$/ $$ |            $$ |  $$ |$$ |$$ \_____ $$ |  $$ |      $$ |  $$ |$$ \__$$ |$$ | $$ | $$ |$$$$$$$$/  $$$$$$  |
$$$/    $$$ |$$       |$$       |$$ |            $$ |  $$ |$$ |$$       |$$ |  $$ |      $$ |  $$ |$$    $$/ $$ | $$ | $$ |$$       |/     $$/ 
$$/      $$/  $$$$$$$/  $$$$$$$/ $$/             $$/   $$/ $$/  $$$$$$$/ $$/   $$/       $$/   $$/  $$$$$$/  $$/  $$/  $$/  $$$$$$$/ $$$$$$$/  
                                                                                                                                               
                                                                                                                                               
                                                                                                                                               

");
      }
      else
      {
        Console.WriteLine($"Your Team's Skill is {TeamStrength(Team)} VS The Bank's level of {bankLuckRoll}");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(@"

   ____     __   ,-----.      ___    _          ______         .-''-.     ____     ______             ,---.    ,---.   .-''''-.    
   \   \   /  /.'  .-,  '.  .'   |  | |        |    _ `''.   .'_ _   \  .'  __ `. |    _ `''.         |    \  /    |  /  _--.  \   
    \  _. /  '/ ,-.|  \ _ \ |   .'  | |        | _ | ) _  \ / ( ` )   '/   '  \  \| _ | ) _  \        |  ,  \/  ,  |  |_( )_ ' |   
     _( )_ .';  \  '_ /  | :.'  '_  | |        |( ''_'  ) |. (_ o _)  ||___|  /  ||( ''_'  ) |        |  |\_   /|  |  (_ o _). /   
 ___(_ o _)' |  _`,/ \ _/  |'   ( \.-.|        | . (_) `. ||  (_,_)___|   _.-`   || . (_) `. |        |  _( )_/ |  | .'(_,_).  `.  
|   |(_,_)'  : (  '\_/ \   ;' (`. _` /|        |(_    ._) ''  \   .---..'   _    ||(_    ._) '        | (_ o _) |  ||_( )_    \  | 
|   `-'  /    \ `""/ \  ) / | (_ (_) _)         | (_.\.'  /  \  `-'    /|  _( )_  || (_.\.'  /         |  (_,_)  |  |(_ o _)   /  | 
 \      /      '. \_/``"".'   \ /  . \/         |       .'    \       / \ (_ o _) /|       .'          |  |      |  | (_,_)..-' .'
  `-..-'         '---- - '     ``-'`-''         '-----'`       `'-..-'  '.(_,_).' '-----'`            '--'      '--'   `-....-'    



");
      }
    }

    static public List<TeamMember> userCreateTeamMembers()
    {
      List<TeamMember> team = new List<TeamMember>();
      string name = "";
      int skillLvl = 0;
      double courage = 0;
      bool blank = false;

      Console.WriteLine("You're creating your Team mate!");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Enter the Name of your Team Mate! OR Enter a blank name to exit!");

      while (blank == false)
      {
        string rawUserName = Console.ReadLine();

        if (rawUserName.Equals("") == true)
        {
          return team;
        }
        else
        {
          name = rawUserName;
          Console.WriteLine($"You chose the Name: {name}.");
          Console.WriteLine("---------------------------");
        }


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
        team.Add(newTM);
        newTM.printTeamMember();
        Console.WriteLine("");
        Console.WriteLine("---TEAM_MEMBER_ADDED---");
        Console.WriteLine("");
        Console.WriteLine("Here's your team so far!");
        foreach (TeamMember tm in team)
        {
          tm.printTeamMember();
          Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Enter the Name of your Team Mate! OR Enter a blank name to exit!");
        Console.WriteLine("-----------------------");
      }
      return team;
    }

    static int TeamStrength(List<TeamMember> team)
    {
      int teamStr = 0;
      foreach (TeamMember teamMate in team)
      {
        teamStr += teamMate.skillLvl;
      }
      return teamStr;
    }

    static void playGames(List<TeamMember> Team, Bank bank)
    {
      Console.WriteLine("");
      Console.WriteLine("How many times would you like to play?");
      while (true)
      {
        try
        {
          int times = Int32.Parse(Console.ReadLine());
          for (int i = 0; i < times; i++)
          {
            playGame(Team, bank);
          }
          break;
        }
        catch
        {
          Console.WriteLine("Looks like you didn't enter a number?");
        }
      }

    }

    static void Main(string[] args)
    {
      // Needed varables in this block
      List<TeamMember> Team = new List<TeamMember>();
      Bank bank = new Bank(100, 100);

      Console.WriteLine("Plan Your Heist! --- Enter a blank answer to exit");
      Console.WriteLine("");
      Console.WriteLine("How difficult is this Bank?");

      while (true)
      {
        try
        {
          int chosenDiff = Int32.Parse(Console.ReadLine());
          bank.difficulty = chosenDiff;
          break;
        }
        catch
        {
          Console.WriteLine("That's not a real number. Try a WHOLE number again!");
        }
      }

      Team = userCreateTeamMembers();

      playGames(Team, bank);

    }
  }
}
