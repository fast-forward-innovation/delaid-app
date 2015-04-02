using System;

namespace DelaidBase
{
	/// <summary>
	/// Represents one train along a <see cref="Line"/> 
	/// </summary>
	public class Train
	{
		public int Id { get; set; }
		public DateTime Arrival { get; set; }
		public bool Delayed { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DelaidBase.Train"/> class.
		/// </summary>
		/// <param name="identifier">Identifier of this train</param>
		/// <param name="arrival">Time of the trains arrival</param>
		/// <param name="delayed">Whether this train is delayed or not.</param>
		public Train (int identifier, DateTime arrival, bool delayed)
		{
			this.Id = identifier;
			this.Arrival = arrival;
			this.Delayed = delayed;
		}
	}
}

