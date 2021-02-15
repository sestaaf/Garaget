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
		string GetVehicleCommonProperties(string input, out string model, out string regNo, out string color, out int noOfWheels, out string fuelType, out int fuelCapacity);
		bool GetVehicleOut();
		void ListAllParkedVehicles();
		void PrePopulateGarage();
		void SearchVehicleByProperties();
	}
}