using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace LessonTwo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LibraryClass libraryClass = new LibraryClass();
			LessonLearned lessonLearned = new LessonLearned();

			#region Operators 
			//int result = lessonLearned.TernarOperators(4,3);

			//Turn turn;

			//if (result == -1)
			//{
			//	turn = Turn.turnOff;
			//	lessonLearned.EnumOperators(turn);
			//}
			//else if (result == 1)
			//{
			//	turn = Turn.turnOn;
			//	lessonLearned.EnumOperators(turn);
			//}
			//else
			//{
			//	turn = Turn.turnNot;
			//	lessonLearned.EnumOperators(turn);
			//}
			#endregion

			lessonLearned.Loop(1,7);

			libraryClass.Pause();

		}
	}
}
