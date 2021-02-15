using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage
{
	class Garage<T> : IEnumerable<T> where T : Vehicle
	{

		private T[] vehiclesParked;
		private int count;

		public T this[int index]
		{
			get
			{
				return vehiclesParked[index];
			}
			set
			{
				vehiclesParked[index] = value;
			}
		}

		public bool IsFull => count >= vehiclesParked.Length;

		public Garage(int numberOfParkingPlaces)
		{
			vehiclesParked = new T[numberOfParkingPlaces];
			NumberOfParkingPlaces = numberOfParkingPlaces;
		}


		public bool Park(T vehicle)
		{
			for (int i = 0; i < vehiclesParked.Length; i++)
			{
				if(vehiclesParked[i] is null)
				{
					vehiclesParked[i] = vehicle;
					count++;
					return true;
				}
			}
			return false;

		}

		public int NumberOfParkingPlaces { get; set; }
		public T VehiclesParked { get; set; }

		public IEnumerator<T> GetEnumerator()
		{
			//Yield
			//Return ett fordon i taget!

			foreach (var item in vehiclesParked)
			{
				if (item != null)
					yield return item;
			}
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal bool Remove(T result)
		{
			for (int i = 0; i < vehiclesParked.Length; i++)
			{
				if (vehiclesParked[i] == result)
				{
					vehiclesParked[i] = null;
					count--;
					return true;
				}

			}
			return false;
		}
	}
}
