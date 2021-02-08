using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Bus : Vehicle
	{
		public int NoOfSeats { get; set; }

		public Bus(int noOfSeats, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity) : base(model, regNo, color, noOfWheels, fuelType, fuelCapacity)
		{
			NoOfSeats = noOfSeats;
		}

	}
}
