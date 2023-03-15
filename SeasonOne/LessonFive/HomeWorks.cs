using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LessonFive
{
	internal class HomeWorks
	{
		#region HomeWorkOne
		//Создать программу, которая будет проверять корректность ввода логина.Корректным логином
		//будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
		//при этом цифра не может быть первой:
		//а) без использования регулярных выражений;
		//б) **с использованием регулярных выражений.
		public void Example(string login)
		{
			string testText = login; //18
			int result = LengthLine(testText);

			bool resultCheckLineOnAlphamber = CheckLineOnAlphambers(testText);
            bool resultCheckLineOnNumber = CheckLineOnNumber(testText);
			bool flagLine = CheckLine(result);

			switch (flagLine & resultCheckLineOnNumber & resultCheckLineOnAlphamber)
			{
				case true:
                    Console.WriteLine("Логин правильный");
                    break;
				case false:
                    Console.WriteLine("Логин не правильный");
                    break;
			}

            Console.WriteLine(result);
        }

		//количество символов в строке 
		private int LengthLine(string line)
		{
			int lenthLine = 0;

			while (lenthLine < line.Length)
			{
				lenthLine++;
			}

			return lenthLine;
		}

		//проверка на количество символов 
		private bool CheckLine(int lengthLine)
		{
			bool flag = false;
			if (lengthLine < 2 | lengthLine > 10)
			{
				flag = false;
			}
			else
			{
				flag = true;
			}
			return flag;
		}

		//проверка на цифры в слове
		private bool CheckLineOnNumber(string line)
		{
			bool flagNumber = false;

			char[] charsLine = line.ToCharArray();
			for (int i = 0; i < charsLine.Length; i++)
			{
				if (Char.IsDigit(charsLine[i]) == true)
				{
					flagNumber = true;
					break;
				}
				else
				{
					flagNumber = false;
                }
			}

			return flagNumber;
		}

		//проверка на латинский алфавит
		private bool CheckLineOnAlphambers(string line)
		{
			bool flag = false;

			char[] alphamber = new char[] { 'A', 'a', 'B', 'b',
			'C', 'c', 'E', 'e', 'F', 'f', 'G', 'g', 'I', 'i',
			'J','j','K','k','H','h','M','m','N','n','O','o','Q','q',
			'R','r','S','s','U','u','V','v','W','w','Y','y',
			'Z','z','1','2','3','4','5','6','7','8','9','0'};

			char[] charsLine = line.ToCharArray();
			
			for (int i = 0; i < charsLine.Length; i++)
			{
				for (int j = 0; j < alphamber.Length; j++)
				{
					if (charsLine[i] == alphamber[j])
					{
						flag = true;
						break;
					}
					else
					{
						flag = false;
					}
				}
			}

			return flag;
		}
		#endregion

		#region HomeWorkTwo
		//Удалить из сообщения все слова, которые заканчиваются на заданный символ.
		public void Regulars()
		{
			string text = "Test world";
			Regex regex = new Regex("Test");
			bool result = regex.IsMatch(text);
			if (result == true) { Console.WriteLine(text); }
		}
		#endregion
	}
}