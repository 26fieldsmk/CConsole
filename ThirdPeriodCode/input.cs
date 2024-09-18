class Input
{
public static void hello()
   {
    Console.WriteLine("What is your name?");
    var userName = Console.ReadLine();
    Console.WriteLine(userName);
    Console.WriteLine("hello" + userName + " Nice to meet you.");
    }

}