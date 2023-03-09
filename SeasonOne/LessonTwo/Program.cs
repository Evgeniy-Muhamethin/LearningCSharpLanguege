using System;
using MyLibrary;

namespace LessonTwo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LibraryClass libraryClass = new LibraryClass();
			HomeWork homeWork = new HomeWork();

			#region Провод пароля
			//int count = 3;
			//do
			//{
			//	string login = Console.ReadLine();
			//	string password = Console.ReadLine();

			//	homeWork.HomeWorkFourAdd(login, password);
			//	count--;
			//}
			//while (count > 0);
			#endregion

			homeWork.HomeWorkSix();

			libraryClass.Pause();

		}
	}
}
