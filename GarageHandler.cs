using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	public class GarageHandler : IHandler
	{
		private Garage<Vehicle> garage;
		
		public void CreateGarage()
		{
			Console.WriteLine("How many Parking places should there be in the Garage?");
			string input = Console.ReadLine();
			if (input != null)
			{ 
				int.TryParse(input, out int parkingCapacity);
				garage = new Garage<Vehicle>(numberOfParkingPlaces: parkingCapacity);
				Console.WriteLine($"A garage with {parkingCapacity} parking places are created.");
			}
		}
		public void PopulateGarage()
		{
			Console.WriteLine("PrePopulate or park Vehicle(s) Manually? (P or M), Q to Main Menu.");
			string input = Console.ReadLine();
			string choice = input.ToUpper().Substring(0, 1);
			bool toMainMenu = false;
			var ui = new UI();
			
			if (garage == null) CreateGarage();

			do
			{
				switch (choice)
				{
					case ("P"):
						var vehiclesToPark = new List<Vehicle>
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
						AddVehicleToGarage(vehiclesToPark);
						toMainMenu = true;
						break;
					case ("M"):
						ui.ParkManuallyMenu();
						var vehiclesToPark2 = new List<Vehicle>
						{
							new Car(200, "Volvo V60", "ABC121", "Green", 4, "petrol", 65),
						};
						AddVehicleToGarage(vehiclesToPark2);
						toMainMenu = true;
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
				if (!garage.AddVehicleToParkingPlace(item))
				{
					Console.WriteLine("The Garage is full, please come back later.");
					break;
				}
			}
		}

		public void ParkVechicle()
		{
			PopulateGarage();
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
			if (garage == null) CreateGarage();
			var checkParkedVehicles = garage?.vehiclesParked;
			foreach (var item in checkParkedVehicles)
			{
				if (item != null)
				{ 
					Console.WriteLine($"{item.GetType()} Model: {item.Model}, RegNo: {item.RegNo}.");
				}
			}
		}
	}
}
