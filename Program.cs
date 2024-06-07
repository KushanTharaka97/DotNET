using System;
// Exercise making a Tmprature converter Celcies to Faranhiet and Faranhiet to Celciews
public class Program
{
    public static void Main(String[] args)
    {
        int? tempMaterial = null;
        Console.WriteLine("Temprature Checker: \n intput number \n 1] Celcius \n 2] Fahrenheit ");
        tempMaterial = int.Parse(Console.ReadLine());
        while (tempMaterial != 0)
        {

            Console.WriteLine("Add value to Convert:");
            float tempratureToConvert = float.Parse(Console.ReadLine());
            float convertedTemp;
            if (tempMaterial == 1)
            {
                convertedTemp = (float)Math.Floor((tempratureToConvert - 32) * 5 / 9);
                Console.WriteLine(tempratureToConvert + " Fahrenheit -> " + convertedTemp + " Celcius ");
            }
            else if (tempMaterial == 2)
            {
                convertedTemp = (tempratureToConvert * 9 / 5) + 32;
                Console.WriteLine(tempratureToConvert + " Celcius -> " + convertedTemp + " Fahrenheit ");
            }
            else
            {
                Console.WriteLine(" Error in Input ");
            }
        }
    }
}