using System.ComponentModel.Design;
using System.Net.Security;

Main();

void Main()
{
    //Task5();
    //Task6();
    //Task7();
    //Task8();
}

void Task5()
{
    //Task 5
    Console.Write("Enter a string!:\n");
    string str = Console.ReadLine();

    Console.WriteLine($"The sentence you inputted is: {str}");

    //Count uppercase
    int wordCount = 0;

    foreach (char c in str)
    {
        if (char.IsUpper(c))
        {
            wordCount++;
        }
    }

    Console.WriteLine($"Number of words = {wordCount}");
}

void Task6()
{
    Console.WriteLine("Enter a string!:\n");
    string str = Console.ReadLine();

    Console.WriteLine("\nEnter number of rotations:\n");
    int rotations = Convert.ToInt32(Console.ReadLine());

    string encrypted = Encrypt(str, rotations);

    Console.WriteLine($"\nThe sentence you inputted is: {str}");
    Console.WriteLine($"The encrypted sentence is now: {encrypted}");

}

//Helper method for encrypting
string Encrypt(string str, int key)
{
    char[] number = str.ToCharArray();

    for (int i = 0; i < number.Length; i++)
    {
        char c = number[i];

        if (char.IsUpper(c))
        {
            number[i] = (char)('A' + (c - 'A' + key) % 26);
        }
        else if (char.IsLower(c))
        {
            number[i] = (char)('a' + (c - 'a' + key) % 26);
        }
    }
    return new string(number);
}

void Task7()
{
    Console.WriteLine("Enter a string you wish to decrypt:\n");
    string str = Console.ReadLine();

    Console.Write("\nEnter number of rotations:\n");
    int rotations = Convert.ToInt32(Console.ReadLine());

    string decrypted = decrypt(str, rotations);

    Console.WriteLine($"\nThe sentence you inputted is: {str}");
    Console.WriteLine($"\nThe decrypted sentence is now: {decrypted}");
}

//Helper method for decrypting
string decrypt(string input, int key)
{
    return Encrypt(input, 26 - (key % 26));
}

void Task8()
{
    while (true)
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1 - Encrypt Text");
        Console.WriteLine("2 - Decrypt Text");
        Console.WriteLine("0 - End");

        string choice = Console.ReadLine();

        //IF Statement
        if (choice == "1")
        {
            Task6();
        }
        else if (choice == "2")
        {
            Task7();
        }
        else if (choice == "0")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("\nInvalid Option.");
        }

    }
}