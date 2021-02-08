using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Airplane : Vehicle
	{
		public int NoOfEngines { get; set; }

		public Airplane(int noOfEngines, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity) : base(model, regNo, color, noOfWheels, fuelType, fuelCapacity)
		{
			NoOfEngines = noOfEngines;
		}
	}
}
