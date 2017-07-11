using System;
using System.Collections.Generic;
using System.Linq;

namespace MembersOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> preds = new List<string>();

            preds.Add("Crows");
            preds.Add("Eagles");
            preds.Add("Anacondas");

            List<string> prey = new List<string>();
            prey.Add("Tigers");
            prey.Add("Poisin Dart Frogs");
            prey.Add("Small People");
        
            Bug CripplerBug = new Bug("Crippler Bug", "AnacondaCrowalsi", preds, prey);


            Console.WriteLine(CripplerBug.FormalName);
            Console.WriteLine(CripplerBug.PredatorList);
            Console.WriteLine(CripplerBug.PreyList);
            Console.WriteLine(CripplerBug.Eat("Tigers"));
        }

        public class Bug
        {
            /*
                You can declare a typed public property, make it read-only,
                and initialize it with a default value all on the same
                line of code in C#. Readonly properties can be set in the
                class' constructors, but not by external code.
            */
            public string Name { get; } = "";
            public string Species { get; } = "";
            public ICollection<string> Predators { get; } = new List<string>();
            public ICollection<string> Prey { get; } = new List<string>();


            // Convert this readonly property to an expression member
            public string FormalName => $"{Name} of the {Species}";

            // Class constructor
            
            public Bug(string name, string species, List<string> predators, List<string> prey)
            {
                this.Name = name;
                this.Species = species;
                this.Predators = predators;
                this.Prey = prey;
            }

            // // Convert this method to an expression member
            public string PreyList => String.Join(", ", Prey);
            // {
            //     var commaDelimitedPrey = 
            //     return commaDelimitedPrey;
            // }

            // Convert this method to an expression member
            public string PredatorList => String.Join(", ", Predators);
            // {
            //     var commaDelimitedPredators = string.Join(",", this.Predators);
            //     return commaDelimitedPredators;
            // }

            // Convert this to expression method (hint: use a C# ternary)
            public string Eat(string food) => (Prey.Contains(food)) ? $"{Name} ate the {food}." : $"{Name} is still hungry."; 
            // public string Eat(string food)
            // {
            //     if (this.Prey.Contains(food))
            //     {
            //         return $"{this.Name} ate the {food}.";
            //     } else {
            //         return $"{this.Name} is still hungry.";
            //     }
            // }
        }
    }
}
