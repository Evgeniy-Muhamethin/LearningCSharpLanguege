using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
	internal class LessonIsLearned
	{
        public void StopProgramm()
        {
            Console.ReadLine();
        }

        public void WorkWithMessages(string managerSymbol)
        {
            string symbol = managerSymbol;
            Console.WriteLine($"It is my message, about how{managerSymbol} i am learned programming languege");
            StopProgramm();
        }

        public int ComparisonTypes(float typeComparison)
        {
            int result = (int)typeComparison;
            return result;
        }

        public void BooleanMethod(bool trueOrFalse)
        {
            switch (trueOrFalse)
            {
                case true:
                    Console.WriteLine($"It is {trueOrFalse.ToString()}");
                    break;
                case false:
                    Console.WriteLine($"It is {trueOrFalse.ToString()}");
                    break;
            }
            Console.ReadLine();
        }

        public void FirstMethod()
        {
            string message = "My message";

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine($"{message[i]}\n");
            }

            Console.ReadLine();
        }
    }
}
