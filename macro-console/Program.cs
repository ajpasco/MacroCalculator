using System;
using Domain.Model;
using Services;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            CalorieService calorieService = new CalorieService();
            Person person = new Person()
            {
                Gender = Gender.Male,
                HeightFeet = 6,
                WeightPounds = 194,
                Age = 29
            };

            var reeCals = calorieService.CalcuateRestingEnergyExpenditure(person);
            Console.WriteLine("Calories = " + reeCals);
        }
    }
}
