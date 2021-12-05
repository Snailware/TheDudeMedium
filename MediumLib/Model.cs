using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLib
{
	/// <summary>
	/// data model for program.
	/// </summary>
	public static class Model
	{
		public static List<string> Nouns { get; set; }
		public static List<string> Pronouns { get; set; }
		public static List<string> Verbs { get; set; }
		public static List<string> Adjectives { get; set; }
		public static List<string> Adverbs { get; set; }
		public static List<string> Prepositions { get; set; }
		public static List<string> Conjunctions { get; set; }
		public static List<string> Interjections { get; set; }
		public static List<string> ImagePaths { get; set; }
		public static List<string> SentenceStructures { get; set; }
	}
}
