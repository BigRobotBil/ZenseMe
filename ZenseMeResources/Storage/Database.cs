using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace ZenseMe.Lib.Storage
{
    public class Database
    {
        private static SQLiteConnection SQLiteConnection;

        /// <summary>
        /// Connect to the database.  If the database does not exist, create a new one
        /// </summary>
        public void Connect()
        {
            CreateDatabase();

            if (SQLiteConnection == null || SQLiteConnection.State == ConnectionState.Closed)
            {
                try
                {
                    SQLiteConnection = new SQLiteConnection();
                    SQLiteConnection.ConnectionString = "Data Source=Data\\storage.db3;Version=3;Journal Mode=Off;Compress=True;CharSet=UTF8;";
                    SQLiteConnection.Open();
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine("SQLite connect error: " + ex);
                }
                CreateStructure();
            }
        }

        /// <summary>
        /// Verify that the local database directory exists, followed by the database itself
        /// 
        /// If not, create it
        /// </summary>
        public void CreateDatabase()
        {
            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            if (!File.Exists("Data\\storage.db3"))
            {
                SQLiteConnection.CreateFile("Data\\storage.db3");
            }
        }

        /// <summary>
        /// Create the initial structure for storing song information in the database
        /// </summary>
        public void CreateStructure()
        {
            if (SQLiteConnection.GetSchema("Tables").Rows.Count == 0)
            {
                Execute("CREATE TABLE device_tracks ([id] NVARCHAR(30), [persistent_id] NVARCHAR(30) PRIMARY KEY, [filename] TEXT, [name] NVARCHAR(256), [artist] NVARCHAR(256), [album] NVARCHAR(256), [length] INTEGER, [play_count] INTEGER, [play_count_his] INTEGER DEFAULT '0', [date_submitted] NVARCHAR(20) DEFAULT '0', [ignored] INTEGER DEFAULT '0', [device] NVARCHAR(30))");
            }
        }

        /// <summary>
        /// Fetch information from the database
        /// 
        /// If the fetch fails, continue with initialized dataset
        /// </summary>
        /// <param name="sqlQuery">Query to perform</param>
        /// <param name="parameters">Params to fill in for the query</param>
        /// <returns>Dataset matching query information, else a blank dataset</returns>
        public DataSet Fetch(string sqlQuery, params SQLiteParameter[] parameters)
        {
            Connect();
            DataSet fetchedData = new DataSet();

            try
            {
                using (SQLiteTransaction transaction = SQLiteConnection.BeginTransaction())
                {
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Parameters.AddRange(parameters);
                        command.CommandText = sqlQuery;
                        command.Connection = SQLiteConnection;

                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                        {
                            using (SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter))
                            {
                                dataAdapter.Fill(fetchedData);
                                transaction.Commit();
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite fetch error: " + ex);
            }
            return fetchedData;
        }

        public int Execute(string sqlQuery, params SQLiteParameter[] parameters)
        {
            Connect();
            int affectedRows = 0;

            try
            {
                using (SQLiteTransaction transaction = SQLiteConnection.BeginTransaction())
                {
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Parameters.AddRange(parameters);
                        command.CommandText = sqlQuery;
                        command.Connection = SQLiteConnection;

                        affectedRows = command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite execute error: " + ex);
            }
            return affectedRows;
        }
    }
}