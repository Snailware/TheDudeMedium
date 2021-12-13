using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

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
		/// <param name="imagePath">image of prophecy.</param>
		public Prophecy(string text, BitmapImage image)
		{
			Text = text;
			Image = image;
		}

		/// <summary>
		/// text of prophecy.
		/// </summary>
		public string Text { get; }

		/// <summary>
		/// image of prophecy.
		/// </summary>
		public BitmapImage Image { get; }
	}
}
