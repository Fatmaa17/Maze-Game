using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
	public interface IMazeObject
	{
		//icon: that thing/shape represents the wall in the maze
		char Icon { get;}
		//Is that icon hit a wall? = Is solid? Movement block
		bool IsSolid { get; }
	}
}
