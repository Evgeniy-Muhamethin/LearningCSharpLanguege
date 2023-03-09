using System;
using MyLibrary;

namespace LessonOne
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HomeWork homeWork = new HomeWork();
			LessonIsLearned lessonIsLearned = new LessonIsLearned();
			LibraryClass libraryClass = new LibraryClass();

			homeWork.PrintName("Jill", "Valentine", 
				"Racoon city", 35, 15, ConsoleColor.Green);

			libraryClass.Pause();
        }
	}
}
