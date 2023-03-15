using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonSix
{
	internal class LessonLearned
	{
		public void Start()
		{
			string pathFile = "D:\\Git Repositorings\\LearningCSharpLanguege\\SeasonOne\\LessonOne\\TextFile1.txt";

			FileStreamMethod(pathFile, FileMode.Open, FileAccess.Read);
		}

		private void FileStreamMethod(string patFile, FileMode fileMode, FileAccess fileAccess)
		{
			#region StreamWriter
			//StreamWriter sw = new StreamWriter(new FileStream(patFile, fileMode, fileAccess));
			//
			//for (int i = 0; i < 10; i++)
			//{
			//	sw.WriteLine("-");
			//}
			//
			//sw.Close();
			#endregion

			#region StreamReader

			StreamReader sr = new StreamReader(new FileStream(patFile, fileMode, fileAccess));

            Console.WriteLine(sr.ReadToEnd());

            #endregion
        }

		//TODO Остановился на двоичных потоках↓
		private void BinaryWriteAndRead()
		{

		}
	}
}
