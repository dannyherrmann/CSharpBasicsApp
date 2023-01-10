Console.WriteLine("What is your name?");

string? name = Console.ReadLine();

while (String.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Please!! Enter a name: ");
    name = Console.ReadLine();
}
Console.Clear();

Console.WriteLine("What is your least favorite day of the week?");

string? day = Console.ReadLine();

while (String.IsNullOrWhiteSpace(day))
{
    Console.WriteLine("Please!! Enter your least favorite day of the week: ");
    day = Console.ReadLine();
}
Console.Clear();

Console.WriteLine("What is your least favorite school subject?");

string? subject = Console.ReadLine();

while (String.IsNullOrWhiteSpace(subject))
{
    Console.WriteLine("Please!! least favorite school subject: ");
    subject = Console.ReadLine();
}
Console.Clear();


string displayText = @$"
Name: {name}
Favorite Day of the Week: {day}
Least Favorite School Subject: {subject}";

Console.WriteLine(displayText);

Console.ReadLine();




//string input = "";

//while (input == "" || input.StartsWith("QQ"))
//{
//    Console.Write("Enter your name: ");
//    input = Console.ReadLine();
//}

//Console.WriteLine($"Hello, {input}.");