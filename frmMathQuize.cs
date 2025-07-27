using System;
using System.Windows.Forms;
using System.Media;

namespace Math_Game
{
    public partial class frmMathQuize : Form
    {
        private int remainingSeconds;
        private int currentQuestionIndex = 0;
        private int questionLabel = 1;

        private readonly GameStatus game;

        public frmMathQuize(GameStatus gameStatus)
        {
            game = gameStatus ?? throw new ArgumentNullException(nameof(gameStatus));
            InitializeComponent();
        }

        private void frmMathQuize_Load(object sender, EventArgs e)
        {
            SetInitialLabels();
            btnCheck.Enabled = false;

            game.Start();
            DisplayCurrentQuestion();
            UpdateTimerLabelFull();
        }

        private void EndGameWithDialog()
        {
            timer2.Stop();           // Stop the countdown timer if active
            btnCheck.Enabled = false;

            game.CheckFinalResult();

            SystemSounds.Asterisk.Play();

            string message = "✅ Great job! 🎉\n\nYou’ve completed all the questions.\nClick OK to view your final results 📊.";
            string title = "🎮 Game Finished";


            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                FinishTheGame();
            }
        }
        private void SetInitialLabels()
        {
            lbDate.Text = DateTime.Now.ToShortDateString();
            lbTime.Text = DateTime.Now.ToShortTimeString();
            lblQuestionN.Text = game.NumberOfQuestions.ToString();
            lblQuizeLevel.Text = game.QuestionsLevel.ToString();
            lblOperationType.Text = game.OperationType.ToString();
            lblQuestionsType.Text = game.QuestionType.ToString();
            lblGameResult.Text = game.Result.ToString();
            lblPrecentage.Text = $"{game.Percentage}%";
        }

        private void UpdateTimerLabelFull()
        {
            lblCounter.Text = $"{game.Timer:D2}:00"; // Format as mm:00
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void UpdateTimerLabel()
        {
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;
            lblCounter.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            remainingSeconds = game.Timer * 60;
            UpdateTimerLabel();
            timer2.Start();

            btnStartGame.Enabled = false;
            btnCheck.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                UpdateTimerLabel();
                return;
            }

            timer2.Stop();

            if (MessageBox.Show("Time's up!", "Info", MessageBoxButtons.OK) == DialogResult.OK)
            {
                game.CheckFinalResult();
                FinishTheGame();
                btnCheck.Enabled = false;
            }

            btnStartGame.Enabled = true;
        }

        private void FinishTheGame()
        {
            var resultForm = new frmQuizeResult(game);
            Close();
            resultForm.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            remainingSeconds = 0;
            UpdateTimerLabel();

            btnStartGame.Enabled = true;
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (IsGameEnded())
            {
                if (MessageBox.Show("The Game Finished!", "Info", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    game.CheckFinalResult();
                    FinishTheGame();
                }
                return;
            }

            var question = game.Questions[currentQuestionIndex];
            bool isCorrect = question.CheckAnswer();

            game.SubmitAnswer(isCorrect);
            game.CalculatePercentage();

            lblPrecentage.Text = $"{game.PerformanceResult.FinalScorePercentage}%";

            //MessageBox.Show(isCorrect ? "Correct Answer" : "Wrong Answer", "Info", MessageBoxButtons.OK);

            ShowAnswerFeedback(isCorrect, game.Questions[currentQuestionIndex].question, game.Questions[currentQuestionIndex].answer.ToString());


            currentQuestionIndex++;
            questionLabel++;
            if (IsGameEnded())
            {
                EndGameWithDialog();
            }
            else
            {
                DisplayCurrentQuestion();
            }
        }

        private void ShowAnswerFeedback(bool isCorrect, string questionText, string correctAnswer)
        {
            string title = isCorrect ? "Correct Answer" : "Wrong Answer";
            string message = $"{questionText}\nCorrect Answer: {correctAnswer}";
            MessageBoxIcon icon = isCorrect ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex >= game.Questions.Count)
                return;

            var question = game.Questions[currentQuestionIndex];
            switch (question)
            {
                case ClsMultipleChoiceQuestion mcq:
                    DisplayMultipleChoiceQuestion(mcq);
                    break;
                case ClsTrueOrFalseQuestion tof:
                    DisplayTrueOrFalseQuestion(tof);
                    break;
                case ClsFillInTheGapQuestion fill:
                    DisplayFillInTheGapQuestion(fill);
                    break;
            }
        }

        private void DisplayTrueOrFalseQuestion(ClsTrueOrFalseQuestion question)
        {
            lblQuestion.Text = $"Q{questionLabel}: {question.question} = {question.option}";
            rdbOption1.Text = "True";
            rdbOption3.Text = "False";

            rdbOption1.Checked = false;
            rdbOption3.Checked = false;

            rdbOption2.Hide();
            rdbOption4.Hide();
            txtUserInput.Hide();

            ShowTrueFalseOptions(true);
        }

        private void DisplayMultipleChoiceQuestion(ClsMultipleChoiceQuestion question)
        {
            lblQuestion.Text = $"Q{questionLabel}: {question.question} = ";

            var options = question.options;
            rdbOption1.Text = options[0].Value.ToString();
            rdbOption2.Text = options[1].Value.ToString();
            rdbOption3.Text = options[2].Value.ToString();
            rdbOption4.Text = options[3].Value.ToString();

            rdbOption1.Checked = false;
            rdbOption2.Checked = false;
            rdbOption3.Checked = false;
            rdbOption4.Checked = false;

            rdbOption1.Show();
            rdbOption2.Show();
            rdbOption3.Show();
            rdbOption4.Show();
            txtUserInput.Hide();
        }

        private void DisplayFillInTheGapQuestion(ClsFillInTheGapQuestion question)
        {
            lblQuestion.Text = $"Q{questionLabel}: {question.question} = ";

            txtUserInput.Text = "";

            rdbOption1.Hide();
            rdbOption2.Hide();
            rdbOption3.Hide();
            rdbOption4.Hide();

            txtUserInput.Show();
        }

        private void ShowTrueFalseOptions(bool show)
        {
            rdbOption1.Visible = show;
            rdbOption3.Visible = show;
        }

        private void rdbOption_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
                OnRadioButtonCheckedChanged(radioButton);
        }

        private void OnRadioButtonCheckedChanged(RadioButton radioButton)
        {
            if (IsGameEnded()) return;

            var question = game.Questions[currentQuestionIndex];

            switch (question)
            {
                case ClsMultipleChoiceQuestion mcq:
                    if (int.TryParse(radioButton.Text, out int value))
                    {
                        var choice = new Choice(value, false, radioButton.Checked);
                        mcq.userOption = choice;
                        mcq.userOption.IsCorrect = (choice.Value == mcq.answer);
                        Console.WriteLine($"Selected MCQ value: {choice.Value}");
                    }
                    break;

                case ClsTrueOrFalseQuestion tof:
                    if (bool.TryParse(radioButton.Text, out bool boolValue))
                    {
                        tof.isCorrect = boolValue;
                        Console.WriteLine($"Selected True/False value: {tof.isCorrect}");
                    }
                    break;
            }
        }

        private bool IsGameEnded() => currentQuestionIndex >= game.NumberOfQuestions;

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserInput.Text) || IsGameEnded())
                return;

            if (game.Questions[currentQuestionIndex] is ClsFillInTheGapQuestion fill)
            {
                if (int.TryParse(txtUserInput.Text, out int userInput))
                {
                    fill.userInput = userInput;
                    Console.WriteLine($"Fill-in input value: {userInput}");
                }
            }
        }
    }
}

