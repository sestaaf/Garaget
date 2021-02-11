using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Garage<T> : IEnumerable<T> where T : Vehicle
	{

		public T[] vehiclesParked;

		public Garage(int numberOfParkingPlaces)
		{
			vehiclesParked = new T[numberOfParkingPlaces];
			NumberOfParkingPlaces = numberOfParkingPlaces;
		}

		public int NumberOfParkingPlaces { get; set; }
		public T VehiclesParked { get; set; }

		public IEnumerator<T> GetEnumerator()
		{
			//Yield
			//Return ett fordon i taget!
		
			foreach (var item in vehiclesParked)
			{
				yield return item;
			}
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
