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
			string[] imagePaths = Directory.GetFiles(directoryPath);
			return imagePaths.ToList<string>();
		}

		/// <summary>
		/// extract sentence structure templates from sentence structure file. 
		/// </summary>
		/// <param name="filePath">path to sentence structure file.</param>
		/// <returns>list of all sentence structures.</returns>
		public static List<string> GetSentenceStructures(string filePath)
		{
			string[] structs = File.ReadAllLines(filePath);
			return structs.ToList<string>();
		}
	}
}
