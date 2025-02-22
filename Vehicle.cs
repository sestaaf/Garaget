﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	public abstract class Vehicle
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		internal string RegNo { get; set; }
		public string Color { get; set; }
		public int NoOfWheels { get; set; }
		public string FuelType { get; set; }
		public int FuelCapacity { get; set; }

		public Vehicle(string brand, string model, string regNo, string color, int noOfWheels, string fuelType, int fuelCapacity)
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
