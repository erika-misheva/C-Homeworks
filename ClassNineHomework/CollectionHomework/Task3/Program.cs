using System;
using System.Collections.Generic;
using Task3.Modules;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>()
            {
                new Animal(){Name = "Arthur", Age = 6, Color="brown", Gender = Gender.Male},
                new Animal(){Name = "Butch", Age = 1, Color="white", Gender=Gender.Male},
                new Animal(){Name = "Alice", Age = 3, Color="brown",Gender=Gender.Female},
                new Animal(){Name = "Stella", Age = 7, Color="black", Gender=Gender.Female},
                new Animal(){Name = "Maximillian", Age = 4, Color="white", Gender=Gender.Male},
                new Animal(){Name = "Billy", Age = 1, Color="gray", Gender=Gender.Male},
                new Animal(){Name = "Buck", Age = 2, Color="brown", Gender= Gender.Male}
            };

            List<Animal> animalsAgedFiveOrMore = animals.Where(animal => animal.Age >= 5).ToList();

            Console.WriteLine("Animals with age 5 or more:");
            foreach (Animal animal in animalsAgedFiveOrMore)
            {
                Console.WriteLine(animal.Name);
            }

            List<Animal> animalThatNameStartsWithA = animals.Where(animal => animal.Name.StartsWith('A')).ToList();
            Console.WriteLine("All the Animals whose name starts with A:");
            foreach (Animal animal in animalThatNameStartsWithA)
            {
                Console.WriteLine(animal.Name);
            }

            List<Animal> maleBrownAnimals = animals.Where (animals => animals.Gender == Gender.Male && animals.Color == "brown").ToList();
            Console.WriteLine("All the brown male animals:");
            foreach (Animal animal in maleBrownAnimals)
            {
                Console.WriteLine(animal.Name);
            }

            Animal animalWithNameLargerThanTenCharacters = animals.FirstOrDefault(animal=> animal.Name.Length >= 10);
            Console.WriteLine($"The first found Animal whose name is larger than 10 letters is {animalWithNameLargerThanTenCharacters.Name}");
        }
    }
}
