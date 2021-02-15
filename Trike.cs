using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Trike : Vehicle
	{
		public int Weight { get; set; }

		public Trike(int weight, string brand, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity) : base(brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity)
		{
			Weight = weight;
		}
	}
}
