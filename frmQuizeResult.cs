using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class frmQuizeResult : Form
    {

        private GameStatus _game;
        public frmQuizeResult(GameStatus myGame)
        {
            InitializeComponent();
            _game = myGame;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDefaultTimerLabel()
        {
            int minutes = (int)_game.Timer;
            lblTimer.Text = $"{minutes:D2}:00";  // Format as mm:00 (e.g., 04:00)
        }
        private void frmQuizeResult_Load(object sender, EventArgs e)
        {
            InitializeSummaryLabels();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeSummaryLabels()
        {
            lblLevel.Text = _game.QuestionsLevel.ToString();
            lblQuestionsNumber.Text = _game.NumberOfQuestions.ToString();
            lblOperationType.Text = _game.OperationType.ToString();
            lblQuestionType.Text = _game.QuestionType.ToString();
            lblResult.Text = _game.Result.ToString();

            lblFinalScore.Text = _game.PerformanceResult.FinalScorePercentage.ToString() + "%";
            lblAccuracy.Text = _game.PerformanceResult.AccuracyPercentage.ToString() + "%";
            lblCompletion.Text = _game.PerformanceResult.CompletionRatePercentage.ToString() + "%";

            UpdateDefaultTimerLabel();
            SetupBackgroundColor();
        }

        private void SetupBackgroundColor()
        {
            switch (_game.Result)
            {
                case enGameResult.InProgress:
                    this.BackColor = SystemColors.ActiveCaption;
                    break;
                case enGameResult.Pass:
                    this.BackColor = Color.Green;
                    break;
                case enGameResult.Fail:
                    this.BackColor = Color.Red;
                    break;
            }
        }


    }
}
