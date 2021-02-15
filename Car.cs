using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Car : Vehicle
	{
		public int NoOfHorsePowers { get; set; }

		public Car(int noOfHorsePowers, string brand, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity) : base(brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity)
		{
			NoOfHorsePowers = noOfHorsePowers;
		}

	}
}
