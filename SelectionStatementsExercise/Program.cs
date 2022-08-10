// See https://aka.ms/new-console-template for more information
//Exercise1

//var r = new Random();
//var favNumber = r.Next(1, 1000);


//Console.WriteLine("Try to guess my favorite number");
//var userInput = int.Parse(Console.ReadLine());

//if(userInput < favNumber)
//{
//    Console.WriteLine($"{userInput} is too low");

//}
//else if(userInput > favNumber)
//{
//    Console.WriteLine($"{userInput} is too high");
//}
//else
//{
//    Console.WriteLine("You guessed it!");
//}

//Exercise 2

Console.WriteLine("What is your favorite subject?");

string subject = Console.ReadLine();

switch (subject.ToLower())
{
    case "english":
    case "literature":
        Console.WriteLine("I hate English!");
        break;
    case "math":
        Console.WriteLine("Math is hard");
        break;
    case "science":
    case "biology":
    case "chemistry":
        Console.WriteLine("Science can be fun!");
        break;
    case "pe":
        Console.WriteLine("PE is a blast!");
        break;
    case "history":
        Console.WriteLine("History is boring.");
        break;
        default: Console.WriteLine("I don't know that subject");
        break;
}