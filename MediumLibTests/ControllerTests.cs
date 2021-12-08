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
	public class ControllerTests
	{
		[TestMethod()]
		public void SetupTest()
		{
			Assert.IsTrue(Controller.Setup());
		}

		[TestMethod()]
		public void CreateProphecyTest()
		{
			bool propheciesEqual = false;
			Controller.Setup();
			// arrange.

			Prophecy prophecy1 = Controller.CreateProphecy();
			Prophecy prophecy2 = Controller.CreateProphecy();
			Prophecy prophecy3 = Controller.CreateProphecy();
			if (prophecy1 == prophecy2 &&
				prophecy2 == prophecy3)
			{
				propheciesEqual = true;
			}
			// act.

			Assert.IsFalse(propheciesEqual);
			// assert.
		}

		[TestMethod()]
		public void GetStringTest()
		{
			bool oneFound = false,
				 twoFound = false,
				 threeFound = false;
			List<string> testList = new List<string> { "one", "two", "three" };
			// arrange.

			for (int index = 0; index < 100; index++)
			{
				switch (Controller.GetString(testList))
				{
					case "one":
						oneFound = true;
						break;
					case "two":
						twoFound = true;
						break;
					case "three":
						threeFound = true;
						break;
				}
				if (oneFound && twoFound && threeFound)
				{
					break;
				}
			}
			// act.

			Assert.IsTrue(oneFound && twoFound && threeFound);
			// assert.
		}

		[TestMethod()]
		public void GetSentenceTest()
		{
			bool oneFound = false, twoFound = false, threeFound = false,
				 fourFound = false, fiveFound = false, sixFound = false,
				 sevenFound = false, eightFound = false, nineFound = false,
				 tenFound = false, elevenFound = false, twelveFound = false,
				 thirteenFound = false, fourteenFound = false,
				 fifteenFound = false, sixteenFound = false,
				 seventeenFound = false, eighteenFound = false,
				 nineteenFound = false, twentyFound = false,
				 twentyOneFound = false, twentyTwoFound = false,
				 twentyThreeFound = false, twentyFourFound = false,
				 capitalized = false, punctuated = false,
				 shortFound = false, mediumFound = false, longFound = false;

			Model.Nouns = new List<string> { "one", "two", "three" };
			Model.Pronouns = new List<string> { "four", "five", "six" };
			Model.Verbs = new List<string> { "seven", "eight", "nine" };
			Model.Adjectives = new List<string> { "ten", "eleven", "twelve" };
			Model.Adverbs = new List<string> { "thirteen", "fourteen", "fifteen" };
			Model.Prepositions = new List<string> { "sixteen", "seventeen", "eighteen" };
			Model.Conjunctions = new List<string> { "nineteen", "twenty", "twentyone" };
			Model.Interjections = new List<string> { "twentytwo", "twentythree", "twentyfour" };

			Model.SentenceStructures = new List<string> { "noun,pronoun,verb,adjective,adverb,preposition,conjunction,interjection",
														  "noun,pronoun,verb,adjective,adverb",
														  "preposition,interjection,conjunction" };
			// arrange.

			for (int index = 0; index < 1000; index++)
			{
				string template = Controller.GetString(Model.SentenceStructures);
				string sentence = Controller.GetSentence(template);
				string[] sentenceTokens = sentence.Split(null);
				foreach (string word in sentenceTokens)
				{
					switch (word.ToLower())
					{
						case "one":
							oneFound = true;
							break;
						case "two":
							twoFound = true;
							break;
						case "three":
							threeFound = true;
							break;
						case "four":
							fourFound = true;
							break;
						case "five":
							fiveFound = true;
							break;
						case "six":
							sixFound = true;
							break;
						case "seven":
							sevenFound = true;
							break;
						case "eight":
							eightFound = true;
							break;
						case "nine":
							nineFound = true;
							break;
						case "ten":
							tenFound = true;
							break;
						case "eleven":
							elevenFound = true;
							break;
						case "twelve":
							twelveFound = true;
							break;
						case "thirteen":
							thirteenFound = true;
							break;
						case "fourteen":
							fourteenFound = true;
							break;
						case "fifteen":
							fifteenFound = true;
							break;
						case "sixteen":
							sixteenFound = true;
							break;
						case "seventeen":
							seventeenFound = true;
							break;
						case "eighteen":
							eighteenFound = true;
							break;
						case "nineteen":
							nineteenFound = true;
							break;
						case "twenty":
							twentyFound = true;
							break;
						case "twentyone":
							twentyOneFound = true;
							break;
						case "twentytwo":
							twentyTwoFound = true;
							break;
						case "twentythree":
							twentyThreeFound = true;
							break;
						case "twentyfour":
							twentyFourFound = true;
							break;
					}
				}

				if (char.IsUpper(sentence[0]))
				{
					capitalized = true;
				}

				if (sentence.EndsWith("."))
				{
					punctuated = true;
				}

				switch (sentenceTokens.Length)
				{
					case 3:
						shortFound = true;
						break;
					case 5:
						mediumFound = true;
						break;
					case 8:
						longFound = true;
						break;
				}
				if (oneFound && twoFound && threeFound && fourFound &&
					fiveFound && sixFound && sevenFound && eightFound &&
					nineFound && tenFound && elevenFound &&
					twelveFound && thirteenFound && fourteenFound &&
					fifteenFound && sixteenFound && seventeenFound &&
					eighteenFound && nineteenFound && twentyFound &&
					twentyOneFound && twentyTwoFound &&
					twentyThreeFound && twentyFourFound &&
					capitalized && punctuated && shortFound &&
					mediumFound && longFound)
				{
					break;
				}
			}
			// act.

			Console.WriteLine($"oneFound : {oneFound}" + Environment.NewLine +
							  $"twoFound : {twoFound}" + Environment.NewLine +
							  $"threeFound : {threeFound}" + Environment.NewLine +
							  $"fourFound : {fourFound}" + Environment.NewLine +
							  $"fiveFound : {fiveFound}" + Environment.NewLine +
							  $"sixFound : {sixFound}" + Environment.NewLine +
							  $"sevenFound : {sevenFound}" + Environment.NewLine +
							  $"eightFound : {eightFound}" + Environment.NewLine +
							  $"nineFound : {nineFound}" + Environment.NewLine +
							  $"tenFound : {tenFound}" + Environment.NewLine +
							  $"elevenFound : {elevenFound}" + Environment.NewLine +
							  $"twelveFound : {twelveFound}" + Environment.NewLine +
							  $"thirteenFound : {thirteenFound}" + Environment.NewLine +
							  $"fourteenFound : {fourteenFound}" + Environment.NewLine +
							  $"fifteenFound : {fifteenFound}" + Environment.NewLine +
							  $"sixteenFound : {sixteenFound}" + Environment.NewLine +
							  $"seventeenFound : {seventeenFound}" + Environment.NewLine +
							  $"eighteenFound : {eighteenFound}" + Environment.NewLine +
							  $"nineteenFound : {nineteenFound}" + Environment.NewLine +
							  $"twentyFound : {twentyFound}" + Environment.NewLine +
							  $"twentyOneFound : {twentyOneFound}" + Environment.NewLine +
							  $"twentyTwoFound : {twentyTwoFound}" + Environment.NewLine +
							  $"twentyThreeFound : {twentyThreeFound}" + Environment.NewLine +
							  $"twentyFourFound : {twentyFourFound}" + Environment.NewLine +
							  $"capitalized : {capitalized}" + Environment.NewLine +
							  $"punctuated : {punctuated}" + Environment.NewLine +
							  $"shortFound : {shortFound}" + Environment.NewLine +
							  $"mediumFound : {mediumFound}" + Environment.NewLine +
							  $"longFound : {longFound}" + Environment.NewLine);

			Assert.IsTrue(oneFound && twoFound && threeFound && fourFound &&
						  fiveFound && sixFound && sevenFound && eightFound &&
						  nineFound && tenFound && elevenFound &&
						  twelveFound && thirteenFound && fourteenFound &&
						  fifteenFound && sixteenFound && seventeenFound &&
						  eighteenFound && nineteenFound && twentyFound &&
						  twentyOneFound && twentyTwoFound &&
						  twentyThreeFound && twentyFourFound &&
						  capitalized && punctuated && shortFound &&
						  mediumFound && longFound);
			// assert.
		}
	}
}