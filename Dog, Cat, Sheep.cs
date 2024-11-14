class Dog : Animals
{
    public Dog(string navn) : base(navn) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Navn} siger: Vov!");
    }
}

class Cat : Animals
{
    public Cat(string navn) : base(navn) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Navn} siger: Meow!");
    }
}

class Sheep : Animals
{
    public Sheep(string navn) : base(navn) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Navn} siger: Baaaah!");
    }
}
