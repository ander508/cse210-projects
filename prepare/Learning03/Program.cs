using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        Account saving = new Account();
        saving._balance = 50;
        Console.WriteLine(saving.Deposit(300));
        
        
        Accountone savingone = new Accountone();
        savingone.SetBalance(5000);
        Console.WriteLine(savingone.GetBalance());
        
        
        Accounttwo savingtwo = new Accounttwo();
        savingtwo.Deposit(200);
       

        Person _person = new Person();
        
        _person.GetFormalSignature();
        _person.GetInformalSignature();
        Console.WriteLine(_person.GetFormalSignature());
        Console.WriteLine(_person.GetInformalSignature());

        
        Personone p = new Personone();
        
        p.SetFirstName("Anderson");
        Console.WriteLine(p.GetFirstName());
        
        
        Personfour p1 = new Personfour(); // Don't pass any information to get the default values
        Personfour p2 = new Personfour("Jane", "Doe"); // pass the first and last names
        Personfour p3 = new Personfour("Mrs.", "Jane", "Doe"); // pass all three variables
             
             
             
             
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        
        
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        
        
    }
}