

using System;
using System.Data.Common;
using System.Runtime.CompilerServices;







Console.WriteLine("Enter your first word");


string word1 = Console.ReadLine();

Console.WriteLine("Enter your second word");
string word2 = Console.ReadLine();

int counter=0;


if (word1.Length== word2.Length)

{

    for (int i = 0; i < word1.Length; i++)
    {
        for (int j = 0;j<word2.Length;j++)

        {
            if (word1[i] == word2[j])

            {

                //Match

                counter++;

                break;


                //counter++;
                // while (counter==word1.Length)
                //{

                //    Console.WriteLine($"Your words: {word1}, {word2} are  anagrams");
                //    break;
                //}


            }
               
            else
            {

                continue;
                
            }


        }

    }


}

    else
    {
     Console.WriteLine($"Your words: {word1}, {word2} are not anagrams");
    }



if (counter == word1.Length)

{

    Console.WriteLine($"Your words: {word1}, {word2} are  anagrams");

}

else

{
    Console.WriteLine($"Your words: {word1}, {word2} are not anagrams");
}





