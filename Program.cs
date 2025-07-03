//1. Comment
//Annette Hawks 
//7/2/2025
//CS 1405 Pig Latin/ Encoder
// 2. Greeting
        Console.WriteLine("Pig Latin Converter and Encoder");

        // 3. Collect a string.
        Console.Write("Please enter a message: ");
        string message = Console.ReadLine();
        





        
// Pig Latin Method
static string PigLatin(string word)
{
    string vowels = "aeiou";
    word = word.ToLower(); // make everything lowercase so I don't have to worry about capitalization. 

    int index = 0;

    // Find the index of the first vowel
    while (index < word.Length && !vowels.Contains(word[index]))
    {
        index++;
    }

    string pigLatinWord;

    if (index == 0)
        pigLatinWord = word + "way";      // Starts with a vowel
    else
        pigLatinWord = word.Substring(index) + word.Substring(0, index) + "ay"; // Consonant start

    return pigLatinWord;
}
