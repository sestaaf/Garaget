using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class UI : IUI
	{
        private GarageHandler garageHandler;
        //private Vehicle vehicle;

        public UI()
		{
            garageHandler = new GarageHandler();
		}
		public void MainMenu()
		{
            char nav = ' ';

            while (true)
            {
                Console.WriteLine("\nPlease navigate through the menu by inputting the number \n(1, 2, 3 , 4, 5, 6, 7 or Q) of your choice"
                    + "\n1. Create a Garage."
                    + "\n2. Populate the Garage."
                    + "\n3. Park a Vehicle in the Garage."
                    + "\n4. Get a parked Vehicle out of the Garage."
                    + "\n5. Find a specific parked Vehicle by Registration No."
                    + "\n6. Search for Vehicle(s) by Properties."
                    + "\n7. List ALL Vehicles parked in the Garage."

                    + "\nQ. Exit the application\n");

                Console.Write("Input > ");

                string input = Console.ReadLine();

                try
                {
                    nav = input[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("\nPlease enter some input!");
                }

                switch (nav)
                {
                    case '1':
                        garageHandler.CreateGarage();
                        break;
                    case '2':
                        garageHandler.PopulateGarage();
                        break;
                    case '3':
                        garageHandler.ParkVechicle();
                        break;
                    case '4':
                        garageHandler.GetVehicleOut();
                        break;
                    case '5':
                        garageHandler.FindVehicleByRegNo();
                        break;
                    case '6':
                        garageHandler.SearchVehicleByProperties();
                        break;
                    case '7':
                        garageHandler.ListAllParkedVehicles();
                        break;
                    case 'Q': // Exit Menu.
                    case 'q':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } 

        }

		public void ParkManuallyMenu()
		{
            bool returnToMainMenu = false;
            do
            {
                Console.WriteLine("\nPlease navigate through the menu by inputting the number \n(1, 2, 3 , 4, 5, 6, 7 or Q) of your choice"
                    + "\n1. Park a Car."
                    + "\n2. Park a Motorcycle."
                    + "\n3. Park a Trike."
                    + "\n4. Park a Bus."
                    + "\n5. Park a Boat."
                    + "\n6. Park a Airplane."
                    + "\n7. List ALL Vehicles parked in the Garage."

                    + "\nQ. Exit the application\n");

                Console.Write("Input > ");

                string input = Console.ReadLine();
                char nav = ' ';
                try
                {
                    nav = input[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("\nPlease enter some input!");
                }

                switch (nav)
                {
                    case '1':
                        //public Car(int noOfHorsePowers, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity)
                        Console.WriteLine("Please enter Model: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("Please enter Reg No: ");
                        string regNo = Console.ReadLine();
                        Console.WriteLine("Please enter no of HorsePowers: ");
                        input = Console.ReadLine();
                        int.TryParse(input, out int noOfHorsePowers);
                        Console.WriteLine("Please enter Model: ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Please enter Model: ");
                        input = Console.ReadLine();
                        int.TryParse(input, out int noOfWheels);
                        Console.WriteLine("Please enter Model: ");
                        string fuelType = "";
                        Console.WriteLine("Please enter Model: ");
                        input = Console.ReadLine();
                        int.TryParse(input, out int fuelCapacity);
						Console.WriteLine($"{noOfHorsePowers}, {model}, {regNo}, {color}, {noOfWheels}, {fuelType}, {fuelCapacity}");
                        break;
                    case '2':
                        
                        break;
                    case '3':
                        
                        break;
                    case '4':
                        
                        break;
                    case '5':
                        
                        break;
                    case '6':
                        
                        break;
                    case '7':
                        garageHandler.ListAllParkedVehicles();
                        break;
                    case 'Q': // Exit Menu.
                    case 'q':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (!returnToMainMenu);
        }
	}
}
