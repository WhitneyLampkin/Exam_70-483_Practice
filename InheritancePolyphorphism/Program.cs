using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyphorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grovers = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr"     //Remember, the derived, Dog, class has a 'Sound2' property but the base class doesn't!!!!
            };

            grovers.Sound = "Wooooooof";

            whiskers.MakeSound();
            grovers.MakeSound();

            whiskers.SetAnimalIdInfo(123, "Sally Smith");
            grovers.SetAnimalIdInfo(456, "Paul Brown");

            whiskers.GetAnimalIDInfo();
            grovers.GetAnimalIDInfo();

            if (grovers is Animal)
            {
                Console.WriteLine("Yes, grovers is both a dog and animal.");
            }

            //Must reference outer class to get to the inner class
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy: {0}", getHealth.HealthyWeight(11, 46));            //True
            Console.WriteLine("Is my animal healthy: {0}", getHealth.HealthyWeight(11, 176));           //False

            Animal monkey = new Animal()    //This creates a new animal using the animal constructor.
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()         //This creates a new animal using the dog constructor.
            {
                Name = "Spot",
                Sound = "Woooof",
                Sound2 = "Geeerrr"
            };

            monkey.MakeSound();
            spot.MakeSound();           //Without overriding the method in the Dog class, this will using the 'MakeSound' method in animal because the dog is created as an animal.

            Console.ReadLine();
        }

        public class AnimalIDInfo
        {
            public int IDNum { get; set; } = 0;
            public string Owner { get; set; } = "No Owner";
        }

        #region Dog Class (derived)
        class Dog : Animal
        {
            public string Sound2 { get; set; } = "Grrr";


            //The new keyword was used to override the method in the base class with the same name at first
            //But it doesn't allow this method to be called if we use the Dog constructor to create a new animal...
            //Override/Virtual do the job instead
            public override void MakeSound()                         
            {
                Console.WriteLine($"{Name} says {Sound} and {Sound2}");
            }

            public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound 2")
                :base(name, sound) //This line is used to have the base class (Animal Class) initialize these instead
            {
                //Base cannot handle Sound2 so we handle anything it cannot handle here...
                Sound2 = sound2;
            }
        }
        #endregion

        #region Animal Class (base)

        public class Animal
        {
            //Inheritance has a 'IS A' relationship
            //Aggregation, a delegate, represents a 'HAS A' relationship

            private string name { get; set; }
            protected string sound;

            //This represents a delegate/aggregate, which are simply objects stored within objects.
            protected AnimalIDInfo animalIDinfo = new AnimalIDInfo();

            public void SetAnimalIdInfo(int idNum, string owner)
            {
                animalIDinfo.IDNum = idNum;
                animalIDinfo.Owner = owner;
            }

            public void GetAnimalIDInfo()
            {
                Console.WriteLine($"{Name} has the ID of {animalIDinfo.IDNum} and is owned by {animalIDinfo.Owner}");
            }

            public virtual void MakeSound()
            {
                Console.WriteLine($"{Name} says {Sound}");
            }

            public Animal() : this("No Name", "No Sound") { }

            public Animal(string name) : this(name, "No Sound") { }

            public Animal(string name, string sound)
            {
                Name = name;
                Sound = sound;
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (!value.Any(char.IsDigit))
                    {
                        name = "No Name";
                    }
                    name = value;
                }
            }

            public string Sound
            {
                get { return sound; }
                set
                {
                    if (value.Length > 10)
                    {
                        sound = "No Name";
                    }
                    sound = value;
                }
            }

            //This is an 'inner class' with a helper method for the Animal class
            public class AnimalHealth
            {
                public bool HealthyWeight(double height, double weight)
                {
                    double calc = height / weight;

                    if (calc >= .18 && (calc <= .27))
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }
        #endregion
    }
}
