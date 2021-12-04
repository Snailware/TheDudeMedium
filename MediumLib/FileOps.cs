using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediumLib
{
	public static class FileOps
	{
		public static List<string> GetImagePaths(string directoryPath)
		{
			string[] imagePaths = Directory.GetFiles(directoryPath);
			return imagePaths.ToList<string>();
		}

		public static List<string> GetSentenceStructures(string filePath)
		{
			string[] structs = File.ReadAllLines(filePath);
			return structs.ToList<string>();
		}
	}
}
