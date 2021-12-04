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
		/// get words from database and fill model.
		/// </summary>
		/// <returns></returns>
		public static bool Setup()
		{
			const string ConnectionString = "";

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
				return true;
			}
			else
			{
				return false;
			}
		}

		public static Prophecy CreateProphecy()
		{
			List<string> text = new List<string>();

			
			
		}



		private static Random RandomSeed { get; } = new Random();
	}
}
