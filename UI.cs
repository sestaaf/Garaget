using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class UI : IUI
	{
		private GarageHandler garageHandler;

		public UI()
		{
			garageHandler = new GarageHandler();
		}
		public void MainMenu()
		{
			while (true)
			{
				Console.WriteLine("\nPlease navigate through the menu by entering either of \n(1, 2, 3 , 4, 5, 6, 7 or Q of your choice:\n"
					+ "\n1. Create a Garage."
					+ "\n2. Auto-Populate the Garage."
					+ "\n3. Manually Park a Vehicle."
					+ "\n4. Find a specific parked Vehicle by Registration No."
					+ "\n5. Get a parked Vehicle out of the Garage."
					+ "\n6. Search for Vehicle(s) by Properties."
					+ "\n7. List ALL Vehicles parked in the Garage."
					+ "\n\nQ. Exit the application\n");

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
						garageHandler.CreateGarage();
						break;
					case '2':
						garageHandler.GaragePopulated();
						garageHandler.PrePopulateGarage();
						break;
					case '3':
						garageHandler.GaragePopulated();
						ParkManuallyMenu();
						break;
					case '4':
						garageHandler.FindVehicleByRegNo();
						break;
					case '5':
						garageHandler.GetVehicleOut();
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
			bool returnToLastMenu = false;
			char nav = ' ';

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
					+ "\n\nQ. Exit the application\n");

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

				string brand, model, regNo, color, fuelType;
				int noOfHorsePowers, noOfWheels, fuelCapacity, cylinderVolume;
				int weight, noOfSeats, length, noOfEngines;

				input = garageHandler.GetVehicleCommonProperties(input, out brand, out model, out regNo, out color, out noOfWheels, out fuelType, out fuelCapacity);

				switch (nav)
				{
					case '1':
						noOfHorsePowers = Util.AskForInt("Enter no of HorsePowers (eg 150):\t");
						garageHandler.AddVehicleToParkingPlace(new Car(noOfHorsePowers, brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity));
						break;
					case '2':
						cylinderVolume = Util.AskForInt("Enter Cylinder volume (eg 1200):\t");
						garageHandler.AddVehicleToParkingPlace(new Motorcycle(cylinderVolume, brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity));
						break;
					case '3':
						weight = Util.AskForInt("Enter the Trikes weight (eg 325):\t");
						garageHandler.AddVehicleToParkingPlace(new Trike(weight, brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity));
						break;
					case '4':
						noOfSeats = Util.AskForInt("Enter no of Bus seats (eg 50):\t");
						garageHandler.AddVehicleToParkingPlace(new Bus(noOfSeats, brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity));
						break;
					case '5':
						length = Util.AskForInt("Enter Boat length in m (eg 10):\t");
						garageHandler.AddVehicleToParkingPlace(new Boat(length, brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity));
						break;
					case '6':
						noOfEngines = Util.AskForInt("Enter no of Engines (eg 2):\t");
						garageHandler.AddVehicleToParkingPlace(new Airplane(noOfEngines, brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity));
						break;
					case '7':
						garageHandler.ListAllParkedVehicles();
						break;
					case 'Q': // Exit Menu.
					case 'q':
						returnToLastMenu = true;
						break;
					default:
						break;
				}
				
			} while (!returnToLastMenu);
		}
	}
}
