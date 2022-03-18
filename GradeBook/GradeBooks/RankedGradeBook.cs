using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException(); //counts students and throws exception
            else
            {
                if (averageGrade >= 80)              //check avaragegrade and gives mark
                    return 'A';
                else if (averageGrade > 60 & averageGrade < 80)
                    return 'B';
                else if (averageGrade > 40 & averageGrade < 60)
                    return 'C';
                else if (averageGrade > 20 & averageGrade < 40)
                    return 'D';
                else
                    return 'F';
            }
        
        }


    }
}
