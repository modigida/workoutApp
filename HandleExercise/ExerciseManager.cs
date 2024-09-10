using Assignment_7.Files;
using Assignment_7.Managers;

namespace Assignment_7.HandleExercise
{
    internal class ExerciseManager
    {
        public List<Exercise> exerciseList;

        public ExerciseManager()
        {
            exerciseList = new List<Exercise>();
        }
        public Exercise GetExerciseAt(int index)
        {
            if (CheckIndex(index))
            {
                return exerciseList[index];
            }
            else
            {
                return null;
            }
        }
        public string[] GetInfoStringsList()
        {
            string[] infoString = new string[exerciseList.Count];

            for (int i = 0; i < infoString.Length; i++)
            {
                infoString[i] = exerciseList[i].ToString();
            }
            return infoString;
        }
        private bool CheckIndex(int index)
        {
            return index >= 0 && index < exerciseList.Count;
        }
        public bool AddExercise(Exercise ExerciseIn)
        {
            bool ok = true;
            if (ExerciseIn != null)
            {
                exerciseList.Add(ExerciseIn);
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        public bool ChangeExerciseAt(Exercise ExerciseIn, int index)
        {
            bool ok = true;
            if (ExerciseIn != null && CheckIndex(index))
            {
                exerciseList[index] = ExerciseIn;
            }
            else
            {
                ok = false;
            }
            return ok;
        }
        public bool DeleteExerciseAt(int index)
        {
            bool ok = false;
            if (index >= 0 && index < exerciseList.Count)
            {
                exerciseList.RemoveAt(index);
                ok = true;
            }
            return ok;
        }

        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            return fileManager.ReadExerciseListFromFile(exerciseList, fileName);
        }
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            return fileManager.SaveExerciseListToFile(exerciseList, fileName);
        }
    }
}
