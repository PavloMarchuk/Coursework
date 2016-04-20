using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp
	{
	class Sprite
		{
		
//
		//ArrayList<ArrayList<int>> sprite;
		//ArrayList < ArrayList<int >> ss; 
		List<List<int>> sprite;
		public Sprite()
			{
			sprite = new List<List<int>> { new List<int>()
//	1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6
{	3,3,3,0,0,0,0,0,0,0,3,3,3,3,3,3}, new List<int>()
{	3,3,0,0,7,7,8,5,8,7,0,3,3,3,3,3}, new List<int>()
{	3,3,0,7,7,8,8,5,8,7,0,3,3,3,3,3}, new List<int>()
{	3,3,0,7,7,7,7,8,7,8,7,0,3,3,3,3}, new List<int>()
{	3,3,0,7,7,8,5,5,8,7,0,0,3,3,3,3}, new List<int>()
{	3,3,0,7,7,0,0,0,0,0,0,3,3,3,3,3}, new List<int>()
{	3,3,3,0,0,0,0,0,0,6,0,3,3,3,3,3}, new List<int>()
{	3,3,0,7,8,7,6,6,6,0,3,3,0,3,3,3}, new List<int>()
{	3,3,0,8,5,8,7,6,7,7,0,3,0,0,3,3}, new List<int>()
{	3,0,7,5,8,8,7,7,8,5,7,0,7,5,0,3}, new List<int>()
{	3,0,0,5,8,7,7,8,8,7,6,7,0,0,0,3}, new List<int>()
{	3,0,0,7,5,5,5,7,0,0,0,0,3,3,3,3}, new List<int>()
{	3,0,0,7,7,0,7,8,0,0,0,0,3,3,3,3}, new List<int>()
{	3,8,0,0,0,0,8,8,6,0,0,8,3,3,3,3}, new List<int>()
{	3,3,3,8,0,0,0,0,0,0,8,3,3,3,3,3}, new List<int>()
{	3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3}};
			}

		public void Draw(int x_, int y_)
			{
			ConsoleColor color = 0;
			//Console.ResetColor();
			foreach (var item in sprite)
				{//
				foreach (var item2 in item)
					{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("0");
					switch (item2)
						{
						case 3:
							//Console.CursorLeft++;
							break;
						case 5:
							color = ConsoleColor.White;
							break;
						default:
							color = (ConsoleColor)item2;
							break;
						}
					if (item2 == 3)
					{ Console.CursorLeft++; break; }
					Console.ForegroundColor = (ConsoleColor)color;
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("0");
					}
				Console.CursorTop += +1;
				Console.CursorLeft = 0;
				}
			Console.ResetColor();
			}
		//public ConsoleColor ReColor(char chaar)
		//	{
		//	System.ConsoleColor color = ConsoleColor.Black;





		//	return color;
		//	}



		//	3 = пропуск (3) (дарк ціан ) 
		//  0 = Black (0)
		//  7 = Grey (7)
		//  8 = DarkGrey (8)
		//  6 = DarkYellow (6)
		//	5 = White (15)	(5) (дарк маджента)








		//Console.CursorTop = y_ + 1;
		//Console.CursorLeft = x_ + 11;
		//Console.BackgroundColor = 0;
		//Console.Write("  ");

		//Console.CursorTop = y_ + 2;
		//Console.CursorLeft = x_ + 10;
		//Console.Write("    ");
		//Console.CursorTop = y_ + 3;
		//Console.CursorLeft = x_ + 10;
		//Console.Write("    ");

		//Console.CursorTop = y_ + 4;
		//Console.CursorLeft = x_ + 10;
		//Console.Write("   ");

		//Console.CursorTop = y_ + 5;
		//Console.CursorLeft = x_ + 11;
		//Console.Write("  ");



		//Console.CursorTop = y_ + 6;
		//Console.CursorLeft = x_ + 3;
		//Console.Write(" ");
		//Console.CursorLeft = x_ + 7;
		//Console.Write("       ");




























		}
	}
