namespace To_DoList;

internal class TodoList
{
    private static void Main() {
        List<string> toDoList = new List<string>();

        Console.WriteLine("Welcome to Kian's First Project in C#: A to-do list.");
        Console.WriteLine();

        bool continueLoop = true;

        while (continueLoop) {
            PrintMainLoopOption();
            Console.WriteLine();

            Console.Write("Select an option: ");
            string selection = Console.ReadLine().ToLower();

            if (selection == "q") {
                QuitLoop();
                continueLoop = false;
            }
            else if (selection == "a") {
                AddTask(toDoList);
                Console.WriteLine();
                DisplayToDoList(toDoList);
                Console.WriteLine();
            }
            else if (selection == "r") {
                RemoveTask(toDoList);
                Console.WriteLine();
            }
            else if (selection == "v") {
                DisplayToDoList(toDoList);
                Console.WriteLine();
            }
            else {
                Console.WriteLine($"{selection} is an invalid selection. Please try again.");
                Console.WriteLine();
            }
        }
    }


    private static void QuitLoop() {
        Console.WriteLine("Quitting...");
    }


    private static void AddTask(List<string> toDoList) {
        Console.Write("What task would you like to add: ");
        string task = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(task)) {
            Console.WriteLine("You must enter a task. Did not add any task to list.");
        }
        else {
            toDoList.Add(task);
            Console.WriteLine($"Successfully added task: {task}");
        }
    }


    private static void RemoveTask(List<string> toDoList) {
        DisplayToDoList(toDoList);

        if (toDoList.Count == 0) {
            Console.WriteLine("You cannot remove a task if you do not have todo's yet.");
        }
        else {
            int toDoListSize = toDoList.Count;

            Console.WriteLine();
            Console.Write("What task number would you like to remove: ");
            string input = Console.ReadLine();

            // Remove #(input - 1) so the user can enter 1, and it removes 0 from list
            int indexToRemove = int.Parse(input) - 1;

            if (indexToRemove > 0 && indexToRemove < toDoListSize) {
                string task = toDoList[indexToRemove];

                toDoList.RemoveAt(indexToRemove);

                Console.WriteLine($"Successfully removed task: {task}");
            }
            else {
                Console.WriteLine("That is an invalid number to remove.");
            }
        }
    }


    private static void DisplayToDoList(List<string> toDoList) {
        Console.WriteLine("Current todo list: ");

        if (toDoList.Count == 0) {
            Console.WriteLine("No tasks yet!");
        }
        else {
            for (int i = 0; i < toDoList.Count; i++) {
                Console.WriteLine($"{i + 1}. {toDoList[i]}");
            }
        }
    }


    private static void PrintMainLoopOption() {
        Console.WriteLine("(a)dd a task");
        Console.WriteLine("(r)emove a task");
        Console.WriteLine("(v)iew list");
        Console.WriteLine("(q)uit");
    }
}
