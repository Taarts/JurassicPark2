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
        public DateTime WhenAcquired = DateTime.Now;
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
            var keepGoing = true;
            while (keepGoing)
            {

                var userAnswer = PromptForString("What would you like to do?\n To (V)iew the List in the park?\n To (A)dd a new Dinosaur to the park?\n to (R)emove a Dinosaur from the Park?\n To (T)ransfer a Dinosaur to another Enclosure?\n To (S)ummarize all the Dinosaurs we have?\n Or (Q)uit");
                // Console.WriteLine("This works");
                // Create method to describe class
                // private static void ViewDinosaur()
                // to (V)iew
                if (userAnswer == "V")
                {
                    var nameOrEnclosure = PromptForString("Would you like to view the Dinosaurs in order of (N)ame or (E)nclosure? ");
                    if (nameOrEnclosure == "N")
                    {
                        var sortedByName = dinosaursList.OrderBy(dino => dino.Name);

                        foreach (var name in sortedByName)
                        {
                            Console.WriteLine(name.DisplayDinosaur());
                        }
                    }

                    else
                      if (nameOrEnclosure == "E")
                    {
                        var sortedByEnclosure = dinosaursList.OrderBy(dino => dino.EnclosureNumber);

                        foreach (var name in sortedByEnclosure)
                        {
                            Console.WriteLine(name.DisplayDinosaur());
                        }
                        foreach (var Dinosaur in dinosaursList)
                        {
                            Dinosaur.DisplayDinosaur();
                        }
                    }
                }
                // need to make a loop to go back if they 
                else
                    // to (A)dd
                    if (userAnswer == "A")
                {
                    var dino = new Dinosaur();

                    dino.Name = PromptForString("What is the name of the species you'd like to add? ");
                    dino.Diet = PromptForString("Is it a (C)arnivore or an (H)erbivore? ");
                    dino.Weight = PromptForInteger("How much does it weigh? ");
                    dino.EnclosureNumber = PromptForInteger("Which Enclosure do you want to put the beastie in? ");

                    dinosaursList.Add(dino);
                }
                else
                  // to (R)emove
                  if (userAnswer == "R")
                {
                    var dinoToRemove = PromptForString("What is the name of the species you'd like to remove? ");

                    Dinosaur foundDinosaur = dinosaursList.Find(dino => dino.Name == dinoToRemove);

                    if (dinoToRemove == null)
                    {
                        Console.WriteLine("No Match Found - sucker!");
                    }
                    else
                    {
                        var posNeg = PromptForString($"Are you sure you want to remove {foundDinosaur.Name}? Y/N");
                        {
                            if (posNeg == "Y")
                            {
                                dinosaursList.Remove(foundDinosaur);
                            }
                        }
                    }
                }

                else
                       if (userAnswer == "T")
                {
                    var dinoToTransfer = PromptForString("What is the name of the species you'd like to transfer? ");

                    Dinosaur foundDinosaur = dinosaursList.Find(dino => dino.Name == dinoToTransfer);

                    if (dinoToTransfer == null)
                    {
                        Console.WriteLine("Dini dini... oh we don't have that dino!");
                    }
                    else
                    {
                        var posNeg = PromptForString($"Are you sure you want to transfer {foundDinosaur.Name} from {foundDinosaur.EnclosureNumber}? Y/N");
                        {
                            if (posNeg == "Y")
                            {
                                var newEnclosure = PromptForInteger($"Which enclosure number do you want to move {foundDinosaur.Name} to? ");

                                foundDinosaur.EnclosureNumber = newEnclosure;
                            }
                        }
                    }
                }
                // to (S)ummarize
                else
                    if (userAnswer == "S")
                {
                    var carnivoreTotal = 0;
                    var herbivoreTotal = 0;

                    foreach (var dinoEntry in dinosaursList)
                    {
                        if (dinoEntry.Diet == "C")
                        {
                            carnivoreTotal += 1;
                        }

                        else
                      if (dinoEntry.Diet == "H")
                        {
                            herbivoreTotal += 1;
                        }
                    }
                    Console.WriteLine($"There are {carnivoreTotal} carnivores. ");
                    Console.WriteLine($"There are {herbivoreTotal} herbivores. ");

                }
                if (userAnswer == "Q")
                {
                    keepGoing = false;
                }
                // go back to the menu to repeat or choose another option.

            }
        }
    }
}