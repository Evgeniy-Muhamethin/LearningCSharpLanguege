using System;
using MyLibrary;

namespace LessonOne
{
	internal class Program
	{
		/// <summary>
		/// Коментарии описывающие класс или метод
		/// </summary>
		/// <param name="args">Место для описания параметров метода</param>
		static void Main(string[] args)
		{
			#region old programms code
			/*
			HomeWork homeWork = new HomeWork();
			LessonIsLearned lessonIsLearned = new LessonIsLearned();
			LibraryClass libraryClass = new LibraryClass();

			homeWork.PrintName("Jill", "Valentine", 
				"Racoon city", 35, 15, ConsoleColor.Green);

			libraryClass.Pause();
			*/
			#endregion
			LessonLearningTwo lessonLearningTwo = 
				new LessonLearningTwo();
			LibraryClass libraryClass = new LibraryClass();
			LearningClasses learningClasses
				= new LearningClasses();

			#region LessonWork
			/*
			double result = lessonLearningTwo.PlussTwoNumbers(10, 15);
			string textResult = $"{result}";
			libraryClass.Print(textResult);
			lessonLearningTwo.MethotFormatirovaniyData(result);
			lessonLearningTwo.MethotConsoleWork();
			
			Console.WriteLine("Enter number one");
			int _enterNumberOne = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter number two");
			int _enterNumberTwo = Convert.ToInt32(Console.ReadLine());

			double result = lessonLearningTwo.PlussTwoNumbers(_enterNumberOne,
				_enterNumberTwo, "It is TEST \t");

			libraryClass.Print($"Result = {result}");
			*/
			#endregion

			libraryClass.Pause();
		}
	}
}
