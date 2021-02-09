using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Garage<T>
	{
		private VehiclesInGarage[,] vehiclesParked;

		private int numberOfParkingPlaces;

		public Garage()
		{

		}

		public Garage(int numberOfParkingPlaces)
		{
			NumberOfParkingPlaces = numberOfParkingPlaces;
		}

		public int NumberOfParkingPlaces { get; set; }
		public int AvailableParkingPlaces { get; set; }

	}
}
