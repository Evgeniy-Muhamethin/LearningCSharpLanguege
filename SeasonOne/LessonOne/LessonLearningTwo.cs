using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
	internal class LessonLearningTwo
	{
		public double PlussTwoNumbers(int numberOne, int numberTwo)
		{
			double result = 0;

			result = (double)numberOne + (double)numberTwo;

			return result;
		}

		public double PlussTwoNumbers(int numberOne, int numberTwo, string message)
		{
			double result = 0;

			result = (double)numberOne * (double)numberTwo;
            Console.Write(message);

            return result;
		}

		public void MethotConsoleWork()
		{
			Console.Write("\"Не переходит на другую строку\"");
			Console.Write("\nПереходит на другую строку\r");
			Console.Write(" \'Каретка перенесена\t ");
		}

		public void MethotFormatirovaniyData(double data)
		{
			Console.Write("{0:E7}\n", data);
			Console.Write("{0:P1}", data);
		}
	}
}
