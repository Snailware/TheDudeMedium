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

		/// <summary>
		/// create prophecy randomly using model data. 
		/// </summary>
		/// <returns>randomly generated Prophecy obj.</returns>
		public static Prophecy CreateProphecy()
		{
			string sentenceStructure = Randomizer.GetString(Model.SentenceStructures);
			string text = Randomizer.GetSentence(sentenceStructure);
			string imagePath = Randomizer.GetString(Model.ImagePaths);
			return new Prophecy(text, imagePath);
		}
	}
}
