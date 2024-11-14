class Program
{
    static void Main(string[] args)
    {
        // Opret objekter via factory klasse
        Animals dog = AnimalFactory.CreateAnimal(enmAnimals.Dog, "Hund");
        Animals cat = AnimalFactory.CreateAnimal(enmAnimals.Cat, "Kat");
        Animals sheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep, "Får");

        // Kald MakeSound() metoden
        dog.MakeSound();   // Output: Bob siger: Vov!
        cat.MakeSound();   // Output: Kitty siger: Meow!
        sheep.MakeSound(); // Output: Dolly siger: Baaaah!
    }
}
