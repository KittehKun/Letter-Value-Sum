//The purpose of this challenge is to assign every letter of the alphabet a value from 1 to 26. When typing a word, phrase, etc, the value of each character is added together. If the character is not a letter such as a number, the value is ignored.
//For example, the word hello would have a value of 52 because h is 8, e is 5, l is 12, and o is 15. The word HELLO would also have a value of 52 because the letters are the same, only the case is different. This is case sensitive so the word Hello would have a value of 37.
//The challenge is to write a program that determines the value of a word or phrase entered as input.

using Letter_Value_Sum;

Console.WriteLine("Enter a word or phrase to get the value of each letter added together:");
string input = Console.ReadLine()!.ToLower();

int sum = 0;
foreach (char letter in input)
{
    sum += Alphabet.GetLetterValue(letter);
}

Console.WriteLine($"\nSum of your input '{input}' is {sum}");