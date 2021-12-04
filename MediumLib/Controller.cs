using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLib
{
	public static class Controller
	{
		/// <summary>
		/// get words & image paths from database and fill model.
		/// </summary>
		/// <returns>true if successful. otherwise false.</returns>
		public static bool Setup()
		{
			const string ConnectionString = "", // TODO add these.
						 ImageDirectoryPath = @"images",
						 SentenceStructureFilePath = @"";

			if (DatabaseOps.OpenConnection(ConnectionString))
			{
				Model.Nouns = DatabaseOps.GetNouns();
				Model.Pronouns = DatabaseOps.GetPronouns();
				Model.Verbs = DatabaseOps.GetVerbs();
				Model.Adjectives = DatabaseOps.GetAdjectives();
				Model.Adverbs = DatabaseOps.GetAdverbs();
				Model.Prepositions = DatabaseOps.GetPrepositions();
				Model.Conjunctions = DatabaseOps.GetConjunctions();
				Model.Interjections = DatabaseOps.GetInterjections();
				DatabaseOps.CloseConnection();
				Model.ImagePaths = FileOps.GetImagePaths(ImageDirectoryPath);
				Model.SentenceStructures = FileOps.GetSentenceStructures(SentenceStructureFilePath);
				return true;
			}
			else
			{
				return false;
			}
		}

		public static Prophecy CreateProphecy()
		{
			string text = null;
			string line = Model.SentenceStructures[RandomSeed.Next(0, Model.SentenceStructures.Count)];
			foreach (string partOfSpeech in line.Split(','))
			{
				string word = null;
				switch (partOfSpeech)
				{
					case "noun":
						word = Model.Nouns[RandomSeed.Next(0, Model.Nouns.Count)];
						break;
					case "pronoun":
						word = Model.Pronouns[RandomSeed.Next(0, Model.Pronouns.Count)];
						break;
					case "verb":
						word = Model.Verbs[RandomSeed.Next(0, Model.Verbs.Count)];
						break;
					case "adjective":
						word = Model.Adjectives[RandomSeed.Next(0, Model.Adjectives.Count)];
						break;
					case "adverb":
						word = Model.Adverbs[RandomSeed.Next(0, Model.Adverbs.Count)];
						break;
					case "preposition":
						word = Model.Prepositions[RandomSeed.Next(0, Model.Prepositions.Count)];
						break;
					case "conjunction":
						word = Model.Conjunctions[RandomSeed.Next(0, Model.Conjunctions.Count)];
						break;
					case "interjection":
						word = Model.Interjections[RandomSeed.Next(0, Model.Interjections.Count)];
						break;
				}
				if (!string.IsNullOrWhiteSpace(text))
				{
					text = $"{text} {word}";
				}
				else
				{
					text = word;
				}
			}
			string imagePath = Model.ImagePaths[RandomSeed.Next(0, Model.ImagePaths.Count)];
			return new Prophecy(text, imagePath);
		}

		private static Random RandomSeed { get; } = new Random();
	}
}
