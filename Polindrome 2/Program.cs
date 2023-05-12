


using System.Diagnostics.CodeAnalysis;

string word;



Console.WriteLine("Enter your word");

word = Console.ReadLine();

for (int i = 0,y=word.Length-1; i < word.Length || y==0; i++,y--)
{

    if (word[i] == word[y])
    {
       

        while (y==0 && i<word.Length)
        {
            Console.WriteLine($"Your word:{word} is  polindrome ");
            break;
        }

        continue;

    }

    else
    {
        Console.WriteLine($"Your word:{word} is not polindrome ");
        break;

     }
}

