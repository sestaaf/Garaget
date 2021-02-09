using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	abstract class Vehicle
	{
		public string Model { get; set; }
		protected string RegNo { get; set; }
		public string Color { get; set; }
		public int NoOfWheels { get; set; }
		public string FuelType { get; set; }
		public int FuelCapacity { get; set; }

		public Vehicle(string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity)
		{
			Model = model;
			RegNo = regNo;
			Color = color;
			NoOfWheels = noOfWheels;
			FuelType = fuelType;
			FuelCapacity = fuelCapacity;
		}

	}
}
