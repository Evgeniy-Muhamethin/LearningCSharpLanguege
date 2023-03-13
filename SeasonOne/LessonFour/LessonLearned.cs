using System;
using System.Runtime.InteropServices;

namespace LessonFour
{
	internal class LessonLearned
	{
		//TODO работа с текстовыми файлами 
		//TODO домашняя работа 

		//Метод копирования массива
		public void FirstMethod(int[] arrayFirst, int[] arrayLast, 
			int countArray, int indexCopy)
		{
			arrayFirst = new int[countArray];
			arrayLast = new int[countArray];

			arrayFirst.CopyTo(arrayLast, indexCopy);
		}

		//Метод заполнения массива
		public void RandomArrayLenth(int[] array)
		{
			Random random = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(1,10);
			}
            Console.WriteLine("Random method is DONE");
        }

		//Метод вывода на консоль элементов массива
		public void PrintArray<T>(T[] array)
		{
			foreach (T element in array)
			{
                Console.WriteLine($"{element}");
            }
		}

		//Массив как объект 
		public void ArryHowObject<T>(T[] arryObject)
		{
			PrintArray<T>(arryObject);
            Console.WriteLine("PEnciles is done");
        }
		
		public void ArryHowObjectPencil(int indexArray)
		{
			Pencil[] pencils = new Pencil[indexArray];

			for (int i = 0; i < pencils.Length; i++)
			{
				if (indexArray > 4)
				{
					pencils[3] = new Pencil();
					pencils[3].ButtonLeft();
                    Console.WriteLine("It is arry 3");
                }
			}
		}
	}
}
