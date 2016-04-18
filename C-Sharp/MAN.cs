using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
	{
	class MAN
		{


		public static void Draw(int x_, int y_)
			{
			Console.BackgroundColor = 0;
			//y_ = Console.CursorTop;
			//x_ = Console.CursorLeft;
			for (int i = 0; i < 16; i++)
				{
				

				Console.CursorTop = y_ + 1;
				Console.CursorLeft = x_ + 11;
				Console.BackgroundColor = 0;
				Console.Write("  ");

				Console.CursorTop = y_ + 2;
				Console.CursorLeft = x_ + 10;
				Console.Write("    ");

				Console.CursorTop = y_ + 3;
				Console.CursorLeft = x_ + 10;
				Console.Write("    ");

				Console.CursorTop = y_ + 4;
				Console.CursorLeft = x_ + 10;
				Console.Write("   ");

				Console.CursorTop = y_ + 5;
				Console.CursorLeft = x_ + 11;
				Console.Write("  ");



				Console.CursorTop = y_ + 6;
				Console.CursorLeft = x_ + 3;
				Console.Write(" ");
				Console.CursorLeft = x_ + 7;
				Console.Write("       ");










				Console.WriteLine("\n\n\n\n");
				}


			}

		}
	}
//ForegroundColor
//BackgroundColor
//CursorLeft
//CursorTop