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
	}
}
