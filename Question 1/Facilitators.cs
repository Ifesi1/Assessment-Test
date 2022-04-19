using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    class Facilitators:Human,BackEnd,FrontEnd
    {
        public static void AttendClass()
        {
            Students.AskQuestions();
            Facilitators.AnswerQuestion();
            Facilitators.GiveExplanation();
            Students.GiveExplanation();
        }
    }
}
