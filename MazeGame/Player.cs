using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
	public class Player : IMazeObject
	{
        public int X { get; set; } //x coordinate of the moving 
		public int Y { get; set; } //y coordinate
		//icon: that thing/shape moving in the maze
		public char Icon { get => '@'; }
		public bool IsSolid { get => true; }
	}
}
