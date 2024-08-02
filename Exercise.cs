using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic; 

namespace Assignment_7
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
            string strOut = String.Format("{0,20} {1,30}", Type, RepWeight);
            return strOut;
        }
    }
}
