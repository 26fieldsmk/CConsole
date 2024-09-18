using System.Security.Cryptography.X509Certificates;

class SubStrings
{
    
    public static void MySubStriings()
{
    string name= "Spongebob Squarepants";
string sponge = name.Substring(6,3);
string pat = name.Replace("Sponpgebob","Patrick");
string patrick = name.Replace(name,"Patrick");
int index = name.IndexOf("q");
Console.WriteLine(name);
Console.WriteLine(sponge);
Console.WriteLine(pat);
Console.WriteLine(patrick);
Console.WriteLine(index);

}
}