pudlic class Car
{
    pudlic string brand;
    pudlic int speed; 
    pudlic void Drive()
    {
        Console.WriteLine("The car is driving.")
    }
}

Car myCar = new Car();
myCar.brand = "toyota":
myCar.speed + 60;
myCar.driving(); 

pudlic class BankAccount
{
    private double balance;

public void Deposit(double amount)
{
    balance += amount;

}
public double GetBalance
{
    return balance;
}
}
BankAccount acount = new BankAccount();
account.Deposit(100);
Console.WriteLine(account.GetBalance());



public class Vehicle
{
    public string brand;
 
    public void Start()
    {
     console.WriteLine("Vehicle is starting.");
    }
}
 
 public class Car : vehicle
{
    public int speed;
    public void Drive()
    {
        Console.WriteLine(brand + "is driving at " + speed + "km/h.");
    }
}
Car myCar + new Car();
myCar.brand = "toyota";
myCar.speed = 120;
myCar.Start();
myCar.Drive();

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("bark");
    }
}

Animal myDog = new Dog();
myDog.MakeSound();