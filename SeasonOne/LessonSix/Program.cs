using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace LessonSix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LessonLearned lessonLearned = new LessonLearned();
			LibraryClass libraryClass = new LibraryClass();

			string pathFile = "D:\\Git Repositorings\\" +
				"LearningCSharpLanguege\\SeasonOne\\LessonOne\\TextFile1.txt";

			string catalog = @"D:\Programms\VisualStudio2022";

			lessonLearned.FileSystemMethod(catalog);

			libraryClass.Pause();
		}
	}
}
