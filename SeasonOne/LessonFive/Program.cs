using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace LessonFive
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LibraryClass libraryClass = new LibraryClass();
			LessonLearned lessonLearned = new LessonLearned();

			char[] chars = new char[] { 'A', 'B', '4', 'c', 'D' };

			#region string = new string(array);
			string testString = new string(chars);
            Console.WriteLine(testString);
			#endregion

			lessonLearned.CharArray(chars);

			libraryClass.Pause();
		}
	}
}
