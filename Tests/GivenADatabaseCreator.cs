using System;
using System.IO;
using ScrubJayTools;
using NUnit.Framework;
using System.Data.SQLite;

namespace Tests
{
    [TestFixture]
    [Category("database")]
    public class GivenADatabaseCreator
    {
        private DatabaseCreator Sut;

        private string _testFolder;
        private string _databasePath;
        
        [SetUp]
        public void Setup()
        {
            Sut = new DatabaseCreator();

            _testFolder =
                Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        [TestCase(false)]
        public void GivenADatabaseCreator_WhenICreateADatabase_ThenTheDatabaseIsCreated_AndFilenameIsReturned(
            bool asPrerequisite)
        {
            var dbFilename = "database" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".sqlite";
            var databasePath = _testFolder + @"\" + dbFilename;

            var returnedDatabasePath = Sut.CreateDatabase(_testFolder, dbFilename);

            Assert.AreEqual(databasePath, returnedDatabasePath,
                asPrerequisite ? "Prerequisite not met: must be able to create database" : "Database file should be as expected");
            Assert.IsTrue(File.Exists(databasePath),
                asPrerequisite ? "Prerequisite not met: must be able to create database" : "Database file should exist");

            _databasePath = databasePath;
        }


        [Test]
        [Ignore("'File is used by another process' or whatever")]
        public void GivenADatabaseCreator_WhenICreateADatabase_ThenAllTablesAreCorrectlyCreated()
        {
            GivenADatabaseCreator_WhenICreateADatabase_ThenTheDatabaseIsCreated_AndFilenameIsReturned(asPrerequisite: true);

            string[] tables = { "Website" };

            using (var connection = new SQLiteConnection("Data Source=" + _databasePath + ";Version=3;"))
            {
                connection.Open();

                foreach (var oneTable in tables)
                {
                    using (var command = new SQLiteCommand("SELECT * FROM " + oneTable, connection))
                    {
                        command.ExecuteReader();
                    };
                    
                }
            }
            Assert.Pass();
            
        }


    }
}
