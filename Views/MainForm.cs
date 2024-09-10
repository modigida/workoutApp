using Assignment_7.Enums;
using Assignment_7.Files;
using Assignment_7.HandleExercise;
using Assignment_7.Managers;

namespace Assignment_7
{
    public partial class MainForm : Form
    {
        User user = new User();
        ExerciseManager exerciseManager = new ExerciseManager();

        string fileName = Application.StartupPath + "\\Task.txt";
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            exerciseManager = new ExerciseManager();

            listBox1.Items.Clear();
            groupBoxWorkout.Enabled = false;
            buttonStartWorkout.Enabled = false;
            ClearInputControls();

            comboBoxUnit.Items.AddRange(Enum.GetNames(typeof(UnitType)));
            comboBoxUnit.SelectedIndex = (int)UnitType.KG;

            comboBoxExercise.Items.AddRange(Enum.GetNames(typeof(ExerciseType)));
            comboBoxExercise.SelectedIndex = (int)ExerciseType.Squat;
        }
        private void ClearInputControls()
        {
            textBoxUsername.Text = string.Empty;
            textBoxBodyWeight.Text = string.Empty;
            textBoxSquatGoal.Text = string.Empty;
            textBoxBenchGoal.Text = string.Empty;
            textBoxDeadliftGoal.Text = string.Empty;
        }
        private void UpdateGUI()
        {
            listBox1.Items.Clear();
            string[] infoString = exerciseManager.GetInfoStringsList();
            if (infoString != null)
            {
                listBox1.Items.AddRange(infoString);
            }
        }

        private void buttonFinishWorkout_Click_1(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Sure to finish workout?",
                " ", MessageBoxButtons.OKCancel);

            if (dlgResult == DialogResult.OK)
            {

                ResultOutput resultOutput = new ResultOutput();

                resultOutput.ShowResult(exerciseManager, user);
                resultOutput.Show();
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            buttonStartWorkout.Enabled = true;
            User user = ReadUserData();
            MessageBox.Show(user.ToString());
            groupBoxUser.Enabled = false;
        }
        #region READ USER DATA
        private User ReadUserData()
        {
            user.Username = textBoxUsername.Text;
            user.GoalUnit = (UnitType)comboBoxUnit.SelectedIndex;
            double bodyWeight;
            if (double.TryParse(textBoxBodyWeight.Text, out bodyWeight))
            {
                user.BodyWeight = bodyWeight;
            }
            double squatGoal;
            if (double.TryParse(textBoxSquatGoal.Text, out squatGoal))
            {
                user.GoalSquat = squatGoal;
            }
            double benchGoal;
            if (double.TryParse(textBoxBenchGoal.Text, out benchGoal))
            {
                user.GoalBench = benchGoal;
            }
            double deadliftGoal;
            if (double.TryParse(textBoxDeadliftGoal.Text, out deadliftGoal))
            {
                user.GoalDeadlift = deadliftGoal;
            }

            return user;
        }
        #endregion
        private void buttonStartWorkout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Workout started {DateTime.Now.Format()}");
            groupBoxWorkout.Enabled = true;
        }
        private Exercise ReadRepInfo()
        {
            Exercise exercise = new Exercise();
            exercise.Type = (ExerciseType)comboBoxExercise.SelectedIndex;
            double repWeight;
            bool ok = double.TryParse(textBoxWeight.Text, out repWeight);
            if (!ok)
            {
                MessageBox.Show("Give weight for the repetition.");
            }
            exercise.RepWeight = repWeight;
            return exercise;
        }
        private void ReadExerciseData(ref Exercise exercise)
        {
            exercise.Type = (ExerciseType)comboBoxExercise.SelectedIndex;
            double repWeight;
            bool ok = double.TryParse(textBoxWeight.Text, out repWeight);
            if (!ok)
            {
                MessageBox.Show("Give weight for the repetition.");
            }
            exercise.RepWeight = repWeight;
        }

        private void buttonAddRep_Click(object sender, EventArgs e)
        {
            Exercise exercise = ReadRepInfo();
            if (exerciseManager.AddExercise(exercise))
            {
                UpdateGUI();
            }
        }
        #region Handle repetitions

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                Exercise exercise = exerciseManager.GetExerciseAt(index);
                comboBoxExercise.SelectedIndex = (int)exercise.Type;
                double repWeight;
                bool ok = double.TryParse(textBoxWeight.Text, out repWeight);
                if (!ok)
                {
                    MessageBox.Show("Give weight for the repetition.");
                }
                repWeight = exercise.RepWeight;
            }
            else
            {
                MessageBox.Show("Select an item.");
            }
        }
        private void buttonChangeRep_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0)
            {
                return;
            }
           
            Exercise exercise = exerciseManager.GetExerciseAt(index);

            ReadExerciseData(ref exercise);

            exerciseManager.ChangeExerciseAt(exercise, index);
            UpdateGUI();
        }

        private void buttonDeleteRep_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            exerciseManager.exerciseList.RemoveAt(index);
            UpdateGUI();
        }
        #endregion
        #region Handle Menu
        private void newWorkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Don´t forget to save your exercise!\r\n" +
                "Otherwise your data will get lost.",
                " ", MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.OK)
            {
                InitializeGUI();
            }
        }

        private void saveWorkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = exerciseManager.WriteDataToFile(fileName);
            if (!ok)
            {
                MessageBox.Show(errMessage);
            }
            else
            {
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileName);
            }
        }

        private void openWorkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           string errMessage = "Something went wrong while opening data to file";
            bool ok = exerciseManager.ReadDataFromFile(fileName);
            if (!ok)
            {
                MessageBox.Show(errMessage);
            }
            else
            {
                UpdateGUI();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Sure to exit program?",
                "Think twice.", MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}