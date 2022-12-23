﻿using System;
namespace CarLotSimulator
{
	public class Car
	{

        //Creating the Car class and adding it's properties. 
        public Car()
		{
		}
        
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }


        public void MakeEngineNoise (string engineNoise)

        {
            Console.WriteLine(engineNoise); 
        }

        public void MakeHonkNoise(string honkNoise)

        {
            Console.WriteLine(honkNoise); 
        }
    }
}

