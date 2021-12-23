using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediumLib
{
	/// <summary>
	/// assorted extension methods.
	/// </summary>
	public static class ExtensionMethods
	{
		/// <summary>
		/// capitalize first char of string.
		/// </summary>
		/// <param name="str"></param>
		/// <returns>string with first char capitalized.</returns>
		public static string Capitalize(this string str)
		{
			List<char> characters = new List<char>();
			foreach (char character in str)
			{
				if (characters.Count != 0)
				{
					characters.Add(character);
				}
				else
				{
					characters.Add(char.ToUpper(character));
				}
			}
			return string.Concat(characters);
		}
	}
}
