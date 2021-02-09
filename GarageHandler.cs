using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	public class GarageHandler : IHandler, IEnumerable<T>
	{
		private Garage<Vehicle> garage;

		public void CreateGarage()
		{
			Console.WriteLine("How many Parking places in Garage?");
			string input = Console.ReadLine();
			if (input != null)
			{ 
				int.TryParse(input, out int parkingCapacity);
				garage = new Garage<Vehicle>(numberOfParkingPlaces: parkingCapacity);
				Console.WriteLine($"A garage with {parkingCapacity} are created.");
			}
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

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public void GetVehicleOut()
		{
			throw new NotImplementedException();
		}

		public void ParkVechicle()
		{

			throw new NotImplementedException();
		}

		public void PopulateGarage()
		{
			var parkedVehicles = garage.VehiclesParked;
			
			// Bara test tills jag vet hur detta ska göras.
			foreach (var item in parkedVehicles.ToString())
			{
				Console.WriteLine(item);
			}
		}

		public void SearchVehicleByProperties()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
