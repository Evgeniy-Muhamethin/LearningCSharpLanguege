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
			//string pathFile = "D:\\Git Repositorings\\LearningCSharpLanguege\\SeasonOne\\LessonOne\\TextFile1.txt";

			//FileStreamMethod(pathFile, FileMode.Open, FileAccess.Read);
			BinaryWriteAndRead();
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
			sr.Close();

            #endregion
        }

		private void BinaryWriteAndRead()
		{
			FileStream fileStream = new FileStream("D:\\Git Repositorings\\" +
				"LearningCSharpLanguege\\SeasonOne\\LessonOne\\data.bin", FileMode.Open);
			BinaryReader br = new BinaryReader(fileStream);

			long result = fileStream.Length;

			int a;
			for (int i = 0; i < result; i++)
			{
				a = br.ReadByte();
                Console.WriteLine(a);
			}

			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			char clearChar = char.Parse(Console.ReadLine());
			if (clearChar == 'C')
			{
				binaryWriter.Flush();
			}

			binaryWriter.Close();
			fileStream.Close();
			br.Close();
		}
	}
}
