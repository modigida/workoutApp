using Assignment_7.Enums;

namespace Assignment_7.Managers
{
    internal class Exercise
    {
        private double repWeight;
        private ExerciseType type;
        public Exercise()
        {

        }
        public Exercise(ExerciseType type, double repWeight)
        {
            this.type = type;
            this.repWeight = repWeight;
        }
        public double RepWeight
        {
            get { return repWeight; }
            set { repWeight = value; }
        }
        public ExerciseType Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            string strOut = string.Format("{0,20} {1,30}", Type, RepWeight);
            return strOut;
        }
    }
}
