using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace LessonThree
{
	internal class LessonLearned
	{
		public int FirstMethod(ref int a, ref int b, ref int resulf)
		{
			resulf = a + b;
			return resulf;
		}

		public StructClass StructMethod(ref StructClass structClass1, ref byte numberPluss)
		{
			StructClass structClass2;
			structClass2 = new StructClass();

			structClass2.X = structClass1.X + numberPluss;
			structClass2.Y = structClass1.Y + numberPluss;

			return structClass2;
		}

		public void PrintResult(int x, int y)
		{
            Console.WriteLine($"Coordinats: X = {x}, Y = {y}");
        }

		public void ThreadingStruct()
		{
			Thread.Sleep(2000);
		}
	}
}
