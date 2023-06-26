using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace LessonOne
{
	internal class LearningClasses
	{
		public void ConsoleMethod()
		{
			LibraryClass libraryClass = new LibraryClass();
			Console.WindowWidth = 70;
			Console.WindowHeight = 35;
			Console.SetWindowPosition(10,20);
			Console.SetCursorPosition(34,35);
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.Blue;
			
			Console.Write("Jill Valentine\n");

			Console.WriteLine("Please, enter command \"Clear\"");
			string enterCommand = Console.ReadLine();
			Clear(enterCommand);
			Console.Beep();
			libraryClass.Pause();
		}

		private void Clear(string command)
		{
			if (command == "clear")
			{
				Console.Clear();
			}
		}

		public void CharMethod()
		{

		}

		public void ConvertMethod()
		{

		}

		public void MathMethod()
		{

		}
	}
}
