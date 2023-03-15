using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace LessonFive
{
	internal class Program
	{
        delegate void DelegateMethodStringBuilder(string text, char addText);

		static void Main(string[] args)
		{
			LibraryClass libraryClass = new LibraryClass();
			LessonLearned lessonLearned = new LessonLearned();
			Data data = new Data();
			HomeWorks homeWorks = new HomeWorks();

			#region Lesson
			DelegateMethodStringBuilder delegateMethodStringBuilder;
            //Делегат↓↓↓
            delegateMethodStringBuilder =
                lessonLearned.StringBuiledrMethod;

			data.Text = "Test one";
			data.Number = 10;
			
			#region StringBuilder work
			string text = data.Text;
			int number = data.Number;

			//Console.WriteLine("-----------------");
			//char enterText = char.Parse(Console.ReadLine());
			//
			//delegateMethodStringBuilder(text, enterText);

			//lessonLearned.StringBuiledrMethod(text, text.Length, 3);

			#endregion

			#region CHAR
			//char[] chars = new char[] { 'A', 'B', '4', 'c', 'D' };

			#region string = new string(array);
			//string testString = new string(chars);
			//Console.WriteLine(testString);
			//lessonLearned.CharArray(chars);
			#endregion

			#endregion

			#region STRING

			//string[] strings = new string[] { "Алла найди себя",
			//"Алла не может найти себя" };
			//
			//string[] result = lessonLearned.StringArrayDevidet(strings[0]);
			//delegateFirst(result);

			//Console.WriteLine(String.Compare(strings[1], strings[1]));

			#endregion
			#endregion

			#region Home Work
			//string login = Console.ReadLine();
			//homeWorks.Example(login);

			homeWorks.Regulars();
			#endregion

			libraryClass.Pause();
		}
	}
}
