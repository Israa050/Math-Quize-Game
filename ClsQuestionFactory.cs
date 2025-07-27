using Math_Game.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    abstract class ClsQuestionFactory
    {
        public static ClsBaseQuestion GenerateQuestion(enGameLevel level, enOperationType opType, enQuestionType kind)
        {
            var (operand1, operand2) = GenerateOperands(level, opType);
            char opSymbol = GetOperatorSymbol(opType);
            int correctAnswer = CalculateAnswer(operand1, operand2, opType,opSymbol);
            string questionText = $"{operand1} {opSymbol} {operand2}";

           return CreateQuestionByKind(kind, questionText, correctAnswer,level);
        }

        private static (int, int) GenerateOperands(enGameLevel level, enOperationType opType)
        {
            int min = 1, max = 10;

            switch (level)
            {
                case enGameLevel.Medium:
                    min = 11; max = 50;
                    break;
                case enGameLevel.Hard:
                    min = 50; max = 500;
                    break;
            }

            int operand1 = ClsRandom.GenerateRandomNumber(min, max);
            int operand2 = ClsRandom.GenerateRandomNumber(min, max);

            // Special handling for division to avoid division by zero or decimals
            if (opType == enOperationType.Division)
            {
                while (operand2 == 0 || operand1 % operand2 != 0)
                {
                    operand1 = ClsRandom.GenerateRandomNumber(min, max);
                    operand2 = ClsRandom.GenerateRandomNumber(min, max);
                }
            }

            return (operand1, operand2);
        }

        private static char GetOperatorSymbol(enOperationType opType)
        {
            return ClsRandom.GetOperationType(opType);
        }

        private static enOperationType GetOperationTypeFromSymbol(char opSymbol)
        {
          switch (opSymbol)
           {
               case '+':
                    return enOperationType.Addition;
                case '-':
                    return enOperationType.Subtraction;
               case '*':
                    return enOperationType.Multiplication;
               case '/':
                    return enOperationType.Division;
                default:
                    return enOperationType.Addition;
          }
        }

        private static int CalculateAnswer(int operand1, int operand2, enOperationType opType, char opSymbol)
        {
            if(opType == enOperationType.Mix)
            {
                opType = GetOperationTypeFromSymbol(opSymbol);
            }
            switch (opType)
            {
                case enOperationType.Addition:
                    return operand1 + operand2;

                case enOperationType.Subtraction:
                    return operand1 - operand2;

                case enOperationType.Multiplication:
                    return operand1 * operand2;

                case enOperationType.Division:
                    if (operand2 == 0)
                    {
                        operand2 = 1;
                    }
                    double result = (double)operand1 / operand2;
                    //return Math.Round(result, 2);
                    return operand1 / operand2; // Assumes valid input already handled

                default:
                    return 0;
            }

        }

        private static ClsBaseQuestion CreateQuestionByKind(enQuestionType questionType, string question, int correctAnswer, enGameLevel level)
        {

            switch (questionType)
            {
                case enQuestionType.MultipleChoice:
                    List<Choice> choices = ClsMultipleChoiceQuestion.GenerateChoices(correctAnswer,level: level);
                    choices[0].IsSelected = true;
                    return new ClsMultipleChoiceQuestion(question, choices,correctAnswer);

                case enQuestionType.TrueOrFalse:
                    int opt = ClsTrueOrFalseQuestion.GetChoice(correctAnswer);
                    return new ClsTrueOrFalseQuestion(question,opt,correctAnswer);

                case enQuestionType.FillinTheBlank:
                    return new ClsFillInTheGapQuestion(question,correctAnswer);

                default:
                    throw new ArgumentException("Unsupported question type");
            }
        }


        public static List<ClsBaseQuestion> GenerateQuestionsList(
           int numberOfQuestions,
           enGameLevel level,
           enOperationType opType,
           enQuestionType kind)
        {
            List<ClsBaseQuestion> questions = new List<ClsBaseQuestion>();

            for (int i = 0; i < numberOfQuestions; i++)
            {
                var question = GenerateQuestion(level, opType, kind);
                questions.Add(question);
            }

            return questions;
        }


    }
}
