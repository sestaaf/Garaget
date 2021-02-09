using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Garage<T> : IEnumerable<T> where T : Vehicle
	{
		
		private T[] vehiclesParked;

		private int numberOfParkingPlaces;


		public Garage(int numberOfParkingPlaces)
		{
			vehiclesParked = new T[numberOfParkingPlaces];
			NumberOfParkingPlaces = numberOfParkingPlaces;
		}

		public int NumberOfParkingPlaces { get; set; }
		public T VehiclesParked { get; set; }

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
