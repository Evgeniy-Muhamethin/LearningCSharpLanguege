using System;

namespace LessonTwo
{
	enum Turn
	{
		turnOn,
		turnOff,
		turnNot,
	};

	internal class LessonLearned
	{
		public int TernarOperators(int a, int b)
		{
			int result = a > b ? 1 : -1;
			return result;
		}

		public void SwichAndCase(bool flag)
		{
			switch (flag) 
			{ 
				case true:
					int result1 = 10 + 12;
                    Console.WriteLine(result1);
					break;
				case false:
					int result2 = 56 + 10;
					Console.WriteLine(result2);
					break;
			}
		}

		public void EnumOperators(Turn turn)
		{
			switch(turn) 
			{ 
				case Turn.turnOn:
					Console.WriteLine("Flight on");
					break;
				case Turn.turnOff:
					Console.WriteLine("Flight off");
					break;
				case Turn.turnNot:
					Console.WriteLine("Flight not");
					break;
			}
		}

		int enterNumber;
		public void Cikle()
		{
			int number = 4;
			if(number > 0) 
			{
				int count = 0;
				while (enterNumber != number) 
				{
					enterNumber = int.Parse(Console.ReadLine()); 
					if (enterNumber > number)
					{
				        Console.WriteLine("Число больше загаданного числа");
				    }
					else if (enterNumber < number)
					{
				        Console.WriteLine("Число меньше загаданного числа");
				    }
					else
					{
				        Console.WriteLine("Вы угадали число");
				    }
					count++;
				}
			}
			else if(number <= 0)
			{
                Console.WriteLine("Число должно быть больше нуля, и не равное ему");
            } 
		}

		public void Loop(int a, int b)
		{
			Console.WriteLine("{0,4}", a);
			if(a < b)
				Loop(a + 1, b);
        }
	}
}
