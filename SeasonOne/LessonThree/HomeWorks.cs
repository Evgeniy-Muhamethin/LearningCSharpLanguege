using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonThree
{
	internal class HomeWorks
	{
		public void HomeJob(string text)
		{
			int enterNumber;
			int summ = 0;
			switch (text)
			{
				case "programm":
					Console.WriteLine("Please enter number");
					enterNumber = int.Parse(Console.ReadLine());
					if (enterNumber % 2 == 0 & enterNumber > 0)
					{
						summ = summ + enterNumber;
                        Console.WriteLine(summ.ToString());
                    }
					break;
				case "exit":
                    Console.WriteLine("EXIT");
                    break;
			}
		}
	}
}
