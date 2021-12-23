using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediumLib
{
	/// <summary>
	/// class for performing file operations. 
	/// </summary>
	public static class FileOps
	{
		/// <summary>
		/// extract image file paths from image directory. 
		/// </summary>
		/// <param name="directoryPath">path to image directory.</param>
		/// <returns>list of all image paths found.</returns>
		public static List<string> GetImagePaths(string directoryPath)
		{
			List<string> imagePaths = new List<string>();
			foreach(string path in Directory.GetFiles(directoryPath))
			{
				imagePaths.Add(Path.GetFullPath(path));
			}
			return imagePaths;
		}
	}
}
