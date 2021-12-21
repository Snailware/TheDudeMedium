using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MediumLib
{
	/// <summary>
	/// class for operating on database.
	/// </summary>
	public static class DatabaseOps
	{
		/// <summary>
		/// open connection to database.
		/// </summary>
		/// <param name="connectionString">connection string to use for connection.</param>
		/// <returns>true if successful. false otherwise.</returns>
		public static bool OpenConnection(string connectionString)
		{
			try
			{
				Connection = new SQLiteConnection(connectionString);
				Connection.Open();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// close connection to database.
		/// </summary>
		/// <returns>true if successful. false otherwise.</returns>
		public static bool CloseConnection()
		{
			try
			{
				Connection.Close();
				return true;
			}
			catch(Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// get sentence structures from database.
		/// </summary>
		/// <returns>list of sentence structures.</returns>
		public static List<string> GetSentenceStructures()
		{
			return QueryDatabase("SELECT structure FROM sentenceStructures;");
		}

		/// <summary>
		/// get nouns from database.
		/// </summary>
		/// <returns>list of nouns.</returns>
		public static List<string> GetNouns()
		{
			return QueryDatabase("SELECT word FROM vocabulary WHERE noun = 1;");
		}

		/// <summary>
		/// get pronouns from database.
		/// </summary>
		/// <returns>list of pronouns.</returns>
		public static List<string> GetPronouns()
		{
			return QueryDatabase("SELECT word FROM vocabulary WHERE pronoun = 1;");
		}

		/// <summary>
		/// get verbs from database.
		/// </summary>
		/// <returns>list of verbs.</returns>
		public static List<string> GetVerbs()
		{
			return QueryDatabase("SELECT word FROM vocabulary WHERE verb = 1;");
		}

		/// <summary>
		/// get adjectives from database.
		/// </summary>
		/// <returns>list of adjectives.</returns>
		public static List<string> GetAdjectives()
		{
			return QueryDatabase("SELECT word FROM vocabulary WHERE adjective = 1;");
		}

		/// <summary>
		/// get adverbs from database.
		/// </summary>
		/// <returns>list of adverbs.</returns>
		public static List<string> GetAdverbs()
		{
			return QueryDatabase("SELECT word FROM vocabulary WHERE adverb = 1;");
		}

		/// <summary>
		/// get prepositions from database.
		/// </summary>
		/// <returns>list of prepositions.</returns>
		public static List<string> GetPrepositions()
		{
			return QueryDatabase("SELECT word FROM vocabulary WHERE preposition = 1;");
		}

		/// <summary>
		/// get conjunctions from database.
		/// </summary>
		/// <returns>list of conjunctions.</returns>
		public static List<string> GetConjunctions()
		{
			return QueryDatabase("SELECT word FROM vocabulary WHERE conjunction = 1;");
		}

		/// <summary>
		/// execute query on database and return results. can only extract
		/// 1 column per query.
		/// </summary>
		/// <param name="query">query to execute.</param>
		/// <returns>results of query.</returns>
		private static List<string> QueryDatabase(string query)
		{
			List<string> output = new List<string>();
			// list to hold resulting objects.

			SQLiteCommand command = new SQLiteCommand(query, Connection);
			// create command obj.

			SQLiteDataReader dataReader = command.ExecuteReader();
			// execute command and create reader obj.

			while (dataReader.Read())
			{
				output.Add(dataReader.GetString(0));
			}
			// read all records in table and add vals to output.

			dataReader.Close();
			command.Dispose();
			// close objects.

			return output;
			// return results.
		}

		/// <summary>
		/// sql connection obj to be used in queries.
		/// </summary>
		private static SQLiteConnection Connection { get; set; }
	}
}
