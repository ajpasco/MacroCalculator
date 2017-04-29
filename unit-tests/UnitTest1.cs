using System;
using Xunit;
using Services;
using Domain.Model;

namespace UnitTests.Services
{
    public class CalorieServiceTests
    {
        [Fact]
        public void TestREECalcualtion_Returns_Correct_Calorie()
        {
            CalorieService calorieService = new CalorieService();
            Person person = new Person()
            {
                Gender = Gender.Male,
                HeightFeet = 8, //change back to 6
                WeightPounds = 194,
                Age = 29
            };

            var reeCals = calorieService.CalcuateRestingEnergyExpenditure(person);
            Console.WriteLine("Calories = " + reeCals);
            Assert.True(reeCals == 1882);
        }
    }
}
