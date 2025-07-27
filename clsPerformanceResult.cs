using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    public class clsPerformanceResult
    {
        public double AccuracyPercentage { get; set; }
        public double CompletionRatePercentage { get; set; }
        public double FinalScorePercentage { get; set; }
        public double WeightedScorePercentage { get; set; }  // Optional
        public static clsPerformanceResult CalculateUserPerformance(int totalQuestions, int attemptedQuestions, int correctAnswers)
        {
            if (totalQuestions == 0)
                throw new ArgumentException("Total questions cannot be zero.");

            // Accuracy = correct / attempted (only if attempted > 0)
            double accuracy = attemptedQuestions > 0
                ? (double)correctAnswers / attemptedQuestions * 100
                : 0;

            // Completion Rate = attempted / total
            double completionRate = (double)attemptedQuestions / totalQuestions * 100;

            // Final Score = correct / total
            double finalScore = (double)correctAnswers / totalQuestions * 100;

            // Weighted score
            double weightedScore = (accuracy * 0.6) + (completionRate * 0.4);

            // Round to 2 decimal places
            return new clsPerformanceResult
            {
                AccuracyPercentage = Math.Round(accuracy, 2),
                CompletionRatePercentage = Math.Round(completionRate, 2),
                FinalScorePercentage = Math.Round(finalScore, 2),
                WeightedScorePercentage = Math.Round(weightedScore, 2)
            };
        }
    }


}
