using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScrubJayTools
{
    public class DatabaseCreator
    {
        public string CreateDatabase(string folderPath, string filename)
        {
            string databasePath = folderPath + @"\" + filename;
            SQLiteConnection.CreateFile(databasePath);

            if (File.Exists(databasePath))
            {
                PopulateDatabase(databasePath);
            }
            else
            {
                // untested
                throw new IOException(
                    "Couldn't create database file '" + databasePath + "'");
            }

            return databasePath;
        }

        private void PopulateDatabase(string databasePath)
        {
            using (var connection = new SQLiteConnection("Data Source=" + databasePath + ";Version=3;"))
            {
                connection.Open();

                string[] createTableStatements = {
                    CREATE_TABLE_WEBSITE
                };

                foreach (var createOneTable in createTableStatements)
                {
                    CreateTable(createOneTable, connection);
                }

                connection.Close();
            }
        }

        private void CreateTable(string query, SQLiteConnection connection, string objectType = "table")
        {
            using (var command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }










        private const string CREATE_TABLE_WEBSITE = @"
CREATE TABLE Website (
  Id INTEGER NOT NULL,
  Name TEXT NOT NULL,
  Url TEXT NOT NULL,
  PRIMARY KEY('Id') 
);";


    }
}
