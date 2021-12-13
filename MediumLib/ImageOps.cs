using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MediumLib
{
	/// <summary>
	/// class for performing operations on images.
	/// </summary>
	public static class ImageOps
	{
		/// <summary>
		/// create a bitmap image from file.
		/// </summary>
		/// <param name="path">path to image file.</param>
		/// <returns>BitmapImage obj from file. </returns>
		public static BitmapImage CreateBitmapImage(string path)
		{
			return new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
		}
	}
}
