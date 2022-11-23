using System;

string name;
string input;
int points = 0;
string[] questions = new string[] { "Hej, vad heter du?", "Ungefär hur många miligram protein finns det i 5 mililiter sädesvätska", "Hur länge varar ett average samlag?" };

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