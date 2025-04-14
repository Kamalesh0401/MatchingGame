using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Windows.Forms;

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
                                                   Score INTEGER NOT NULL,
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

        public void LoadOrCreatePlayerScore(string playerName, string level)
        {
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
                        var result = selectCommand.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            // Player exists, load their score
                            int playerScore = Convert.ToInt32(result);
                            // Update your game UI with the loaded score
                            // Example: scoreLabel.Text = $"Score: {playerScore}";
                        }
                        else
                        {
                            string insertQuery = $"INSERT INTO {PlayersTable} (Name, Score, Level) VALUES (@name, 0, @level)";
                            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, dbConnection))
                            {
                                insertCommand.Parameters.AddWithValue("@name", playerName);
                                insertCommand.Parameters.AddWithValue("@level", level);
                                insertCommand.ExecuteNonQuery();
                                // Initialize the score in your game UI to 0
                                // Example: scoreLabel.Text = "Score: 0";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
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
            int finalScore = 0;
            if (!string.IsNullOrEmpty(_currentPlayerName))
            {
                UpdatePlayerScore(_currentPlayerName, timetoSolve, level);
                // Optionally display a message or update the UI
            }
        }

        public DataTable GetHighScores(int level, int limit = 10)
        {
            DataTable highScoreTable = new DataTable();
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(_connectionString))
                {
                    dbConnection.Open();
                    //string selectQuery = $"SELECT Name, Score FROM {PlayersTable} ORDER BY Score DESC LIMIT @limit";
                    string selectQuery = $"SELECT * FROM Players;";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, dbConnection))
                    {
                        //command.Parameters.AddWithValue("@limit", limit);
                        //command.Parameters.AddWithValue("@level", level);
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(highScoreTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"");
            }
            return highScoreTable;
        }
    }
}
