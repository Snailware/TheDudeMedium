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
	public class DatabaseOpsTests
	{
		[TestMethod()]
		public void OpenConnectionTest()
		{
			Assert.IsTrue(DatabaseOps.OpenConnection(Model.ConnectionString));
			// act & assert.
		}

		[TestMethod()]
		public void CloseConnectionTest()
		{
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Assert.IsTrue(DatabaseOps.CloseConnection());
			}
			else
			{
				Assert.Fail();
			}
			// act & assert.
		}

		[TestMethod()]
		public void GetNounsTest()
		{
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Model.Nouns = DatabaseOps.GetNouns();
				DatabaseOps.CloseConnection();
				Assert.IsTrue(Model.Nouns.Count > 0);
			}
			else
			{
				Assert.Fail();
			}
			// act & assert.
		}

		[TestMethod()]
		public void GetPronounsTest()
		{
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Model.Pronouns = DatabaseOps.GetPronouns();
				DatabaseOps.CloseConnection();
				Assert.IsTrue(Model.Pronouns.Count > 0);
			}
			else
			{
				Assert.Fail();
			}
			// act & assert.
		}

		[TestMethod()]
		public void GetVerbsTest()
		{
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Model.Verbs = DatabaseOps.GetVerbs();
				DatabaseOps.CloseConnection();
				Assert.IsTrue(Model.Verbs.Count > 0);
			}
			else
			{
				Assert.Fail();
			}
			// act & assert.
		}

		[TestMethod()]
		public void GetAdjectivesTest()
		{
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Model.Adjectives = DatabaseOps.GetAdjectives();
				DatabaseOps.CloseConnection();
				Assert.IsTrue(Model.Adjectives.Count > 0);
			}
			else
			{
				Assert.Fail();
			}
			// act & assert.
		}

		[TestMethod()]
		public void GetAdverbsTest()
		{
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Model.Adverbs = DatabaseOps.GetAdverbs();
				DatabaseOps.CloseConnection();
				Assert.IsTrue(Model.Adverbs.Count > 0);
			}
			else
			{
				Assert.Fail();
			}
			// act & assert.
		}

		[TestMethod()]
		public void GetPrepositionsTest()
		{
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Model.Prepositions = DatabaseOps.GetPrepositions();
				DatabaseOps.CloseConnection();
				Assert.IsTrue(Model.Prepositions.Count > 0);
			}
			else
			{
				Assert.Fail();
			}
			// act & assert.
		}

		[TestMethod()]
		public void GetConjunctionsTest()
		{
			if (DatabaseOps.OpenConnection(Model.ConnectionString))
			{
				Model.Conjunctions = DatabaseOps.GetConjunctions();
				DatabaseOps.CloseConnection();
				Assert.IsTrue(Model.Conjunctions.Count > 0);
			}
			else
			{
				Assert.Fail();
			}
			// act & assert.
		}

		[TestMethod()]
		public void GetSentenceStructuresTest()
		{
			Assert.Fail();
		}
	}
}