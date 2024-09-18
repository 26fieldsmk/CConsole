using System.Diagnostics.Contracts;
using System.Security.Principal;

class Loops
{

    public static void ForLoops()
  {     for(int i = 0; i < 10; i++)
     {
         Console.WriteLine("Iteration:" + i);
     }
  }
  public static void EevenLoop()
  {
      for(int i = 1; i <= 20; i++)
      {
        if(i % 2 == 0)
        {
            Console.WriteLine(i);
        }
      }
  }

  public static void HealthLoop()
  {
    int health = 100;
    while(health > 0)
    {
 Console.WriteLine("Player is alive with health" + health);
  health = health - 10;
    }
  }
  
}
