using System;

class Animal
{
    public string Name;
    public int Age;

    public Animal(string animalName, int animalAge)
    {
        Name = animalName;
        Age = animalAge;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound");
    }
}

class Dog : Animal
{
    public string Breed;

    public Dog(string dogName, int dogAge, string dogBreed)
        : base(dogName, dogAge)
    {
        Breed = dogBreed;
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} brings the ball back!");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Woof!");
    }
}

class Cat : Animal
{
    public Cat(string catName, int catAge)
        : base(catName, catAge)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal[] animals =
        {
            new Dog("Karabas", 3, "Kangal"),
            new Cat("Tekir", 2)
        };

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}
