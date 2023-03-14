using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonFive
{
	internal class LessonLearned
	{
		delegate void PrintMessage<T>(T[] array);//Проба написания делегата 
		//Работа с массивом символов
		//Меняем массив символов на знаки.
		public void CharArray(char[] arryChar)
		{
			int count = 0;
			while (count < arryChar.Length)
			{
				if (char.IsDigit(arryChar[count]) == true)
				{
					arryChar[count] = '/';
				}
				else
				{
					arryChar[count] = '.';
				}
				count++;
			}
			PrintArray(arryChar);
		}

		//Работа с иассивом строк и строкой
		public string[] StringArrayDevidet(string arrayString)
		{
			PrintMessage<string> mes;
			mes = PrintArray<string>;

			string[] text = arrayString.Split();
			mes(text);

			return text;
        }

		public string StringArrayPluss(string[] arrayString)
		{
			string result = String.Join("/", arrayString);
            Console.WriteLine(result);
            return result;
		}

		//Печать массива
		private void PrintArray<T>(T[] array)
		{
			foreach (T element in array)
			{
                Console.WriteLine(element);
            }
		}
	}
}