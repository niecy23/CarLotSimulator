using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
	public class CarLot
	{
        //Creating the CarLot class and adding it's properties. 
        public CarLot()
		{
		}

        public List<Car> Cars = new List<Car>();

        //Creating a static field to total the number of cars added to the Car class. 
        public static int numberOfCars;
       

    }
}

