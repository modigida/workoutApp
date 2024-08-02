using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class CalculateExercise
    {
        List<Exercise> allSquats = new List<Exercise>();
        List<Exercise> allBenches = new List<Exercise>();
        List<Exercise> allDeadlifts = new List<Exercise>();

        public double total;
        public double amountOfRepetitions;
        public double timesLiftedBodyWeight;
        public double totalAverage;

        public double totalSquats;
        public double totalBenches;
        public double totalDeadlifts;

        public double averageSquats;
        public double averageBenches;
        public double averageDeadlifts;

        public string leftSquats;
        public string leftBenches;
        public string leftDeadlifts;

        public double maxSquats;
        public double maxBenches;
        public double maxDeadlifts;

        public void CopyExerciseList(List<Exercise> exerciseList)
        {
            foreach (Exercise exercise in exerciseList) 
            {
                if(exercise.Type == ExerciseType.Squat)
                {
                    allSquats.Add(exercise);
                }
                else if(exercise.Type == ExerciseType.Bench)
                {
                    allBenches.Add(exercise);
                }
                else //exercise.Type == ExerciseType.Deadlift
                {
                    allDeadlifts.Add(exercise);
                }
            }
        }
        public void CalculateTotal()
        {
            foreach (var item in allSquats)
            {
                totalSquats += item.RepWeight;
            }
            foreach(var item in allBenches)
            {
                totalBenches += item.RepWeight;
            }
            foreach (var item in allDeadlifts)
            {
                totalDeadlifts += item.RepWeight;
            }
        }
        public void CalculateAverage()
        {
            averageSquats = totalSquats / allSquats.Count;
            averageBenches = totalBenches / allBenches.Count;
            averageDeadlifts = totalDeadlifts / allDeadlifts.Count;
        }
        public void CalculateMax()
        {
            foreach (var item in allSquats)
            {
                if (item.RepWeight > maxSquats)
                {
                    maxSquats = item.RepWeight;
                }
            }
            foreach (var item in allBenches)
            {
                if (item.RepWeight > maxBenches)
                {
                    maxBenches = item.RepWeight;
                }
            }
            foreach (var item in allDeadlifts)
            {
                if (item.RepWeight > maxDeadlifts)
                {
                    maxDeadlifts = item.RepWeight;
                }
            }
        }
        public void LeftToReachGoal(User user)
        {
            double left = 0;
            if(user.GoalUnit == UnitType.Percent)
            {
                user.GoalSquat = (user.GoalSquat / 100) * user.BodyWeight;
                user.GoalBench = (user.GoalBench / 100) * user.BodyWeight;
                user.GoalDeadlift = (user.GoalDeadlift / 100) * user.BodyWeight;
            }

            if (maxSquats < user.GoalSquat)
            {
                left = user.GoalSquat - maxSquats;
                leftSquats = left.ToString("0.##" + " KG left");
            }
            else
            {
                leftSquats = "Goal reached";
            }

            if (maxBenches < user.GoalBench)
            {
                left = user.GoalBench - maxBenches;
                leftBenches = left.ToString("0.##" + " KG left");
            }
            else
            {
                leftBenches = "Goal reached";
            }

            if (maxDeadlifts < user.GoalDeadlift)
            {
                left = user.GoalDeadlift - maxDeadlifts;
                leftDeadlifts = left.ToString("0.##" + " KG left");
            }
            else
            {
                leftDeadlifts = "Goal reached";
            }
        }
        public void CalculateTotalTotal()
        {
            total = totalSquats + totalBenches + totalDeadlifts;
        }
        public void TimesLiftedBodyWeight(User user)
        {
            timesLiftedBodyWeight = total / user.BodyWeight; 
        }
        public void AmountOfRepetitions()
        {
            amountOfRepetitions = allSquats.Count + allBenches.Count + allDeadlifts.Count;
        }
        public void CalculateTotalAverage()
        {
            totalAverage = total / amountOfRepetitions;
        }
    }
}
