using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrFit.Utilities
{
    public class CalorieCalculator
    {
        public double CalculateCalories(string gender, double weight, double height, int age, double activityLevel, string goal)
        {
            try
            {
                double bmr;
                if (gender.ToLower() == "male")
                {
                    bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                }
                else if (gender.ToLower() == "female")
                {
                    bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                }
                else
                {
                    throw new ArgumentException("Ошибочные данные.");
                }

                double calorieNeeds = bmr * activityLevel;

                calorieNeeds = AdjustCaloriesForGoal(calorieNeeds, goal);

                return calorieNeeds;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при расчете калорий: {ex.Message}");
                return 0; 
            }
        }

        private double AdjustCaloriesForGoal(double calorieNeeds, string goal)
        {
            try
            {
                switch (goal.ToLower())
                {
                    case "поддержание веса":
                        return calorieNeeds;
                    case "снижение веса":
                        return AdjustCaloriesForWeightLoss(calorieNeeds);
                    case "набор веса":
                        return AdjustCaloriesForWeightGain(calorieNeeds);
                    default:
                        throw new ArgumentException("Ошибочные данные.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при регулировке калорий: {ex.Message}");
                return calorieNeeds; 
            }
        }

        public double AdjustCaloriesForWeightGain(double calorieNeeds)
        {
            return calorieNeeds + (0.15 * calorieNeeds);
        }

        public double AdjustCaloriesForWeightLoss(double calorieNeeds)
        {
            return calorieNeeds - (0.15 * calorieNeeds);
        }

    }

}
