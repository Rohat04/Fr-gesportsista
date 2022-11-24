using System;

string name;
string input;
int points = 0;
string[] questions = new string[] { "Hej, vad heter du?", "Ungefär hur många miligram protein finns det i 5 mililiter spärma", "Hur länge varar ett average samlag?" };

Console.WriteLine(questions[0]);
name = Console.ReadLine();
Console.WriteLine($"Wow, vilket vackert och poetiskt namn du har, {name}!");
Console.WriteLine($"Är {name} speciel enligt dina beräkningar?");

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
