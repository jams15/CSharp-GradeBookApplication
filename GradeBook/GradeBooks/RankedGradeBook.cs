using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook( string name ):base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public char GetLetterGrade( double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException(" Ranked-grading requires a minimum of 5 students to work ");

            foreach( Student student in Students)
            {
                var threshold = Students.Count * 0.2;


            }
            return 'F';
        }
    }
}
