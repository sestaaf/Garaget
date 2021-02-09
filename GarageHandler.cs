using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class GarageHandler : IHandler
	{
		public void CreateGarage()
		{
			Console.WriteLine("How many Parking places in Garage?");
			string input = Console.ReadLine();
			int.TryParse(input, out int parkingCapacity);
			var garage = new Garage<int>(numberOfParkingPlaces: parkingCapacity);
		}

		public void FindVehicleByRegNo()
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
			throw new NotImplementedException();
		}

		public void SearchVehicleByProperties()
		{
			throw new NotImplementedException();
		}
	}
}
