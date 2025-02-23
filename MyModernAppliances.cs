//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.Write("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNumber;

            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            string input = Console.ReadLine();
            if (!long.TryParse(input, out itemNumber))
            {
                Console.WriteLine("Invalid item number format.");
                return;
            }

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;

            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                {
                    // Assign appliance in list to foundAppliance variable
                    foundAppliance = appliance;

                    // Break out of loop (since we found what need to)
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
            }
            // Otherwise (appliance was found)
            else if (foundAppliance.Quantity > 0)
            {
                // Test found appliance is available
                // Checkout found appliance
                foundAppliance.DecreaseQuantity();

                // Write "Appliance has been checked out."
                Console.WriteLine("Appliance has been checked out.");
            }
            else
            {
                // Otherwise (appliance isn't available)
                // Write "The appliance is not available to be checked out."
                Console.WriteLine("The appliance is not available to be checked out.");
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.Write("Enter brand to search for: ");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string brand = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate through loaded appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliance.Brand.ToLower() == brand.ToLower())
                {
                    // Add current appliance in list to found list
                    foundAppliances.Add(appliance);
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");

            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");

            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");

            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");

            // Write "Enter number of doors: "
            Console.Write("Enter number of doors: ");

            // Get user input as string and assign to variable
            // Create variable to hold entered number of doors
            string input = Console.ReadLine();
            int numberOfDoors;

            // Convert user input from string to int and store as number of doors variable.
            if (!int.TryParse(input, out numberOfDoors) || (numberOfDoors != 0 && numberOfDoors != 2 && numberOfDoors != 3 && numberOfDoors != 4))
            {
                Console.WriteLine("Invalid input. Please enter 0, 2, 3, or 4.");
                return;
            }

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test that current appliance is a refrigerator
                if (appliance is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    Refrigerator refrigerator = (Refrigerator)appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors)
                    {
                        // Add current appliance in list to found list
                        foundAppliances.Add(refrigerator);
                    }
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");

            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");

            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");

            // Write "Enter grade:"
            Console.Write("Enter grade: ");

            // Get user input as string and assign to variable
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string inputGrade = Console.ReadLine();
            string grade;

            // Test input is "0"
            if (inputGrade == "0")
                // Assign "Any" to grade
                grade = "Any";
            // Test input is "1"
            else if (inputGrade == "1")
                // Assign "Residential" to grade
                grade = "Residential";
            // Test input is "2"
            else if (inputGrade == "2")
                // Assign "Commercial" to grade
                grade = "Commercial";
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling (previous) method
                return;
            }

            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");

            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");

            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.Write("Enter voltage: ");

            // Get user input as string
            // Create variable to hold voltage
            string inputVoltage = Console.ReadLine();
            int voltage;

            // Test input is "0"
            if (inputVoltage == "0")
                // Assign 0 to voltage
                voltage = 0;
            // Test input is "1"
            else if (inputVoltage == "1")
                // Assign 18 to voltage 
                voltage = 18;
            // Test input is "2"
            else if (inputVoltage == "2")
                // Assign 24 to voltage
                voltage = 24;
            // Otherwise
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling (previous) method
                return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> foundAppliances = new List<Appliance>();

            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Check if current appliance is vacuum
                if (appliance is Vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    Vacuum vacuum = (Vacuum)appliance;

                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    if ((grade == "Any" || vacuum.Grade == grade) && (voltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        // Add current appliance in list to found list
                        foundAppliances.Add(vacuum);
                    }
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
                string userPrompt = 
                    "\nPossible options:\n\n" +
                    "\t0 - Any\n" +
                    "\t1 - Kitchen\n" +
                    "\t2 - Work site\n\n" +
                    "Enter room type: ";

            // Not really sure if the do...while loop is necessary, instructions don't ask for it
            // Will ask Rocky his opinion
            //do
            //{

                // Write "Possible options:"
                // Write "0 - Any"
                // Write "1 - Kitchen"
                // Write "2 - Work site"
                // Write "Enter room type:"
                Console.Write(userPrompt);

                // Get user input as string and assign to variable
                string? userInput = Console.ReadLine().Trim(); // Trim whitespace in case user has butter fingers

                // Check input to see if it's empty or null and flip out at the user
                if (String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("\nPlease enter a value that is not empty or only whitespace!");
                    //continue;
                }

                //string trimmedInput = userInput.IsNullOrWhites userInput.Trim();

                // Create character variable that holds room type
                char roomType;

                // Test input is "0"
                // Assign 'A' to room type variable
                // Test input is "1"
                // Assign 'K' to room type variable
                // Test input is "2"
                // Assign 'W' to room type variable
                // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;

                switch (userInput)
                {
                    case "0":
                        roomType = 'A';
                        break;
                    case "1":
                        roomType = 'K';
                        break;
                    case "2":
                        roomType = 'W';
                        break;
                    default:
                        roomType = 'X'; // Nothing will be done with this really, but leaving it in case
                        Console.WriteLine($"\n\t*** '{userInput}' Is an invalid option!***\n");
                        return;
                }

                // Create variable that holds list of 'found' appliances
                List<Appliance> foundAppliances = new List<Appliance>();

                // Loop through Appliances
                foreach (Appliance appliance in Appliances)
                {
                    // Test current appliance is Microwave
                    // Down cast Appliance to Microwave
                    // Test room type equals 'A' or microwave room type
                    // Add current appliance in list to found list
              
                    // handles checking if appliance is a microwave, down casting it and also checking if it matches roomType or
                    // if user chose Any, all in one if()
                    if ((appliance is Microwave microwave) && (roomType is 'A' || roomType ==  microwave.RoomType))
                    {
                        foundAppliances.Add(microwave);
                    }
                
                }


                // Display found appliances
                 DisplayAppliancesFromList(foundAppliances, 0);


            //} while (true);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            // Write "Enter sound rating:"

            string userPrompt =
                    "\nPossible options:\n\n" +
                    "\t0 - Any\n" +
                    "\t1 - Quietest\n" +
                    "\t2 - Quieter\n" +
                    "\t3 - Quiet\n" +
                    "\t4 - Moderate\n\n" +
                    "Enter sound rating: ";

            //do
            //{

                Console.WriteLine(userPrompt);

                // Get user input as string and assign to variable
                string? userInput = Console.ReadLine().Trim();

                if (String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("\nPlease enter a value that is not empty or only whitespace!");
                    //continue;
                }

                // Create variable that holds sound rating
                string soundRating;
                // Test input is "0"
                // Assign "Any" to sound rating variable
                // Test input is "1"
                // Assign "Qt" to sound rating variable
                // Test input is "2"
                // Assign "Qr" to sound rating variable
                // Test input is "3"
                // Assign "Qu" to sound rating variable
                // Test input is "4"
                // Assign "M" to sound rating variable
                // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method

                switch(userInput)
                {
                    case "0":
                        soundRating = "Any";
                        break;
                    case "1":
                        soundRating = "Qt";
                        break;
                    case "2":
                        soundRating = "Qr";
                        break;
                    case "3":
                        soundRating = "Qu";
                        break;
                    case "4":
                        soundRating = "M";
                        break;
                    default:
                        soundRating = "NA";
                        Console.WriteLine("Inavlid option!");
                        return;
                        //break;
                }

                // Create variable that holds list of found appliances
                List<Appliance> foundAppliances = new List<Appliance>();

                // Loop through Appliances
                // Test if current appliance is dishwasher
                // Down cast current Appliance to Dishwasher
                foreach (Appliance appliance in Appliances)
                {

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    // Add current appliance in list to found list
                    if (appliance is Dishwasher dishwasher && (soundRating is "Any" || soundRating == dishwasher.SoundRating ))
                    {
                        foundAppliances.Add(dishwasher);
                    }
                }

                // Display found appliances (up to max. number inputted)
                DisplayAppliancesFromList(foundAppliances, 0);
            //} while (true);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            // Write "Enter type of appliance:"

            string userPrompt =
                   "\nAppliance types:\n\n" +
                   "\t0 - Any\n" +
                   "\t1 - Refrigerators\n" +
                   "\t2 - Vacuums\n" +
                   "\t3 - Microwaves\n" +
                   "\t4 - Dishwashers\n\n" +
                   "Enter type of appliance: ";

            Console.Write(userPrompt);

            // Get user input as string and assign to appliance type variable
            string? typeInput = Console.ReadLine().Trim();

            if (String.IsNullOrWhiteSpace(typeInput))
            {
                Console.WriteLine("\nPlease enter a value that is not empty or only whitespace!");
                return;
                //continue;
            }
;
            // Write "Enter number of appliances: "
            // Get user input as string and assign to variable
            Console.Write("\nEnter number of appliances: ");
            string? amountInput = Console.ReadLine().Trim();

            // Convert user input from string to int
            bool validInteger = int.TryParse(amountInput, out int parsedAmount);

            if (!validInteger)
            {
                Console.WriteLine("\nPlease enter a valid integer!");
                return;
            }


            // Create variable to hold list of found appliances
            // if the user input is "0" then we just copy the whole Appliances List over
            List<Appliance> foundAppliances = typeInput != "0" ? new List<Appliance>() : Appliances.ToList();

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            // If user input is not "0", then we loop through and check the types and add them
            // definitely a better way to do this but I am up passed my bedtime
            if (typeInput != "0")
            {
                foreach (Appliance appliance in Appliances)
                {
                    switch (typeInput)
                    {
                        case "1":
                            if (appliance is Refrigerator)
                            {
                                foundAppliances.Add(appliance);
                            }
                            break;
                        case "2":
                            if (appliance is Vacuum)
                            {
                                foundAppliances.Add(appliance);
                            }
                            break;
                        case "3":
                            if (appliance is Microwave)
                            {
                                foundAppliances.Add(appliance);
                            }
                            break;
                        case "4":
                            if (appliance is Dishwasher)
                            {
                                foundAppliances.Add(appliance);
                            }
                            break;
                        default:
                            Console.WriteLine("\nSOMETHING WEIRD IS GOING ON!!");
                            break;

                    }
                }

            }


            // Randomize list of found appliances
            foundAppliances.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(foundAppliances, parsedAmount);
        }
    }
}