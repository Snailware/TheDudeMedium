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
	public class RandomNumberTests
	{
		[TestMethod()]
		public void GetBetweenTest()
		{
			bool oneFound = false,
				 twoFound = false,
				 threeFound = false;
			// arrange.

			for (int index = 0; index < 100; index++)
			{
				int number = RandomNumber.GetBetween(1, 4);
				switch (number)
				{
					case 1:
						oneFound = true;
						break;
					case 2:
						twoFound = true;
						break;
					case 3:
						threeFound = true;
						break;
				}
			}
			// act.

			Assert.IsTrue(oneFound && twoFound && threeFound);
			// assert.
		}
	}
}