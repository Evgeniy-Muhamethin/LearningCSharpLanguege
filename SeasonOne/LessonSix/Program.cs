using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
using System.Windows;
using System.Windows.Forms;

namespace LessonSix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//LessonLearned lessonLearned = new LessonLearned();
			LibraryClass libraryClass = new LibraryClass();

			//string pathFile = "D:\\Git Repositorings\\" +
			//	"LearningCSharpLanguege\\SeasonOne\\LessonOne\\TextFile1.txt";

			//string catalog = @"D:\Programms\VisualStudio2022";

			//lessonLearned.FileSystemMethod(catalog);

			MessageBox.Show("New teams");
			MessageBox.Show("New teams", "Заголовок");

			libraryClass.Pause();
		}
	}
}
