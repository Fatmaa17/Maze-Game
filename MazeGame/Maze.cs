using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
	public class Maze

	{
		private int _Width, _Height;
		private Player _Player;
		private IMazeObject[,] _MazeObjectsArray;
		public Maze(int width, int height)
		{
			_Width = width;
			_Height = height;
			_MazeObjectsArray = new IMazeObject[width, height];
			_Player = new Player()
			{
				X = 1,
				Y = 1,
			};
		}
		public void DrawMaze()
		{
			Console.Clear();
			for (int y = 0; y < _Height; y++)
			{
				for (int x = 0; x < _Width; x++)
				{
					//Outer walls
					if (x == 39 && y == 18)
					{
						_MazeObjectsArray[x, y] = new EmptySpace();
						Console.Write(_MazeObjectsArray[x, y].Icon);
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}

					else if (x == 0 || y == 0 || x == _Width - 1 || y == _Height - 1)
					{
						//Making the solid icons
						_MazeObjectsArray[x, y] = new Wall();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}
					else if (x == _Player.X && y == _Player.Y)
					{
						Console.Write(_Player.Icon);
					}
					else if (x % 3 == 0 && y % 3 == 0)
					{
						_MazeObjectsArray[x, y] = new Wall();
						Console.Write(_MazeObjectsArray[x, y].Icon);

					}
					else
					{
						_MazeObjectsArray[x, y] = new EmptySpace();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}

				}
				Console.WriteLine();

			}
		}
		public void MovePlayer()
		{
			ConsoleKeyInfo userInput = Console.ReadKey();
			ConsoleKey key = userInput.Key; //ConsoleKey enumeration. This enum includes predefined values for almost all keyboard keys
			switch (key)
			{
				case ConsoleKey.UpArrow:
					UpdatePlayer(0, -1);
					break;
				case ConsoleKey.DownArrow:
					UpdatePlayer(0, 1);       //Console coordinates
					break;
				case ConsoleKey.LeftArrow:
					UpdatePlayer(-1, 0);
					break;
				case ConsoleKey.RightArrow:
					UpdatePlayer(1, 0);
					break;

			}

		}

		private void UpdatePlayer(int dx, int dy) //Distances that the player object moves
		{
			int newX = _Player.X + dx;
			int newY = _Player.Y + dy;

			if (newX < _Width && newX >= 0 && newY >= 0 && newY < _Height && _MazeObjectsArray[newX, newY].IsSolid == false)
			{
				_Player.X = newX;
				_Player.Y = newY;
				DrawMaze();
			}
		}
	}
}