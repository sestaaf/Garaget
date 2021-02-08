using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Motorcycle : Vehicle
	{
		public int NoOfCylinderVolume { get; set; }

		public Motorcycle(int noOfCylinderVolume, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity) : base(model, regNo, color, noOfWheels, fuelType, fuelCapacity)
		{
			NoOfCylinderVolume = noOfCylinderVolume;
		}
	}
}
