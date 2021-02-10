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
			//Yield
			//Return ett fordon i taget!
			foreach (var item in vehiclesParked)
			{
				yield return item;
			};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal bool AddVehicleToParkingPlace(T vehicle)
		{
			bool ret =false;
			for (int i = 0; i < vehiclesParked.Length; i++)
			{
				if (vehiclesParked[i] == null)
				{ 
					try
					{
						vehiclesParked[i] = vehicle;
						Console.WriteLine($"Vehicle {vehicle.Model} with reg no {vehicle.RegNo} is now parked in the Garage.");
						ret = true;
						break;
					}
					catch (ArgumentException e)
					{
						Console.WriteLine("Unfortunately something went wrong.");
						Console.WriteLine($"Error: {e.GetType().Name}, { e.Message}");
						ret = false;
						break;
					}
				}
			}
			return ret;
		}
	}
}
