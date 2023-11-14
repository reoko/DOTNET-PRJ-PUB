/*
Manage user input during this Challenge
*/

/*
string? readResult;

Console.WriteLine("Enter a string:");

do{
    readResult = Console.ReadLine();
}while(readResult == null);
*/


/*
The Boolean expression evaluated by the while statement can be used to ensure input meets a specified requirement. For example, if a prompt asks the user to enter a string that includes at least three characters, the following code could be used:
*/

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);