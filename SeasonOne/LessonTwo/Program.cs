using System;
using MyLibrary;

namespace LessonTwo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LibraryClass libraryClass = new LibraryClass();
			LessonLearned lessonLearned = new LessonLearned();
			HomeWork homeWork = new HomeWork();

			homeWork.HomeWorkTwo(158);

			libraryClass.Pause();

		}
	}
}
