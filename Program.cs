//1. Comment
//Annette Hawks 
//7/2/2025
//CS 1405 Pig Latin/ Encoder
// 2. Greeting
Console.WriteLine("Pig Latin Converter and Encoder");

// 3. Collect a string.
Console.Write("Please enter a message: ");
string message = Console.ReadLine();

// 4. Convert each word into Pig Latin
string[] words = message.Split(' ', StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < words.Length; i++)
{
    words[i] = PigLatin(words[i]);
}

string pigLatin = string.Join(" ", words);

// 5. Print the phrase in Pig Latin
Console.WriteLine($"\nPig latin: {pigLatin}");

// 6. Get an offset (set to 3)
int shift = 3;
string encoded = EncodeShift(pigLatin, shift);
Console.WriteLine($"\nEncoded (shift {shift}): {encoded}");

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
//Encoder Method
static string EncodeShift(string message, int shift)
{
    string result = "";

    foreach (char letter in message)
    {
        if (char.IsLetter(letter))
        {
            char shifted = (char)((((letter - 'a') + shift) % 26) + 'a');
            result += shifted;
        }
        else
        {
            result += letter;
        }
    }

    return result;
}