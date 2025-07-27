using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    public class ClsFillInTheGapQuestion : ClsBaseQuestion
    {
        public int userInput { get; set; }


        public ClsFillInTheGapQuestion(string quizQuestion, int correctAnswer)
        {
            question = quizQuestion;
            answer = correctAnswer;
        }

        public override bool CheckAnswer()
        {
            return userInput == answer;
        }
    }
}
