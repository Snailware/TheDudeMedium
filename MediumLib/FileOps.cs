﻿using System;
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
		/// extract database connection string from file.
		/// </summary>
		/// <param name="filePath">path to connection string file.</param>
		/// <returns>connection string.</returns>
		//public static string GetConnectionString(string filePath)
		//{
		//	return File.ReadAllText(filePath);
		//}
		// TODO delete this

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

		/// <summary>
		/// extract sentence structure templates from sentence structure file. 
		/// </summary>
		/// <param name="filePath">path to sentence structure file.</param>
		/// <returns>list of all sentence structures.</returns>
		//public static List<string> GetSentenceStructures(string filePath)
		//{
		//	string[] structs = File.ReadAllLines(filePath);
		//	return structs.ToList();
		//}
		// TODO delete this
	}
}
