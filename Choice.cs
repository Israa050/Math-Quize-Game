using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    public class Choice
    {
        public int Value { get; set; }
        public bool IsCorrect { get; set; }

        public bool IsSelected { get; set; }

        public Choice(int value, bool isCorrect, bool isSelected)
        {
            Value = value;
            IsCorrect = isCorrect;
            IsSelected = isSelected;
        }
    }
}
