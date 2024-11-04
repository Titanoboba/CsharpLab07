using System;
using System.Xml;
using System.Xml.Linq;

namespace Lab07
{

    [commentAttribute("Abstract")]
    public abstract class Animal
    {
        public string Country { get; set; }
        public bool HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public eClassificationAnimal WhatAnimal { get; set; }

        public Animal(string Country, bool aaaa, string name)
        {
            this.Country = Country;
            this.HideFromOtherAnimals = aaaa;
            this.Name = name;
        }

        public abstract void SayHello();

        public eFavouriteFood GetFavouriteFood()
        {
            if (WhatAnimal == eClassificationAnimal.Herbivores)
            {
                return eFavouriteFood.Plants;
            }
            else if (WhatAnimal == eClassificationAnimal.Carnivores)
            {
                return eFavouriteFood.Meat;
            }
            else
            {
                return eFavouriteFood.Everything;
            }
        }

        public void Deconstruct()
        {
        }

        public abstract eClassificationAnimal GetClassificationAnimal();

    }

    public enum eClassificationAnimal
    {
        Herbivores,
        Carnivores,
        Omnivores
    }

    public enum eFavouriteFood
    {
        Meat,
        Plants,
        Everything
    }

    [commentAttribute("cow")]
    public class Cow : Animal
    {
        public Cow(string country, bool hiding, string name) : base(country, hiding, name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("I am a cow");
        }

        public override eClassificationAnimal GetClassificationAnimal()
        {
            return WhatAnimal;
        }

    }

    [commentAttribute("lion")]
    public class Lion : Animal
    {
        public Lion(string country, bool hiding, string name) : base(country, hiding, name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("I am a lion");
        }

        public override eClassificationAnimal GetClassificationAnimal()
        {
            return WhatAnimal;
        }

    }

    [commentAttribute("pig")]
    public class Pig : Animal
    {
        public Pig(string country, bool hiding, string name) : base(country, hiding, name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("I am a pig");
        }

        public override eClassificationAnimal GetClassificationAnimal()
        {
            return WhatAnimal;
        }

    }

    [AttributeUsage(AttributeTargets.Class)]
    public class commentAttribute : Attribute
    {
        public string comment { get; }

        public commentAttribute(string comment)
        {
            this.comment = comment;
        }
    }

}