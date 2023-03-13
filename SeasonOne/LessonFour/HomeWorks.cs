using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFour
{
	internal class HomeWorks
	{
		#region HomeWork
		//Заполняем массив случайными числами
		public void HomeWorkOne(int[] arrayNumbers)
		{
			Random rnd = new Random();
			for (int i = 0; i < arrayNumbers.Length; i++)
			{
				arrayNumbers[i] = rnd.Next(-10000, 10000);
			}
		}

		//Перебераем массив и делим его на 3 
		public void Search(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] % 3 == 0)
				{
					Console.WriteLine(array[i]); //Выводим правильные числа
                }
				else
				{
					Console.WriteLine($"{array[i]} - Number is not divided on 3");
                }
			}
		}

		//TODO Изменить метод "Чтение файла пока не кончится поток"
		//Метод для получения данных из файла и записи данных в массив чисел
		//HomeWorkTwo
		public int[] ReadFile(string pathFile)
		{
			StreamReader sr = new StreamReader(pathFile);
			int number = int.Parse(sr.ReadLine());

			int[] result = new int[number];

			for (int i = 0; i < number; i++)
			{
				int numberResult = int.Parse(sr.ReadLine());
				result[i] = numberResult;
				Console.WriteLine(result[i]);
			}
			sr.Close();
			return result;
		}
		#endregion

		//Вывести массив на экран 
		private void PrintArray<T>(T[] array)
		{
			foreach (T element in array)
			{
                Console.WriteLine($"\'{element}\'");
            }
		}
	}
}
