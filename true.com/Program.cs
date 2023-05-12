


using System.Diagnostics.CodeAnalysis;

string websiteName;

Console.WriteLine( "Type your domain" );
websiteName = Console.ReadLine();
string dotCom = ".com";

for (int i = websiteName.Length-4, j = 0; j < dotCom.Length && i < websiteName.Length;j++, i++)


        if (websiteName[i] == dotCom[j])
        {
            while (j==3)
            {

                Console.WriteLine( "Your domain is correct");
                break;  
            }
              continue;

        }

        else

        {
            Console.WriteLine("Incorrect domain");
            break;

        }
    

  


