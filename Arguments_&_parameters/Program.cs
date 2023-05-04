Console.WriteLine("Enter something:");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); // UserInput - argument

static void PrintAnyWord(string anyString) //anyString - parametner
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}