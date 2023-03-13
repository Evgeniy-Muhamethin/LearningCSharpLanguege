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

			int countArray = 10;
			#region Работа с массивом
			//int[] array = new int[countArray];

			//lessonLearned.RandomArrayLenth(array);

			//lessonLearned.PrintArray(array);
			#endregion

			#region Линейный поиск
			//int[] array = new int[countArray];
			//lessonLearned.RandomArrayLenth(array);

			//foreach (int element in array)
			//{ 
			//	if (element == 4)
			//	{
			//                 Console.WriteLine($"\"{element}\"");
			//             }
			//	else
			//	{
			//                 Console.WriteLine($"\n{element}");
			//             }
			//}
			#endregion

			#region Бинарный поиск

			int[] array = new int[countArray];

			lessonLearned.RandomArrayLenth(array);

			Array.Sort(array);

			Exception ex  = new Exception();

			if (Array.BinarySearch(array, 5) < 0)
			{
                Console.WriteLine(ex.Message);
            }
			else
			{
                Console.WriteLine("It is Done");
            }

			#endregion
			string pathFile = "D:\\Git Repositorings\\LearningCSharpLanguege\\SeasonOne\\LessonThree\\TextFile1.txt";

			lessonLearned.FileStream(pathFile);

            libraryClass.Pause();
		}
	}
}
