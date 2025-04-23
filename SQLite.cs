using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WFMatchingGame
{
    public class SQLlite
    {
        private readonly string _base = AppDomain.CurrentDomain.BaseDirectory;
        private readonly string _connectionString;
        private readonly string _dbPath;
        private const string DatabaseFileName = "MatchingGame.sqlite";
        private const string PlayersTable = "Players";

        public SQLlite(object columns)
        {
            //_dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "SQLiteFiles", DatabaseFileName);
            _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SQLiteFiles", DatabaseFileName);
            _connectionString = $"Data Source={_dbPath};Version=3;";

            InitializeDatabase(columns);
        }

        public void InitializeDatabase(object i)
        {
            string dbDirectory = Path.GetDirectoryName(_dbPath);

            if (!Directory.Exists(dbDirectory))
            {
                try
                {
                    Directory.CreateDirectory(dbDirectory);
                    Console.WriteLine($"Database directory created at: {dbDirectory}"); // For debugging
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating database directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!File.Exists(_dbPath))
            {
                try
                {
                    SQLiteConnection.CreateFile(_dbPath);
                    Console.WriteLine($"Database file created at: {_dbPath}");
                    using (SQLiteConnection dbConnection = new SQLiteConnection(_connectionString))
                    {
                        dbConnection.Open();
                        //string createTableQuery = $@"
                        //    CREATE TABLE IF NOT EXISTS {PlayersTable} (
                        //        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        //        Name TEXT NOT NULL,
                        //        Score INTEGER NOT NULL,
                        //        Level INTEGER NOT NULL
                        //    );";

                        string createTableQuery = $@"CREATE TABLE IF NOT EXISTS {PlayersTable} (
                                                   Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                   Name TEXT NOT NULL,
                                                   Score TEXT NOT NULL,
                                                   Level INTEGER NOT NULL
                                                  );";

                        using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, dbConnection))
                        {
                            createTableCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Database file already exists at: {_dbPath}"); // Output the path
                }
            }
        }

        public string LoadOrCreatePlayerScore(string playerName, string level)
        {
            string result = null;
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(_connectionString))
                {
                    dbConnection.Open();
                    string selectQuery = $"SELECT Score FROM {PlayersTable} WHERE Name = @name AND Level = @level;";
                    using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, dbConnection))
                    {
                        selectCommand.Parameters.AddWithValue("@name", playerName);
                        selectCommand.Parameters.AddWithValue("@level", level);
                        var score = selectCommand.ExecuteScalar();

                        if (score != null && score != DBNull.Value)
                        {
                            result = score.ToString();
                            //char[] ch = { ':' };
                            //string[] time = result.ToString().Split(ch);
                            //var score = new TimeSpan(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                        }
                        else
                        {
                            string insertQuery = $"INSERT INTO {PlayersTable} (Name, Score, Level) VALUES (@name, 0, @level)";
                            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, dbConnection))
                            {
                                insertCommand.Parameters.AddWithValue("@name", playerName);
                                insertCommand.Parameters.AddWithValue("@level", level);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public void UpdatePlayerScore(string playerName, string newScore, string level)
        {
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(_connectionString))
                {
                    dbConnection.Open();
                    string updateQuery = $"UPDATE {PlayersTable} SET Score = @score WHERE Name = @name AND Level = @level";
                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, dbConnection))
                    {
                        updateCommand.Parameters.AddWithValue("@score", newScore);
                        updateCommand.Parameters.AddWithValue("@level", level);
                        updateCommand.Parameters.AddWithValue("@name", playerName);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                Console.WriteLine($"");
            }
        }

        public void GameFinished(string _currentPlayerName, string timetoSolve, string level)
        {
            if (!string.IsNullOrEmpty(_currentPlayerName))
            {
                UpdatePlayerScore(_currentPlayerName, timetoSolve, level);
                // Optionally display a message or update the UI
            }
        }

        public DataTable GetHighScores(int level = 1)
        {
            DataTable highScoreTable = new DataTable();
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(_connectionString))
                {
                    dbConnection.Open();
                    string selectQuery = $"SELECT Name, Score,Level FROM {PlayersTable} WHERE Level = @level;";
                    //string selectQuery = $"SELECT Name, Score, Level FROM {PlayersTable};";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, dbConnection))
                    {
                        command.Parameters.AddWithValue("@level", level);
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(highScoreTable);
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"SQLite Error retrieving high scores: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"");
            }
            return highScoreTable;
        }
    }
}
