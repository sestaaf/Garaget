using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class UI : IUI
	{
		public void MainMenu()
		{
            char nav = ' ';

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, Q) of your choice"
                    + "\n1. Create a Garage."
                    + "\n2. Populate the Garage."
                    + "\n3. Park a Vehicle in the Garage."
                    + "\n4. Get a parked Vehicle out of the Garage."
                    + "\n5. Find a specific parked Vehicle by Registration No."
                    + "\n6. Search for Vehicle(s) by Properties."

                    + "\nQ. Exit the application\n");

                Console.Write("Input > ");

                string input = Console.ReadLine();

                try
                {
                    nav = input[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("\nPlease enter some input!");
                }

                switch (nav)
                {
                    case '1':
                        CreateGarage();
                        break;
                    case '2':
                        PopulateGarage();
                        break;
                    case '3':
                        ParkVechicle();
                        break;
                    case '4':
                        GetVehicleOut();
                        break;
                    case '5':
                        FindVehicleByRegNo();
                        break;
                    case '6':
                        SearchVehicleByProperties();
                        break;
                    case 'Q': // Exit Menu.
                    case 'q':
                        break;
                    default:
                        break;
                }

            } 

        }
    }
}
