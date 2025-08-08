Console.WriteLine("Hello welcome to todo list");

static void ShowNoTodosMessage()
{
    Console.WriteLine("No Todos List available");
}

var shallExit = false;
var todos = new List<string>();
while (!shallExit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a Todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "E":
        case "e":
            shallExit = true;
            Console.WriteLine("Exit");
            break;
        case "R":
        case "r":
            RemoveTodo();
            Console.WriteLine("Remove a todo");
            break;
        case "A":
        case "a":
            AddTodo();
            Console.WriteLine("add a todo");
            break;
        case "S":
        case "s":
            SeeAllTodos();
            Console.WriteLine("see all todos");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}

void AddTodo()
{
    var isValidDescription = false;
    while (!isValidDescription)
    {
        Console.WriteLine("Enter the todo you want to add");
        var description = Console.ReadLine();
        if (description == "")
        {
            Console.WriteLine("Description cant be empty");
        }
        else if (todos.Contains(description))
        {
            Console.WriteLine("Description miust be unique");
        }
        else
        {
            isValidDescription = true;
            todos.Add(description);
        }
    }

}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
    }
    else
    {
        for (var i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todos[i]}");
        }
    }
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    var isIndexValid = false;
    while (!isIndexValid)
    {
        Console.WriteLine("Enter the index of the todo you want to remove");
        SeeAllTodos();
        var userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine("select the index. Index cannot be empty");
            continue;
        }
        if (int.TryParse(userInput, out int index))
        {
            if (index <= 0 || index > todos.Count)
            {
                Console.WriteLine("select the correct index");
            }
            else
            {
                var todoIndex = index - 1;
                var todoRemoved = todos[todoIndex];
                todos.RemoveAt(todoIndex);
                isIndexValid = true;
                Console.WriteLine($"{todoRemoved} is removed in todos list");

            }
        }

    }



}