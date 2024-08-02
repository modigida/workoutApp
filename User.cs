using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class User
    {
        private string username;
        private double bodyWeight;
        private UnitType goalUnit;
        private double goalSquat;
        private double goalBench;
        private double goalDeadlift;

        public User()
        {
            goalUnit = UnitType.KG;
        }
        public User(string username) : this(username, double.NaN, UnitType.KG,
            double.NaN, double.NaN, double.NaN)
        {
       
        }
        public User(string username, double bodyWeight, UnitType goalUnit, 
            double goalSquat, double goalBench, double goalDeadlift)
        {
            this.username = username;
            this.bodyWeight = bodyWeight;
            this.goalUnit = goalUnit;
            this.goalSquat = goalSquat;
            this.goalBench = goalBench;
            this.goalDeadlift = goalDeadlift;
        }
        
        #region PROPERTIES
        public string Username
        {
            get { return username;}
            set { username = value; }
        }
        public double BodyWeight
        {
            get { return bodyWeight; }
            set { bodyWeight = value; }
        }
        public UnitType GoalUnit
        {
            get { return goalUnit; }
            set { goalUnit = value; }
        }
        public double GoalSquat
        {
            get { return goalSquat; }
            set { goalSquat = value; }
        }
        public double GoalBench
        {
            get { return goalBench; }
            set { goalBench = value; }
        }
        public double GoalDeadlift
        {
            get { return goalDeadlift; }
            set { goalDeadlift = value; }
        }
        #endregion
        public string CalculateBenchGoal()
        {
            double benchGoal = 0.0;
            if (GoalUnit == UnitType.KG)
            {
                // benchGoal = percent
                benchGoal = (GoalBench / BodyWeight) * 100;
            }
            else //(user.GoalUnit == UnitType.Percent)
            {
                // benchGoal = KG
                benchGoal = (GoalBench / 100) * BodyWeight;
            }
            string strOut = benchGoal.ToString("f2");
            return strOut;
        }
        public string CalculateSquatGoal()
        {
            double squatGoal = 0.0;
            if (GoalUnit == UnitType.KG)
            {
                // squatGoal = percent
                squatGoal = (GoalSquat / BodyWeight) * 100;
            }
            else //(user.GoalUnit == UnitType.Percent)
            {
                // squatGoal = KG
                squatGoal = (GoalSquat / 100) * BodyWeight;
            }
            string strOut = squatGoal.ToString("f2");
            return strOut;
        }
        public string CalculateDeadliftGoal()
        {
            double deadliftGoal = 0.0;
            if (GoalUnit == UnitType.KG)
            {
                // user.deadliftGoal = percent
                deadliftGoal = (GoalDeadlift / BodyWeight) * 100;
            }
            else //(user.GoalUnit == UnitType.Percent)
            {
                // deadliftGoal = KG
                deadliftGoal = (GoalDeadlift / 100) * BodyWeight;
            }
            string strOut = deadliftGoal.ToString("f2");
            return strOut;
        }
        public override string ToString()
        {
            string strOut;
            if (GoalUnit == UnitType.KG)
            {
                strOut = $"In percent your goal equals: \r\n" +
                   $"Squat: {CalculateSquatGoal()} %\r\n" +
                   $"Bench: {CalculateBenchGoal()} %\r\n" +
                   $"Deadlift: {CalculateDeadliftGoal()} %";
            }
            else
            {
                strOut = $"In KG your goal equals: \r\n" +
                    $"Squat: {CalculateSquatGoal()} KG\r\n" +
                    $"Bench: {CalculateBenchGoal()} KG\r\n" +
                    $"Deadlift: {CalculateDeadliftGoal()} KG";
            }
            return strOut;
        }
    }
}
