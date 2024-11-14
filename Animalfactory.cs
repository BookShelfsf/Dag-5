class AnimalFactory
{
    // Metode med navneparameter
    public static Animals CreateAnimal(enmAnimals animalType, string navn)
    {
        return animalType switch
        {
            enmAnimals.Dog => new Dog(navn),
            enmAnimals.Cat => new Cat(navn),
            enmAnimals.Sheep => new Sheep(navn),
            _ => throw new ArgumentException("Ugyldig dyretype")
        };
    }

    // Overload metode uden navneparameter
    public static Animals CreateAnimal(enmAnimals animalType)
    {
        string navn = animalType switch
        {
            enmAnimals.Dog => "Hund",
            enmAnimals.Cat => "Kat",
            enmAnimals.Sheep => "Får",
            _ => "Ukendt"
        };
        return CreateAnimal(animalType, navn);
    }
}
