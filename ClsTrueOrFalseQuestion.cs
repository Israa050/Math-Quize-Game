using Math_Game.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    public class ClsTrueOrFalseQuestion : ClsBaseQuestion
    {
        public int option { get; set; }

        public bool isCorrect { get; set; }
        public ClsTrueOrFalseQuestion(string questionString, int optionAnswr, int correctAnswer)
        {
            question = questionString;
            option = optionAnswr;
            answer = correctAnswer;
        }

        static private int GenerateFalseAnswer(int answer)
        {
            return (answer < 0)? ClsRandom.GenerateRandomNumber(Math.Abs(answer))
              : ClsRandom.GenerateRandomNumber(answer);  
        }

        static public int GetChoice(int answer)
        {
            int opt = GenerateFalseAnswer(answer);
            List<int> choices = new List<int>();
            choices.Add(answer);
            choices.Add(opt); 
                var tt = choices[ClsRandom.GenerateRandomNumber(0, 1)];
            return tt;
        }

        public override bool CheckAnswer()
        {
            return isCorrect == (option==answer);
        }
    }
}
