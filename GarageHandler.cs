using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage
{
	public class GarageHandler : IHandler
	{
		private Garage<Vehicle> garage;
		
		public void CreateGarage()
		{
			bool testGarageSize = false;

			do
			{
				Console.WriteLine("How many Parking places should there be in the Garage?");
				string input = Console.ReadLine();
				int.TryParse(input, out int inputInt);
				if (inputInt >= 10)
				{
					int.TryParse(input, out int parkingCapacity);
					garage = new Garage<Vehicle>(numberOfParkingPlaces: parkingCapacity);
					Console.WriteLine($"A garage with {parkingCapacity} parking places are created.");
					testGarageSize = true;
				}
				else
				{
					Console.WriteLine("Please enter a value bigger or equal to 10!");
					testGarageSize = false;
				}

			} while (!testGarageSize);
		}
		public void PopulateGarage()
		{
			if (garage == null)
			{
				Console.WriteLine("The Garage is not yet built!");
				CreateGarage();
			}

			Console.WriteLine("\nManually park a Vehicle or PrePopulate the Garage? \n(Your choise: M or P, Q to Main Menu.\n");
			Console.Write("Input > ");
			//string input = Console.ReadLine();
			string choice = Console.ReadLine().ToUpper().Substring(0, 1);
			bool toMainMenu = false;
			var ui = new UI();

			do
			{
				switch (choice)
				{
					case ("M"):
						ui.ParkManuallyMenu();
						toMainMenu = true;
						break;
					case ("P"):
						var vehiclesToParkPopulate = new List<Vehicle>
						{
							new Car(200, "Volvo V60", "ABC121", "Green", 4, "petrol", 65),
							new Car(250, "Volvo V90", "ABC122", "Red", 4, "diesel", 70),
							new Car(190, "Volkswagen Passat", "BAC121", "Blue", 4, "electric/petrol", 60),
							new Car(200, "Volkswagen Golf", "BAC122", "White", 4, "petrol", 60),
							new Bus(60, "Scania", "CBA121", "Blue", 8, "diesel", 100),
							new Bus(100, "Man", "CBA122", "Red", 4, "diesel", 120),
							new Motorcycle(1200, "BMW R1200RS", "CAB121", "Silver", 2, "petrol", 20),
							new Airplane(2, "Attack Aircraft", "XYXKK34122", "White", 4, "petrol", 200),
							new Boat(10, "Chris Craft Triple", "KKXCY47192", "Yellow", 4, "petrol", 200),
						};
						AddVehicleToGarage(vehiclesToParkPopulate);
						break;
					case ("Q"):
						toMainMenu = true;
						break;
					default:
						break;
				}

			} while (!toMainMenu);
		}

		public void AddVehicleToGarage(IEnumerable<Vehicle> vehiclesToPark)
		{
			foreach (var item in vehiclesToPark)
			{
				var message = AddVehicleToParkingPlace(item);
				Console.WriteLine(	message);
			}
		}
		public void GetVehicleOut()
		{
			throw new NotImplementedException();
		}
		public void FindVehicleByRegNo()
		{
			Console.WriteLine("What Reg No do you look for?");
			string regNoToSearch = Console.ReadLine().ToUpper();
			if (regNoToSearch != null)
			{
				//var result = garage.VehiclesParked
				//		.Where(r => r.RegNo == regNoToSearch);
				//return result;
			}
		}
		public void SearchVehicleByProperties()
		{
			throw new NotImplementedException();
		}
		public void ListAllParkedVehicles()
		{
			if (garage != null)
			{
				foreach (var item in garage)
				{
					if (item != null)
					{ 
						Console.WriteLine($"{item.GetType().Name} Model: {item.Model}, RegNo: {item.RegNo}.");
					}
				}
			}
		}
		internal string AddVehicleToParkingPlace(Vehicle vehicle)
		{
			// Check if RegNo is already in the Garage!
			var found = garage.FirstOrDefault(g => g?.RegNo == vehicle.RegNo);

			if (found != null) return "RegNo exists! Already parked. Wrong Reg No given, please try again.";

			// Try to park the vehicle and test if it's possible.
			var parkingWorks = (garage.Park(vehicle));
			return parkingWorks ? $"Ok - Your {vehicle.GetType().Name} is parked." : "Error - Parking not possible! Garage is full!";


			//bool addVehicleTest = false;



			//for (int i = 0; i < garage.Count(); i++)
			//{
			//	foreach (var item in garage)
			//	{
			//		if (vehicle.RegNo == item.RegNo)
			//		{
			//			Console.WriteLine("This Reg No already exists in the Garage!\nPlease try again");
			//			addVehicleTest = false;
			//			return false;
			//		}
			//	}
			//	if (garage[i] == null)
			//	{
			//		try
			//		{
			//			garage[i] = vehicle;
			//			Console.WriteLine($"Vehicle {vehicle.Model} with reg no {vehicle.RegNo} are now parked in the Garage.");
			//			addVehicleTest = true;
			//			break;
			//		}
			//		catch (ArgumentException e)
			//		{
			//			Console.WriteLine("Unfortunately something went wrong.");
			//			Console.WriteLine($"Error: {e.GetType().Name}, { e.Message}");
			//			addVehicleTest = false;
			//			break;
			//		}
			//	}
			//}
			//return addVehicleTest;
		}
	}
}
