﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Boat : Vehicle
	{
		public int Length { get; set; }

		public Boat(int length, string brand, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity) : base(brand, model, regNo, color, noOfWheels, fuelType, fuelCapacity)
		{
			Length = length;
		}
	}
}
