class If
{
    
    public static void IfElse(int number)
    {
        //int number = 5;

        if(number > 0)
        {
            Console.WriteLine("the Number is Positive");
        }
        else if(number < 0)
        {
            Console.WriteLine("the Number is Negative");
        }
        else
        {
            Console.WriteLine("the Number is zero!");
        }
        
    }
}