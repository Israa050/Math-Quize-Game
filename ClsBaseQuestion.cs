using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    public abstract class ClsBaseQuestion
    {
        public string question { get; set; }

        public int answer { get; set; }

        public abstract bool CheckAnswer();

    }
}
