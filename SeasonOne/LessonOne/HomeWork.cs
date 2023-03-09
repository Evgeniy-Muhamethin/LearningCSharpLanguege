using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

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

		public float DistancePoints()
		{
			//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
			//y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
			//используя спецификатор формата .2f(с двумя знаками после запятой);
			//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
			//метода.
			float result = 0;



			return result;
		}
	}
}
