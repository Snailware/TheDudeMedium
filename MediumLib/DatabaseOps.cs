using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				Connection = new SqlConnection(connectionString);
				// create connection using connection string.

				Connection.Open();
				// open database connection.

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
		/// get nouns from database.
		/// </summary>
		/// <returns>list of nouns.</returns>
		public static List<string> GetNouns()
		{
			const string query = "SELECT word FROM vocabulary WHERE noun = 1;"; // TODO doule check this.
			List<string> results = QueryDatabase(query);
			return results;
		}

		/// <summary>
		/// get pronouns from database.
		/// </summary>
		/// <returns>list of pronouns.</returns>
		public static List<string> GetPronouns()
		{
			const string query = "SELECT word FROM vocabulary WHERE pronoun = 1;"; // TODO doule check this.
			List<string> results = QueryDatabase(query);
			return results;
		}

		/// <summary>
		/// get verbs from database.
		/// </summary>
		/// <returns>list of verbs.</returns>
		public static List<string> GetVerbs()
		{
			const string query = "SELECT word FROM vocabulary WHERE verb = 1;"; // TODO doule check this.
			List<string> results = QueryDatabase(query);
			return results;
		}

		/// <summary>
		/// get adjectives from database.
		/// </summary>
		/// <returns>list of adjectives.</returns>
		public static List<string> GetAdjectives()
		{
			const string query = "SELECT word FROM vocabulary WHERE adjective = 1;"; // TODO doule check this.
			List<string> results = QueryDatabase(query);
			return results;
		}

		/// <summary>
		/// get adverbs from database.
		/// </summary>
		/// <returns>list of adverbs.</returns>
		public static List<string> GetAdverbs()
		{
			const string query = "SELECT word FROM vocabulary WHERE adverb = 1;"; // TODO doule check this.
			List<string> results = QueryDatabase(query);
			return results;
		}

		/// <summary>
		/// get prepositions from database.
		/// </summary>
		/// <returns>list of prepositions.</returns>
		public static List<string> GetPrepositions()
		{
			const string query = "SELECT word FROM vocabulary WHERE preposition = 1;"; // TODO doule check this.
			List<string> results = QueryDatabase(query);
			return results;
		}

		/// <summary>
		/// get conjunctions from database.
		/// </summary>
		/// <returns>list of conjunctions.</returns>
		public static List<string> GetConjunctions()
		{
			const string query = "SELECT word FROM vocabulary WHERE conjunction = 1;"; // TODO doule check this.
			List<string> results = QueryDatabase(query);
			return results;
		}

		/// <summary>
		/// get interjections from database.
		/// </summary>
		/// <returns>list of interjections.</returns>
		public static List<string> GetInterjections()
		{
			const string query = "SELECT word FROM vocabulary WHERE interjection = 1;"; // TODO doule check this.
			List<string> results = QueryDatabase(query);
			return results;
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

			SqlCommand command = new SqlCommand(query, Connection);
			// create command object.

			SqlDataReader dataReader = command.ExecuteReader();
			// execute command & create reader obj.

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
		private static SqlConnection Connection { get; set; }

	}
}
