using System;
using static System.Math;

namespace NewFile
{
	class Program
	{
		static void Main(string[] args)
		{	
			Console.WriteLine("Please enter the patient's name:");			//Name of the patient			
			string name = Console.ReadLine();
			
			Console.WriteLine("Please enter the patient's height (cm):");	//Height of the patient
			double height = double.Parse(Console.ReadLine());
			
			while (height <= 0)
				{
					Console.WriteLine("Height is invalid.");
					Console.WriteLine("Please enter in height again.");
					
					height = double.Parse(Console.ReadLine());

				}
				
			Console.WriteLine("Height is valid.");
			
			Console.WriteLine("Please enter in the patient's temperature (C):"); // Temperature of the patient
			double temperature = double.Parse(Console.ReadLine());
			
			while (temperature > 50 && temperature < 10)
				{ 
					Console.WriteLine("Temperature is invalid.");
					Console.WriteLine("Please enter in temperature again.");
					
					temperature = double.Parse(Console.ReadLine());
					
				}
	
			Console.WriteLine("Temperature is valid.");
			
			Console.WriteLine("Please enter in the patient's weight (kg):");	// Weight of the patient (inputted by user)
			double weight = double.Parse(Console.ReadLine());					//Conversion to double
			
			while (weight < 0.1 && 1000 < weight)
				{
					Console.WriteLine("Weight is invalid.");
					Console.WriteLine("Please enter in weight again.");
					
					weight = double.Parse(Console.ReadLine());
					
				}
			
			double temperatureF = temperature*(9.0/5.0)+32;						//Calculates temperature in fahrenheit
			Console.WriteLine("The temperature of the patient in fahrenheit is {0} F" ,temperatureF);
			
			double Bmi = weight/(height * height);
			Console.WriteLine("The BMI of the patient is {0}", Bmi);
		}
	}
}
