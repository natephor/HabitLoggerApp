using System.Data.SQLite;

namespace HabitLoggerApp;

// using var connection = new SQLiteConnection(connectionString);
// connection.Open();
// var command = connection.CreateCommand();
// command.CommandText = @"CREATE TABLE IF NOT EXISTS habit (
//     Id INTEGER PRIMARY KEY AUTOINCREMENT, 
//     Date TEXT, 
//     Quantity INTEGER)";
// command.ExecuteNonQuery();
//
// connection.Close();

public class HabitManager
{
    private const string ConnectionString = "Data Source=habits.db";

    public void CreateHabit()
    {
        Console.WriteLine("Creating habit");
        // using var connection = new SQLiteConnection(ConnectionString);
    }

    public void EditHabit()
    {
        Console.WriteLine("Editing habit");

        // using var connection = new SQLiteConnection(ConnectionString);
    }

    public void DeleteHabit()
    {
        Console.WriteLine("Deleting habit");

        // using var connection = new SQLiteConnection(ConnectionString);
    }

    public void GetAllHabits()
    {
        Console.WriteLine("Fetching all habits");

        // using var connection = new SQLiteConnection(ConnectionString);
    }
}

public record struct Habit(int Id, string Date, int Quantity);