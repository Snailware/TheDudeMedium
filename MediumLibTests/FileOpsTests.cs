using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediumLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLib.Tests
{
	[TestClass()]
	public class FileOpsTests
	{
		[TestMethod()]
		public void GetImagePathsTest()
		{
			List<string> imagePaths = FileOps.GetImagePaths(Model.ImageDirectoryPath);
			// arrange & act.

			Assert.IsNotNull(imagePaths[0]);
			// Assert.
		}
	}
}