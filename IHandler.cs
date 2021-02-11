using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	interface IHandler
	{
		void CreateGarage();
		void PopulateGarage();
		void GetVehicleOut();
		void FindVehicleByRegNo();
		void SearchVehicleByProperties();
		void ListAllParkedVehicles();

	}
}
