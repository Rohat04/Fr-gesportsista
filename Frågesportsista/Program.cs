using System;

string name;
string input;
int points = 0;
string[] questions = new string[] { "Hej, vad heter du?", "Ungefär hur många miligram protein finns det i 5 mililiter spärma", "Hur länge varar ett average samlag?" };

Console.WriteLine(questions[0]);
name = Console.ReadLine();
Console.WriteLine($"Wow, vilket fult och vidrigt namn du har, {name}!");
Console.WriteLine($"{name}, Jag hoppas en giraff biter dig!");

input = Console.ReadLine();

if (input == "ja") 
{
    Console.WriteLine("KORREKT!");
    points += 1;

}

else if (input == "nej")
{
    Console.WriteLine("FEL!, du får ett försök till...");
    input = Console.ReadLine();
}

Console.WriteLine(questions[1]);
string answer = "";

bool validAnswer = false;

while (!validAnswer)
{
    Console.WriteLine("Välj 252mg eller 534mg");

    answer = Console.ReadLine();

    validAnswer = answer == "252mg" || answer == "252" || answer == "534mg" || answer == "534";

    if (!validAnswer)
    {
        Console.WriteLine("Du måste välja 252mg eller 534mg");
    }
}

if (answer == "252mg" || answer == "252")
{
    Console.WriteLine("Korrekt");
    points += 1;
}
else if (answer == "534mg" || answer == "534")
{
    Console.WriteLine("Fel");
}
Question3();

void Question3()
{
    Console.WriteLine(questions[2]);
    string answer2 = "";

    bool validAnswer2 = false;

    while (!validAnswer2)
{
        Console.WriteLine("3-15 minuter eller 10-30 minuter");

        answer2 = Console.ReadLine();

        validAnswer2 = answer2 == "3-15" || answer2 == "3-15minuter" || answer2 == "10-30" || answer2 == "10-30minuter";
 if (!validAnswer2)
        {
            Console.WriteLine("Du måste välja 3-15 eller 10-30");
        }
}
        if (answer2 == "3-15" || answer2 == "3-15minuter")
    {
        Console.WriteLine("Korrekt");
        points += 1;
    }
    else if (answer2 == "10-30" || answer2 == "10-30minuter")
{
       Console.WriteLine("Fel");
    }
}

Console.WriteLine($"Du fick {points}/{questions.Length} poäng");
Console.ReadLine();