using System;
using MyLibrary;

namespace LessonFour
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LessonLearned lessonLearned = new LessonLearned();
			LibraryClass libraryClass = new LibraryClass();
			HomeWorks homeWorks = new HomeWorks();

			int[] array = new int[4];
			string pathFile = "D:\\Git Repositorings\\" +
				"LearningCSharpLanguege\\" +
				"SeasonOne\\LessonThree\\TextFile1.txt";

			//обработка исключения на отсуудствие файла 
			try
			{
				array = homeWorks.ReadFile(pathFile);
			}
			catch (Exception ex) 
			{
                Console.WriteLine(ex.Message);
            }

			foreach (int element in array)
			{
                Console.WriteLine($"Element array = {element}");
            }

            libraryClass.Pause();
		}
	}
}
