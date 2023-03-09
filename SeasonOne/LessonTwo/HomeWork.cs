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

		public void HomeWorkThree()
		{
			//С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных
			//положительных чисел.
			int summNumbers = 0;
			int enterNumber = int.Parse(Console.ReadLine());
			int count = 0;
			while(enterNumber != 0) 
			{
				enterNumber = int.Parse(Console.ReadLine());
				if (enterNumber % 2 == 0)
				{
                    Console.WriteLine("Number is pluss");
                }
				else
				{
					summNumbers += enterNumber;
				}
				count++;
			}
            Console.WriteLine($"Summ numbers = {summNumbers}");
        }

		private bool HomeWorkFour(string login, string password)
		{
			//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.На
			//выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password:
			//GeekBrains). 
			string loginIns = "root";
			string passwordIns = "GeekBrains";
			bool flag;

			if (login == loginIns & password == passwordIns)
			{
				flag = true;
			}
			else
			{
				flag = false;
			}

			return flag;
		}

		public void HomeWorkFourAdd(string login, string password)
		{
			//Используя метод проверки логина и пароля, написать программу: пользователь
			//вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
			//цикла do while ограничить ввод пароля тремя попытками.
			bool result = HomeWorkFour(login, password);
			if (result == true)
			{
			    Console.WriteLine("You are entered in PC");
			}
			else
			{
			    Console.WriteLine("Login or password is failed");
			}
			
        }

		int resultNumbers;
		public void HomeWorkSix()
		{
			for (; ; )
			{
				//сумма чисел числа 
				Console.Write("n = ");
				int n = int.Parse(Console.ReadLine());
				int copyNumber = n;
				int sum = 0;
				while (n > 0)
				{
					sum += n % 10;
					n /= 10;
				}
				Console.WriteLine(sum);

				//проверка числа на качество
				if (copyNumber % sum == 0)
				{
					resultNumbers = resultNumbers + copyNumber;
				}
				Console.WriteLine(resultNumbers);
			}
        }
	}
}
