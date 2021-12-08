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
	public class ExtensionMethodsTests
	{
		[TestMethod()]
		public void CapitalizeTest()
		{
			string testWord = "cheese",
				   expected = "Cheese";
			// arrange.

			string actual = testWord.Capitalize();
			// act.

			Assert.AreEqual(expected, actual);
			// assert.
		}
	}
}