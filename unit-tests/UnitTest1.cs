using System;
using Xunit;
using Services;
using Domain.Model;

namespace unit_tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestREECalcualtion()
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
            Assert.True(reeCals > 0);
        }
    }
}
