using System.Collections.Generic;

namespace Garage
{
	public interface IHandler
	{
		void AddVehicleToGarage(IEnumerable<Vehicle> vehiclesToPark);
		string AddVehicleToParkingPlace(Vehicle vehicle);
		void CreateGarage();
		bool FindVehicleByRegNo();
		void GaragePopulated();
		string GetVehicleCommonProperties(string input, out string brand, out string model, out string regNo, out string color, out int noOfWheels, out string fuelType, out int fuelCapacity);
		void GetVehicleOut();
		void ListAllParkedVehicles();
		void PrePopulateGarage();
		void SearchVehicleByProperties(string brand, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity);
	}
}