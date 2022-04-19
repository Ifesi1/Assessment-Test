using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    class Students:Human,Software_Academy
    {
        public static new void AttendClass(int monday, int tuesday, int wednesday, int thursday)
        {
            if (BackEndStudents is)
            {

            }
            Students.AskQuestions();
            Facilitators.AskQuestions();
            Students.AnswerQuestion();
            Students.GiveExplanation();
            Facilitators.GiveExplanation();


        }
        class BackEndStudents:Human
        {
            public string Name { get; set; }
            ICollection<BackEndStudents> Names = new List<BackEndStudents>();

        }
        class FrontEndStudents:Human
        {
            public string Name { get; set; }
            ICollection<FrontEndStudents> Names = new List<FrontEndStudents>();
        }
    }
}
