namespace HabitLoggerApp;

public class UserInterface
{
    private readonly HabitManager _habitManager = new();

    private string? GetUserInput(string message)
    {
        string? userInput = null;
        while (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine(message);
            userInput = Console.ReadLine();
        }

        return userInput;
    }

    private void DisplayMenu(bool clearConsole = false)
    {
        if (clearConsole)
            Console.Clear();

        Console.WriteLine("Main Menu");
        Console.WriteLine("==========================\n");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1 - View All Habits");
        Console.WriteLine("2 - Create a new habit");
        Console.WriteLine("3 - Edit an existing habit");
        Console.WriteLine("4 - Delete a habit");
        Console.WriteLine("5 - Exit");
    }

    public void Run()
    {
        var appIsRunning = true;
        DisplayMenu(true);

        while (appIsRunning)
        {
            var input = GetUserInput("Enter something: ");
            switch (input)
            {
                case "1":
                    _habitManager.GetAllHabits();
                    break;
                case "2":
                    _habitManager.CreateHabit();
                    break;
                case "3":
                    _habitManager.EditHabit();
                    break;
                case "4":
                    _habitManager.DeleteHabit();
                    break;
                default:
                    appIsRunning = false;
                    break;
            }

            DisplayMenu(false);
        }
    }
}