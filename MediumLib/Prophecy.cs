using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLib
{
	/// <summary>
	/// class for prophecies.
	/// </summary>
	public class Prophecy
	{
		/// <summary>
		/// class for prophecies.
		/// </summary>
		/// <param name="text">text of prophecy.</param>
		/// <param name="imagePath">path to prophecy image.</param>
		public Prophecy(string text, string imagePath)
		{
			Text = text;
			ImagePath = imagePath;
		}

		/// <summary>
		/// text of prophecy.
		/// </summary>
		public string Text { get; }

		/// <summary>
		/// path to prophecy image.
		/// </summary>
		public string ImagePath { get; }
	}
}
