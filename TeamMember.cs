using System;

namespace planHeist
{
  class TeamMember
  {
    public string name { get; set; }
    public int skillLvl { get; set; }
    public double courage { get; set; }

    public TeamMember(string inputName, int inputSkill, double inputCourage)
    {
      name = inputName;
      skillLvl = inputSkill;
      courage = inputCourage;
    }

    public void printTeamMember()
    {
      Console.WriteLine($"NAME: {name}");
      Console.WriteLine($"SKILL_LEVEL: {skillLvl}");
      Console.WriteLine($"COURAGE: {courage}");
    }


  }
}
