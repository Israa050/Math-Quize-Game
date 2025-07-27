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
    public partial class MathQuize : Form
    {
        public MathQuize()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitilizeDateAndTime();
        }

        private void InitilizeDateAndTime()
        {
            lbDate.Text = DateTime.Now.ToShortDateString();
            lbTime.Text = DateTime.Now.ToShortTimeString();
            rdbAdd.Checked = true;
            rdbEasy.Checked = true;
            rdbChoice.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameStatus game =  GetGameStatus();
            frmMathQuize form = new frmMathQuize(game);
            form.Show();
           //to allow to open only one form at a time
            //using (var form = new frmMathQuize(game))
            //{
            //    form.ShowDialog();  // This blocks until the form is closed
            //}
        }

        private TEnum? GetSelectedEnumValue<TEnum>(GroupBox groupBox) where TEnum : struct, Enum
        {
            RadioButton selectedRadio = groupBox.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (selectedRadio == null)
            {
                MessageBox.Show("Please select an option.");
                return null;
            }

            if (selectedRadio.Tag == null)
            {
                MessageBox.Show("Radio button does not have a Tag set.");
                return null;
            }

            if (Enum.TryParse<TEnum>(selectedRadio.Tag.ToString(), out var enumValue))
            {
                return enumValue;
            }

            MessageBox.Show("Invalid value selected for " + typeof(TEnum).Name);
            return null;
        }

        public GameStatus GetGameStatus()
        {
            var level = GetSelectedEnumValue<enGameLevel>(gbLevel);
            var questionType = GetSelectedEnumValue<enQuestionType>(gbQuestionType);
            var operation = GetSelectedEnumValue<enOperationType>(gbOperation);
            int numberOfQuestions = (int)numericUpDown1.Value;
            int timer = (int)numericUpDown2.Value;

            return new GameStatus(
                  level ?? enGameLevel.Easy,
                  numberOfQuestions,
                  questionType ?? enQuestionType.TrueOrFalse,
                  operation ?? enOperationType.Mix,
                  timer
                 );
        }

    }
}
