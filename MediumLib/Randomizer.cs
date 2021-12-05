using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLib
{
	/// <summary>
	/// class for performing randomized operations. 
	/// </summary>
	public static class Randomizer
	{
		/// <summary>
		/// randomly select a string from list of strings.
		/// </summary>
		/// <param name="input">list of strings to make selection from.</param>
		/// <returns>randomly selected string.</returns>
		public static string GetString(List<string> input)
		{
			return input[Seed.Next(0, input.Count)];
		}

		/// <summary>
		/// randomly generate sentence using sentence structure template.
		/// </summary>
		/// <param name="sentenceStructure">template to base new sentence on.</param>
		/// <returns>randomly generated sentence.</returns>
		public static string GetSentence(string sentenceStructure)
		{
			string text = null;
			foreach (string partOfSpeech in sentenceStructure.Split(','))
			{
				string word = null;
				switch (partOfSpeech)
				{
					case "noun":
						word = GetString(Model.Nouns);
						break;
					case "pronoun":
						word = GetString(Model.Pronouns);
						break;
					case "verb":
						word = GetString(Model.Verbs);
						break;
					case "adjective":
						word = GetString(Model.Adjectives);
						break;
					case "adverb":
						word = GetString(Model.Adverbs);
						break;
					case "preposition":
						word = GetString(Model.Prepositions);
						break;
					case "conjunction":
						word = GetString(Model.Conjunctions);
						break;
					case "interjection":
						word = GetString(Model.Interjections);
						break;
				}
				if (!string.IsNullOrWhiteSpace(text))
				{
					text += $" {word}";
				}
				else
				{
					text = word.Capitalize();
				}
			}
			return text += ".";
		}

		/// <summary>
		/// Random obj to use for selections.
		/// </summary>
		private static Random Seed { get; } = new Random();
	}
}
