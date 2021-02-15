using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Airplane : Vehicle
	{
		public int NoOfEngines { get; set; }

		public Airplane(int noOfEngines, string brand, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity) : base(brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity)
		{
			NoOfEngines = noOfEngines;
		}
	}
}
