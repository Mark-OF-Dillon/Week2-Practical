/* 
Practical 2
Information: Methods Demo
Version 1
Author: Mark Dillon
Date: 01/10/2026
*/

using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

Main();

void Main()
{
    int option;
    do
    {

        PrintMenu();
        option = GetOption();

        string message = GetMessage(option);
        Console.WriteLine($"\n{message}\n");

    } while (option != 0);
}

void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:\n" +
        "1. Hello in French?\n" +
        "2. Hello in Spanish?\n" +
        "3. Hello in German?\n" +
        "4. Hello in Italian?\n" +
        "0. Exit Application");
}

// Task 2
int GetOption()
{
    int option = 0;

    try
    {
        option = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("\n[Error] Invalid format: Please enter a number");
    }
    catch (Exception ex)
    {
        Console.WriteLine("\n[Error] Please enter a number: {ex.Message}");
    }

    return option;
}

// Task 3
string GetMessage(int option)
{
    switch (option)
    {
        case 0:
            return "Goodbye";
        case 1:
            return "Bonjour";
        case 2:
            return "Hola";
        case 3:
            return "Hallo";
        case 4:
            return "Ciao";
        default:
            return "Please enter a valid option";
    }
}