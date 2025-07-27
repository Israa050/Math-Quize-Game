using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game.helper
{
    static public class ClsRandom
    {
        static Random ran = new Random();

        static public int GenerateRandomNumber(int From, int To = 0)
        {
            return To == 0 ? ran.Next(From) : ran.Next(From, ++To);
        }

        static public char GetOperationType(enOperationType operationType)
        {
            char operation = ' ';
            switch (operationType)
            {
                case enOperationType.Addition:
                    operation = '+';
                    break;
                case enOperationType.Subtraction:
                    operation = '-';
                    break;
                case enOperationType.Multiplication:
                    operation = '*';
                    break;
                case enOperationType.Division:
                    operation = '/';
                    break;
                case enOperationType.Mix:
                    operation = GetRandomOperator();
                    break;
            }
            return operation;
        }
        private static char GetRandomOperator()
        {
            char[] ops = { '+', '-', '*', '/' };
            return ops[ran.Next(ops.Length)];
        }
    }
}
