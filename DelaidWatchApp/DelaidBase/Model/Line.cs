using System;
using System.Collections.Generic;

namespace DelaidBase
{
	/// <summary>
	/// Represents a train line
	/// </summary>
	public class Line
	{

		public string Name { get; set; }
		public int Color { get; set; }

		//TODO find out how we will identify trains(ID? Arrival Time?)
		/// <summary>
		/// Dictionary representation of the trains. 
		/// Key=train identifier
		/// </summary>
		public Dictionary<int, Train> Trains { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DelaidBase.Line"/>
		/// </summary>
		/// <param name="name">Name of this line</param>
		/// <param name="color">rgb hash of the lines color representation</param>
		public Line (string name, int color)
		{
			this.Name = name;
			this.Color = color;
			this.Trains = new Dictionary<int, Train> ();
		}

	}
}

