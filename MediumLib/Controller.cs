using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLib
{
	/// <summary>
	/// program controller. 
	/// </summary>
	public static class Controller
	{
		/// <summary>
		/// get words & image paths from database and fill model.
		/// </summary>
		/// <returns>true if successful. otherwise false.</returns>
		public static bool Setup()
		{
			Model.ConnectionString = FileOps.GetConnectionString(Model.ConnectionStringFilePath);
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Model.Nouns = DatabaseOps.GetNouns();
				Model.Pronouns = DatabaseOps.GetPronouns();
				Model.Verbs = DatabaseOps.GetVerbs();
				Model.Adjectives = DatabaseOps.GetAdjectives();
				Model.Adverbs = DatabaseOps.GetAdverbs();
				Model.Prepositions = DatabaseOps.GetPrepositions();
				Model.Conjunctions = DatabaseOps.GetConjunctions();
				DatabaseOps.CloseConnection();
				Model.ImagePaths = FileOps.GetImagePaths(Model.ImageDirectoryPath);
				Model.SentenceStructures = FileOps.GetSentenceStructures(Model.SentenceStructureFilePath);
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// create prophecy randomly using model data. 
		/// </summary>
		/// <returns>randomly generated Prophecy obj.</returns>
		public static Prophecy CreateProphecy()
		{
			string sentenceStructure = GetString(Model.SentenceStructures);
			string text = GetSentence(sentenceStructure);
			string imagePath = GetString(Model.ImagePaths);
			return new Prophecy(text, imagePath);
		}

		/// <summary>
		/// randomly select a string from list of strings.
		/// </summary>
		/// <param name="input">list of strings to make selection from.</param>
		/// <returns>randomly selected string.</returns>
		public static string GetString(List<string> input)
		{
			return input[RandomNumber.GetBetween(0, input.Count)];
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
	}
}
