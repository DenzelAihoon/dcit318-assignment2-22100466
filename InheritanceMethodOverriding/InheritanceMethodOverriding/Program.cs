using System;

namespace InheritanceDemo
{
    // Base class
    class Animal
    {
        // Virtual so derived classes can override it
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class: overrides MakeSound()
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class: overrides MakeSound()
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding ===");

            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            genericAnimal.MakeSound(); // Some generic sound
            dog.MakeSound();           // Bark
            cat.MakeSound();           // Meow
        }
    }
}
