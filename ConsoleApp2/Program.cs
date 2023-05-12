// See https://aka.ms/new-console-template for more information




using System.ComponentModel;

string word;

bool isnot = true;

Console.WriteLine("Enter your word");

word = Console.ReadLine();

for (int i = 0; i < word.Length; i++)


{

    if (word[i] == word[word.Length - i - 1])

    {
        continue;

    }
    else
    {
        isnot = false;

    }
}

 if (isnot==false)
    {
    Console.WriteLine($"Your word: {word} is not polindrome");
}
 else
    {
    Console.WriteLine($"Your word: {word} is polindrome");
    }







