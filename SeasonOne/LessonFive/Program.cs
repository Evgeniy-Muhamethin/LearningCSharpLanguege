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
            //TODO остановился на StringBuilder

			LibraryClass libraryClass = new LibraryClass();
			LessonLearned lessonLearned = new LessonLearned();

			#region CHAR
			char[] chars = new char[] { 'A', 'B', '4', 'c', 'D' };

            #region string = new string(array);
            //string testString = new string(chars);
            //Console.WriteLine(testString);
            //lessonLearned.CharArray(chars);
            #endregion

            #endregion

            #region STRING

            string[] strings = new string[] { "Алла найди себя",
            "Алла не может найти себя" };

            string[] result = lessonLearned.StringArrayDevidet(strings[0]);
            lessonLearned.StringArrayPluss(result);

            //Console.WriteLine(String.Compare(strings[1], strings[1]));

            #endregion

            libraryClass.Pause();
		}
	}
}
