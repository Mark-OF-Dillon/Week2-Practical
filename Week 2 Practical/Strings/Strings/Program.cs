/* 
Practical 2
Information: Methods Demo
Version 1
Author: Mark Dillon
Date: 01/10/2026
*/

Main();

void Main()
{
    StringCypher();
}

void StringCypher()
{
    Console.WriteLine("Enter a Sentence:");
    String CypherInput = Convert.ToString(Console.ReadLine());
    Console.WriteLine($"The sentence you entered is: {CypherInput}");
    string.Count(CypherInput);
    //Console.WriteLine($"Number of words = {CypherCount}");
}