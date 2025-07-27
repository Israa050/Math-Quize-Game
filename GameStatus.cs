using System;
using System.Collections.Generic;

namespace Math_Game
{
    public enum enGameLevel { Easy, Medium, Hard };

    public enum enGameResult { InProgress, Pass, Fail };

    public enum enQuestionType { MultipleChoice, TrueOrFalse, FillinTheBlank };

    public enum enOperationType { Addition, Subtraction, Multiplication, Division, Mix };

    public class GameStatus
    {
        // Properties
        public int NumberOfQuestions { get; private set; }
        public List<ClsBaseQuestion> Questions { get; private set; }
        public int IncorrectAnswers => NumberOfQuestions - correctAnswers;
        public int Timer { get; set; }
        public enGameLevel QuestionsLevel { get; private set; }
        public enQuestionType QuestionType { get; private set; }
        public enOperationType OperationType { get; private set; }
        public enGameResult Result { get; private set; }
        public double Percentage => PerformanceResult?.FinalScorePercentage ?? 0.0;
        public clsPerformanceResult PerformanceResult { get; private set; }

        // Private fields for tracking progress
        private int correctAnswers;
        private int answeredQuestions;

        public GameStatus(enGameLevel level, int questions, enQuestionType type, enOperationType operation, int timerCounter)
        {
            QuestionsLevel = level;
            NumberOfQuestions = questions;
            QuestionType = type;
            OperationType = operation;
            Timer = timerCounter;

            Result = enGameResult.InProgress;
            answeredQuestions = 0;
            correctAnswers = 0;

            Console.WriteLine("Game Level: {0}, Questions: {1}", QuestionsLevel, NumberOfQuestions);
        }

        // Expose read-only correct answers count
        public int GetCorrectAnswers() => correctAnswers;

        // Expose total questions count
        public int GetTotalQuestions() => NumberOfQuestions;

        // Submit answer updates counters
        public void SubmitAnswer(bool isCorrect)
        {
            answeredQuestions++;

            if (isCorrect)
                correctAnswers++;
        }

        // Calculates performance using external class
        public void CalculatePercentage()
        {
            PerformanceResult = clsPerformanceResult.CalculateUserPerformance(NumberOfQuestions, answeredQuestions, correctAnswers);
        }

        // Sets final result based on performance
        public void CheckFinalResult()
        {
            Result = (PerformanceResult != null && PerformanceResult.FinalScorePercentage >= 50)
                ? enGameResult.Pass
                : enGameResult.Fail;
        }

        // Starts the game by generating questions
        public void Start()
        {
            Questions = ClsQuestionFactory.GenerateQuestionsList(NumberOfQuestions, QuestionsLevel, OperationType, QuestionType);
        }
    }
}
