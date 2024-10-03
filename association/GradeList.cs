using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class GradeList
    {
        private int Size;
        private List<Grade> grades = new List<Grade> ();

        public GradeList(int maxNumberOfGrades)
        {

        }
        public int GetSize()
        {
            //man SKAL returnere noget når man har en variabel som int.
            return 1;
        }
        public Grade getGrade(int index)
            {
                return grades[index];
            }
        public void addGrade(Grade grade)
        {
             grades.Add(grade);
        }
        public List<Grade> getAllGrades()
        {   
            return grades;
        }
        public double getAverage()
        {
            //fuck this poop
            double average = Grade.Average();
            return grades;
        }

    }


}
