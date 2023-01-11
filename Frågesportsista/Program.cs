using System;

//För namn registreringen
string name;
int points = 0;
//Alla frågor bakom "," (Komma tecken) är registrerade frågor
string[] questions = new string[] { "Hej, vad heter du?", "Ungefär hur många miligram protein finns det i 5 mililiter spärma", "Hur många barn har Rohat?", "Hur länge varar ett average samlag?", };

Console.WriteLine(questions[0]);
name = Console.ReadLine();

//Sparar namnet du skrev och använder det för att förolämpa dig
Console.WriteLine($"Wow, vilket fult och vidrigt namn du har, {name}!");
Console.WriteLine($"{name}, jag hoppas en giraff biter dig!");

Console.ReadLine();

//Fråga ett
Console.WriteLine(questions[1]);
string answer = "";

bool validAnswer = false;

while (!validAnswer)
{
    Console.WriteLine("Välj 252mg eller 534mg");

    answer = Console.ReadLine();
    //Fler alternativ för vad som accepteras som svar
    validAnswer = answer == "252mg" || answer == "252" || answer == "252 mg" || answer == "534mg" || answer == "534" || answer == "534 mg";

    if (!validAnswer)
    {
        Console.WriteLine("Du måste välja 252mg eller 534mg");
    }
}
//Vad som accepteras som korrekt och fel
if (answer == "252mg" || answer == "252" || answer == "252 mg")
{
    Console.WriteLine("Korrekt");
    points += 1;
}
else if (answer == "534mg" || answer == "534" || answer == "534 mg")
{
    Console.WriteLine("Fel");
}

Console.WriteLine(questions[2]);
string answer2 = "";

bool validAnswer2 = false;

while (!validAnswer2)
{
    Console.WriteLine("4 eller 0?");

    answer2 = Console.ReadLine();
    //Fler alternativ för vad som accepteras som svar
    validAnswer2 = answer2 == "4" || answer2 == "0";

    if (!validAnswer2)
    {
        Console.WriteLine("Du måste välja mellan för många eller 0");
    }
}
//Vad som accepteras som korrekt och fel
if (answer2 == "För många")
{
    Console.WriteLine("Korrekt");
    points += 1;
}
else if (answer2 == "0" || answer2 == "3,5" || answer2 == "22")
{
    Console.WriteLine("Fel");
}

Question3();
void Question3()
{
    Console.WriteLine(questions[3]);
    string answer3 = "";

    bool validAnswer3 = false;

    while (!validAnswer3)
    {
        Console.WriteLine("3-15 minuter eller 10-30 minuter");

        answer3 = Console.ReadLine();

        validAnswer3 = answer3 == "3-15" || answer3 == "3-15minuter" || answer3 == "3-15 minuter" || answer3 == "3-15 min" || answer3 == "10-30" || answer3 == "10-30min" || answer3 == "10-30minuter" || answer3 == "10-30 minuter" || answer3 == "10-30 min";
        if (!validAnswer3)
        {
            Console.WriteLine("Du måste välja 3-15 eller 10-30");
        }
    }
    if (answer3 == "3-15" || answer3 == "3-15min" || answer3 == "3-15 min" || answer3 == "3-15minuter" || answer3 == "3-15 minuter")
    {
        Console.WriteLine("Korrekt");
        points += 1;
    }
    else if (answer3 == "10-30" || answer3 == "10-30min" || answer3 == "10-30minuter" || answer3 == "10-30 min" || answer3 == "10-30 minuter")
    {
        Console.WriteLine("Fel");
    }
}
//
Console.WriteLine($"Du, {name}, fick {points}/{questions.Length} poäng");
Console.ReadLine();