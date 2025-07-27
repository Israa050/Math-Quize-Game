using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_Game.helper;

namespace Math_Game
{
    public class ClsMultipleChoiceQuestion :  ClsBaseQuestion
    {

        public Choice userOption { get; set; }

        public List<Choice> options { get; set; }

        public ClsMultipleChoiceQuestion(string qs, List<Choice> choices, int correctAnswer)
        {
            question = qs;
            options = choices;
            answer = correctAnswer;
        }

        public static Choice GenerateSingleChoice(int correctAnswer, int rangeMin = -100, int rangeMax = 100)
        {
            int candidate;
            do
            {
                candidate = ClsRandom.GenerateRandomNumber(rangeMin, rangeMax + 1);
            } while (candidate == correctAnswer);

            return new Choice(candidate, false, false); // always false here
        }

        private static void GetMaxAndMinValues(int correctAnswer,enGameLevel level,ref int max, ref int min)
        {
            switch (level)
            {
                case enGameLevel.Easy:
                    min = correctAnswer++;
                    max = min + 5;
                    break;
                case enGameLevel.Medium:
                    min = correctAnswer++;
                    max = min + 10;
                    break;
                case enGameLevel.Hard:
                    min = correctAnswer++;
                    max = min + 20;
                    break;
            }
        }

        public static List<Choice> GenerateChoices(int correctAnswer, enGameLevel level, int rangeMin = -100, int rangeMax = 100)
        {
            GetMaxAndMinValues(correctAnswer,level,ref rangeMax, ref rangeMin);
            HashSet<int> usedValues = new HashSet<int> { correctAnswer };
            List<Choice> choices = new List<Choice>();

            // Add the correct choice
            choices.Add(new Choice(correctAnswer, true, false));

            // Add 3 unique wrong choices
            while (choices.Count < 4)
            {
                Choice wrongChoice = GenerateSingleChoice(correctAnswer, rangeMin, rangeMax);
                if (usedValues.Add(wrongChoice.Value)) // only add if it's unique
                {
                    choices.Add(wrongChoice);
                }
            }

            // Optional: Shuffle the list to randomize order
            return ShuffleChoices(choices);
        }

        private static List<Choice> ShuffleChoices(List<Choice> choices)
        {
            Random rng = new Random();
            return choices.OrderBy(_ => rng.Next()).ToList();
        }

        public void GetUserOption(Choice option)
        {
            userOption = option;
        }

        public override bool CheckAnswer()
        {
            return userOption.IsCorrect;
        }

    }
}
