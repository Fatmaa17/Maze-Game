namespace MazeGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Hello! It's MAZE..\nUse arcs in ur keyboard to move!\n\n");
			Maze maze = new Maze(40, 20);
			while (true)
			{
				maze.DrawMaze();
				maze.MovePlayer();
			}
		}
	}
}
