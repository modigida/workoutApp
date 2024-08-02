using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class FileManager
    {
        private const string fileVersionToken = "ToDoRe_21";
        private const double fileVersionNr = 1.0;

        public bool ReadExerciseListFromFile(List<Exercise> exerciseList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                if (exerciseList != null)
                {
                    exerciseList.Clear();
                }
                else
                {
                    exerciseList = new List<Exercise>();
                }
                reader = new StreamReader(fileName);

                string versionTest = reader.ReadLine();
                double version = double.Parse(reader.ReadLine());

                if ((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Exercise exercise = new Exercise();

                        exercise.RepWeight = double.Parse(reader.ReadLine());
                        exercise.Type = (ExerciseType)Enum.Parse(typeof(ExerciseType), reader.ReadLine());

                        exerciseList.Add(exercise);
                    }
                }
                else
                {
                    ok = false;
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return ok;
        }
        public bool SaveExerciseListToFile(List<Exercise> exerciseList, string fileName)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(exerciseList.Count);

                for (int i = 0; i < exerciseList.Count; i++)
                {
                    writer.WriteLine(exerciseList[i].Type);
                    writer.WriteLine(exerciseList[i].RepWeight);
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
    }
}
