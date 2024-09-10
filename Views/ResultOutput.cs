using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Assignment_7.HandleExercise;
using Assignment_7.Managers;

namespace Assignment_7
{
    public partial class ResultOutput : Form
    {
        private CalculateExercise calculateExercise;
        public ResultOutput()
        {
            InitializeComponent();
        }

        internal void InitializeCalculation(ExerciseManager exerciseManager, User user)
        {
            calculateExercise = new CalculateExercise();
            calculateExercise.CopyExerciseList(exerciseManager.exerciseList);
            calculateExercise.CalculateTotal();
            calculateExercise.CalculateAverage();
            calculateExercise.CalculateTotalTotal();
            calculateExercise.AmountOfRepetitions();
            calculateExercise.CalculateTotalAverage();
            calculateExercise.CalculateMax();
            calculateExercise.TimesLiftedBodyWeight(user);
            calculateExercise.LeftToReachGoal(user);
        }
        internal void ShowResult(ExerciseManager exerciseManager, User user)
        {
            InitializeCalculation(exerciseManager, user);

            outputSquatTotal.Text = calculateExercise.totalSquats.ToString("0.##" + " KG");
            outputBenchTotal.Text = calculateExercise.totalBenches.ToString("0.##" + " KG");
            outputDeadliftTotal.Text = calculateExercise.totalDeadlifts.ToString("0.##" + " KG");

            outputSquatAverage.Text = calculateExercise.averageSquats.ToString("0.##" + " KG");
            outputBenchAverage.Text = calculateExercise.averageBenches.ToString("0.##" + " KG");
            outputDeadliftAverage.Text = calculateExercise.averageDeadlifts.ToString("0.##" + " KG");

            outputSquatMax.Text = calculateExercise.maxSquats.ToString("0.##" + " KG");
            outputBenchMax.Text = calculateExercise.maxBenches.ToString("0.##" + " KG");
            outputDeadliftMax.Text = calculateExercise.maxDeadlifts.ToString("0.##" + " KG");

            outputSquatLeft.Text = calculateExercise.leftSquats;
            outputBenchLeft.Text = calculateExercise.leftBenches;
            outputDeadliftLeft.Text = calculateExercise.leftDeadlifts;

            outputTotalTotal.Text = calculateExercise.total.ToString("0.##" + " KG");
            outputTotalRepetitions.Text = calculateExercise.amountOfRepetitions.ToString("0.##" + " reps");
            outputTotalTimesBodyweight.Text = calculateExercise.timesLiftedBodyWeight.ToString("0.##" + " times");
            outputTotalAverage.Text = calculateExercise.totalAverage.ToString("0.##" + " KG");
        }
    }
}
