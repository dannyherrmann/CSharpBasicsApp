using CSharpBasicsConsole;

UserInput userInput = new UserInput();

Console.WriteLine("What is your name?");

userInput.Name = Console.ReadLine();

while (String.IsNullOrWhiteSpace(userInput.Name))
{
    Console.WriteLine("Please!! Enter a name: ");
    userInput.Name = Console.ReadLine();
}
Console.Clear();

Console.WriteLine("What is your least favorite day of the week?");

userInput.Day = Console.ReadLine();

while (String.IsNullOrWhiteSpace(userInput.Day))
{
    Console.WriteLine("Please!! Enter your least favorite day of the week: ");
    userInput.Day = Console.ReadLine();
}
Console.Clear();

//I'm making an update in Linux

Console.WriteLine("What is your least favorite school subject?");

userInput.Subject = Console.ReadLine();

while (String.IsNullOrWhiteSpace(userInput.Subject))
{
    Console.WriteLine("Please!! least favorite school subject: ");
    userInput.Subject = Console.ReadLine();
}
Console.Clear();

Console.Write(userInput);

Console.ReadLine();




//string input = "";

//while (input == "" || input.StartsWith("QQ"))
//{
//    Console.Write("Enter your name: ");
//    input = Console.ReadLine();
//}

//Console.WriteLine($"Hello, {input}.");