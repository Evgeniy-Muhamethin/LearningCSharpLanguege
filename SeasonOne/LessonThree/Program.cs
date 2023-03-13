using System;
using MyLibrary;

namespace LessonThree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LessonLearned lessonLearned = new LessonLearned();
			LibraryClass libraryClass = new LibraryClass();
			HomeWorks homeWorks = new HomeWorks();

			#region Работа со Структурами
			//byte numberPluss = 3;

			//StructClass structClassCoordinat = new StructClass();
			//structClassCoordinat.X = int.Parse(Console.ReadLine());
			//structClassCoordinat.Y = int.Parse(Console.ReadLine());

			//StructClass structClassResult = new StructClass();
			//structClassResult = lessonLearned.StructMethod(ref structClassCoordinat,
			//	ref numberPluss);

			//lessonLearned.PrintResult(structClassResult.X, structClassResult.Y);
			#endregion

			#region Работа со внутренними структурами 
			//DateTime dateTime1 = DateTime.Now;
			//string years = $"{dateTime1.Year}";
			//Console.WriteLine(years);
			//lessonLearned.ThreadingStruct();
			//Console.WriteLine(dateTime1.DayOfWeek);
			#endregion

			string text;
			for (; ; )
			{
				text = Console.ReadLine();
				homeWorks.HomeJob(text);
			}

			libraryClass.Pause();
        }
	}
}
