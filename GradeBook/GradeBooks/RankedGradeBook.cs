﻿using System;
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
                var threshold = (int)Math.Ceiling( Students.Count * 0.2 );
                var grades = Students.OrderbyDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToLis();
                if (averageGrade > grades[threshold - 1])
                    return 'A';
                else if (averageGrade > grades[2 * threshold - 1])
                    return 'B';
                else if (averageGrade > grades[3 * threshold - 1])
                    return 'C';
                else if (averageGrade > grades[4 * threshold - 1])
                    return 'D';

                else return 'F';

            }
            return 'F';
        }
    }
}
