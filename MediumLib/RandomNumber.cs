using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLib
{
	/// <summary>
	/// class for performing randomized operations. 
	/// </summary>
	public static class RandomNumber
	{
		/// <summary>
		/// get a random number between the two entered values.
		/// </summary>
		/// <param name="minValue">min value to select. (inclusive)</param>
		/// <param name="maxValue">max value to select. (exclusive)</param>
		/// <returns>random number between values.</returns>
		public static int GetBetween(int minValue, int maxValue)
		{
			return Seed.Next(minValue, maxValue);
		}

		/// <summary>
		/// Random obj to use for selections.
		/// </summary>
		private static Random Seed { get; } = new Random();
	}
}
