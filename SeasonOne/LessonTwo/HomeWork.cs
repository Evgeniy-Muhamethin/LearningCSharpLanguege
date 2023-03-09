using System;

namespace LessonTwo
{
	internal class HomeWork
	{
		public void HomeWorkOne(int a, int b, int c)
		{
			//Написать метод, возвращающий минимальное из трёх чисел.
			if(a < b & a < c) Console.WriteLine(a);
			else if(b < a & b < c) Console.WriteLine(b);
			else if(c < a & c < b) Console.WriteLine(c);
        }

		public void HomeWorkTwo(int a)
		{
			//Написать метод подсчета количества цифр числа.
			int count = 0;
			while(a != 0)
			{
				a /= 10;
				count++;
            }
            Console.WriteLine(count);
		}
	}
}
