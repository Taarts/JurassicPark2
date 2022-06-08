using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark2
{
    // First create dinosaur class
    class Dinosaur
    {
        public string Name { get; set; }
        public string Diet { get; set; }
        public DateTime WhenAcquired { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }

        public string DisplayDinosaur()
        {
            return ($"{Name} is a {Diet} that was acquired {WhenAcquired}, it weighs {Weight} & is in enclosure {EnclosureNumber}.");
        }


    }

    class Program
    {
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput.ToUpper();
        }
        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }

        //       A:gorithm
        static void Main(string[] args)
        {
            // - Create a list 
            var dinosaursList = new List<Dinosaur>();
            Console.WriteLine();
            // Create MENU
            Console.WriteLine("What would you like to do?\n To (V)iew the List in the park?\n To (A)dd a new Dinosaur to the park?\n to (R)emove a Dinosaur from the Park?\n To (T)ransfer a Dinosaur to another Enclosure?\n To (S)ummarize all the Dinosaurs we have?\n Or (Q)uit");
            // Console.WriteLine("This works");

            // Create method to describe class

            // to (V)iew
            var userAnswer = Console.ReadLine().ToUpper();
            if (userAnswer == "V")
            {
                foreach (var Dinosaur in dinosaursList)
                {
                    Dinosaur.DisplayDinosaur();
                }
            }
            else
            if (userAnswer == "A")
            {
                var dino = new Dinosaur();

                dino.Name = PromptForString("What is the name of the species you'd like to add? ");
                dino.Diet = PromptForString("Is it a (C)arnivore or an (H)erbivore? ");
                dino.Weight = PromptForInteger("How much does it weigh? ");
                dino.EnclosureNumber = PromptForInteger("Which Enclosure do you want to put the beastie in? ");

                dinosaursList.Add(dino);
            }
            // create a for loop to show dinosaur based on Name &/or EnclosureNumber.
            // "if" no List - "There are no List in the Park."

            // to (A)dd
            // Prompt User for:
            // ¿ wh is the name of the species ?
            // answer - name
            // ¿ wh does it eat ?
            // answer - Diet type - Jonathon/Tricia
            // - WhenAcquired - dateTime stamp
            // ¿ hw much does it weigh ?
            // answer - Weight
            // ¿ wh is the enclosure number ?
            // answer - EnclosureNumber

            // to (R)emove
            // Prompt user for:
            // ¿ wh Name of Dinosaur they want to remove ?
            // - answer
            // Dinosaur present
            // ¿ Are you sure ?
            // Y - delete dino
            // print summary of Dinos we have left
            // N - go back to menu

            // not present
            // "We don't have that dinosaur, try again"

            // to (T)ransfer
            // Prompt user for:
            // ¿ wh dino do you want to move ?
            // Dinosaur present
            // ¿ wh EnclosureNumber do you want move {Name} to ?
            // not present
            // "We don't have that dinosaur, try again"

            // to (S)ummarize
            // var carnivoreTotal = 0;
            // var herbivoreTotal = 0;

            // if (Dinosaur.Diet = carnivoreTotal)
            // {
            //   carnivoreTotal += 1;
            // }
            // else
            // {
            //   herbivoreTotal += 1;
            // }
            // Console.WriteLine("There are {carnivoreTotal} carnivores. ");
            // Console.WriteLine("There are {herbivoreTotal} herbivores. ");

            // to (Q)uit
            // go back to the menu to repeat or choose another option.
        }
    }
}
