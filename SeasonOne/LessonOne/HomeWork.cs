using System;
using System.Net.NetworkInformation;

namespace LessonOne
{
	internal class HomeWork
	{
		public void Anketa()
		{
			//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст,
			//рост, вес).В результате вся информация выводится в одну строчку:
			//	а) используя склеивание;
			//	б) используя форматированный вывод;
			//	в) используя вывод со знаком $.

			Console.WriteLine("Ваше имя: ");
			string firstName = Console.ReadLine();
			Console.WriteLine("Ваше фамилию: ");
			string lastName = Console.ReadLine();
			Console.WriteLine("Ваше возраст: ");
			byte age = byte.Parse(Console.ReadLine());
			Console.WriteLine("Ваше рост: ");
			byte height = byte.Parse(Console.ReadLine());
			Console.WriteLine("Ваше вес: ");
			byte weight = byte.Parse(Console.ReadLine());
			
			#region a
			Console.WriteLine("Имя: " + firstName + "\nФамилия: " + lastName +
				"\nВозраст: " + age + "\nРост: " + height + "\nВес: " + weight);
            #endregion

            #region b
            Console.WriteLine("\nИмя: {0} \nФамилия: {1} \nВозраст: {2} \nРост: {3} \nВес: {4}", firstName,
				lastName, age, height, weight);
            #endregion

            #region v
            Console.WriteLine($"\nИмя: {firstName} \nФамилия: {lastName} \nВозраст: {age} " +
				$"\nРост: {height} \nВес: {weight}");
            #endregion
        }

		public float IMT(float weight, float height)
		{
			//Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
			//I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
			float result = weight / (height * height);
			return result;
		}

		public float DistancePoints(float x1, float y1, float x2, float y2)
		{
			//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
			//y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
			//используя спецификатор формата .2f(с двумя знаками после запятой);
			//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
			//метода.
			float result = (float)(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

			return result;
		}

		public void TwoNumbers(int numberOne, int numberTwo)
		{
			//Написать программу обмена значениями двух переменных:
			//а) с использованием третьей переменной;
			//б) *без использования третьей переменной.

			//int numberThree = numberOne;
			//numberOne = numberTwo;
			//numberTwo = numberThree;
			//Console.WriteLine($"{numberOne}, {numberTwo}");

			numberOne = numberOne + numberTwo;
			numberTwo = numberOne - numberTwo;
			numberOne = numberOne - numberTwo;
			Console.WriteLine($"\n{numberOne}, {numberTwo}");
		}

		public void PrintName(string firstName, string lastName, string city, int x, int y, ConsoleColor foreground)
		{
			//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
			//б) *Сделать задание, только вывод организовать в центре экрана.
			//в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int
			//x, int y).

			Console.SetCursorPosition(x,y);
			Console.ForegroundColor = foreground;
            Console.WriteLine($"Имя: {firstName} Фамилия: {lastName} Город: {city}");
        }
	}
}
