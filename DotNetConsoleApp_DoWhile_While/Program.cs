/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/
using System;

int intHealthPointHero = 10;
int intHealthPointMonster = 10;

Random random = new Random();

string strPlayerType = "";
string strAttackAlternator = "";

bool bolConfirmationToContinue = true;
string strConfirmationToContinue = "";
string strUserSelectedCharacter = "";

do
{
    if (strUserSelectedCharacter == "")
    {
        Console.Clear();
        Console.WriteLine("Enter character selection:\nH - Hero\nM - Monter\nE - Exit");
        Console.Write("Please Select a Character: ");
        strUserSelectedCharacter = Console.ReadLine();

        strUserSelectedCharacter = strUserSelectedCharacter.Trim().ToUpper();

        switch (strUserSelectedCharacter)
        {
            case "H":
                strPlayerType = "Hero";
                break;
            case "M":
                strPlayerType = "Monster";
                break;
            case "E":
                bolConfirmationToContinue = false;
                strPlayerType = "Exit";
                break;
            default:
                Console.Write("You entered a wrong option.\n Would you like to continue the game (Y, N):");
                strConfirmationToContinue = Console.ReadLine();
                strConfirmationToContinue = strConfirmationToContinue.Trim().ToUpper();

                bolConfirmationToContinue = strConfirmationToContinue == "Y" ? true : false;
                if (bolConfirmationToContinue == false) strPlayerType = "Exit";
                break;
        }
    }

    if(strPlayerType == "Exit")
    {
        Console.Write("Exit Game.");
        bolConfirmationToContinue = false;
        break;
    }
    else if (strPlayerType == "Hero" || strPlayerType == "Monster")
    {
        Console.Write($"Welcome! You will play as a {strPlayerType} in this game.\n");

        while (intHealthPointHero > 0 && intHealthPointMonster > 0)
        {
            if (strPlayerType == "Hero" && strAttackAlternator == "")
            {
                int roll = random.Next(1, 11);

                if(roll > intHealthPointMonster) roll = intHealthPointMonster;

                intHealthPointMonster = intHealthPointMonster - roll;
                
                Console.Write($"Monster was damaged and lost {roll} health and now has {intHealthPointMonster} health.\n");

                strAttackAlternator = "Monster";
            }
            else if (strPlayerType == "Monster" && strAttackAlternator == "") 
            {
                int roll = random.Next(1, 11);
                
                if(roll > intHealthPointHero) roll = intHealthPointHero;

                intHealthPointHero = intHealthPointHero - roll;
                
                Console.Write($"Hero was damaged and lost {roll} health and now has {intHealthPointHero} health.\n");

                strAttackAlternator = "Hero";
            }
            else
            {
                if (strAttackAlternator == "Hero")
                {
                    int roll = random.Next(1, 11);

                    if(roll > intHealthPointMonster) roll = intHealthPointMonster;

                    intHealthPointMonster = intHealthPointMonster - roll;
                    
                    Console.Write($"Monster was damaged and lost {roll} health and now has {intHealthPointMonster} health.\n");

                    strAttackAlternator = "Monster";
                }
                else
                {
                    int roll = random.Next(1, 11);
                    
                    if(roll > intHealthPointHero) roll = intHealthPointHero;

                    intHealthPointHero = intHealthPointHero - roll;
                    
                    Console.Write($"Hero was damaged and lost {roll} health and now has {intHealthPointHero} health.\n");

                    strAttackAlternator = "Hero";
                }
            }
        }

        if ((intHealthPointHero == 0) || (intHealthPointMonster == 0))
        {
            if (intHealthPointHero > intHealthPointMonster) Console.WriteLine("Hero wins!");
            else Console.WriteLine("Monster wins!");

            break;
        }
    }
    else
    {
        Console.Write("You entered a wrong option.\n Would you like to continue the game (Y, N):");
        strConfirmationToContinue = Console.ReadLine();
        strConfirmationToContinue = strConfirmationToContinue.Trim().ToUpper();
        bolConfirmationToContinue = strConfirmationToContinue == "Y" ? true : false;
    }
}while(bolConfirmationToContinue);
