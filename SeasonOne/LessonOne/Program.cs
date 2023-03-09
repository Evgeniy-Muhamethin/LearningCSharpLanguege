using System;

namespace LessonOne
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HomeWork homeWork = new HomeWork();
			float result = homeWork.IMT(76,186);
            Console.WriteLine(result);
			Console.ReadLine();
        }
	}
}
