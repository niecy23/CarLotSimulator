using System;
using System.Reflection;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE

            //Create a seperate class file called Car - DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
            //The methods should take one string parameter: the respective noise property - DONE


            //Now that the Car class is created we can instanciate 3 new cars - DONE
            //Set the properties for each of the cars - DONE
            //Call each of the methods for each car - DONE



            //Creating an instance of the CarLot class.
            var lot = new CarLot();

            //Way #1 - Adding a new car and adding it to the list of cars called "lot.Cars".
            var newCar1 = new Car();

                newCar1.Year = 2006;
                newCar1.Make = "Honda";
                newCar1.Model = "Civic";
                newCar1.EngineNoise = "Vroom";
                newCar1.HonkNoise = "Beep";
                newCar1.IsDriveable = true;

            lot.Cars.Add(newCar1);

            //Way #2 - Adding a new car and adding it to the list of cars called "lot.Cars".
            var newCar2 = new Car()
            {
                Year = 2017,
                Make = "Ford",
                Model = "Expedition",
                EngineNoise = "Buzz",
                HonkNoise = "Boom",
                IsDriveable = true
            };

            lot.Cars.Add(newCar2);

            //Way #3 - Adding a new car and adding it to the list of cars called "lot.Cars".
            var newCar3 = new Car(2015, "Chevrolet", "Tahoe", "Click", "Wonk", true);

            lot.Cars.Add(newCar3);


            //Calling the MakeEngineNoise method for each car. 
            newCar1.MakeEngineNoise(newCar1.EngineNoise);
            newCar2.MakeEngineNoise(newCar2.EngineNoise);
            newCar3.MakeEngineNoise(newCar3.EngineNoise);

            //Calling the MakeHonkNoise method for each car. 
            newCar1.MakeHonkNoise(newCar1.HonkNoise);
            newCar2.MakeHonkNoise(newCar2.HonkNoise);
            newCar3.MakeHonkNoise(newCar3.HonkNoise);


            //Printing the list of cars with the Year, Make, and Model to the console. 
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}"); 
            }



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - DONE

            //*************BONUS X 2*************//

            //Create a CarLot class - DONE
            //It should have at least one property: a List of cars - DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console - DONE



        }
    }
}
