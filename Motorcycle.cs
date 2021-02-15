using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Motorcycle : Vehicle
	{
		public int NoOfCylinderVolume { get; set; }

		public Motorcycle(int cylinderVolume, string brand, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity) : base(brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity)
		{
			NoOfCylinderVolume = cylinderVolume;
		}
	}
}
