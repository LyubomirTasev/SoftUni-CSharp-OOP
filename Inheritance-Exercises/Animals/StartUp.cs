using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "Beast!")
            {
                string[] animalInfo = Console.ReadLine().Split();
                string animalName = animalInfo[0];
                string animalAge = animalInfo[1];
                string animalGender = animalInfo[2];

                if (command == "Cat")
                {
                    Cat cat = new Cat(animalName, int.Parse(animalAge), animalGender);
                    Console.WriteLine(cat);
                }
                else if (command == "Dog")
                {
                    Dog dog = new Dog(animalName, int.Parse(animalAge), animalGender);
                    Console.WriteLine(dog);                    
                }
                else if (command == "Frog")
                {
                    Frog frog = new Frog(animalName, int.Parse(animalAge), animalGender);
                    Console.WriteLine(frog);
                }
                else if (command == "Kittens")
                {
                    Kitten kittens = new Kitten(animalName, int.Parse(animalAge));
                    Console.WriteLine(kittens);
                }
                else if (command == "Tomcat")
                {
                    TomCat tom = new TomCat(animalName, int.Parse(animalAge));
                    Console.WriteLine(tom);
                }

                command = Console.ReadLine();
            }
        }
    }
}
