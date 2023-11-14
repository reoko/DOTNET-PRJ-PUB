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

/*
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
}while(validEntry == false);
*/

/*
If need to convert string value from Console.ReadLine() input to numeric type use int.TryParse()
*/
/*
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);

Console.WriteLine($"validNumber: {validNumber}; readResult: {readResult}; numericValue: {numericValue}");
*/

/*
Code Project 1 - write code that validates integer input
*/

string? strReadResult;
bool bolValidEntry = false;
int intValidInteger = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

do{
    strReadResult = Console.ReadLine();
    if(strReadResult != null)
    {
        bolValidEntry = int.TryParse(strReadResult, out intValidInteger);

        if ((intValidInteger < 5 || intValidInteger > 10) && bolValidEntry == true) 
        {
            Console.WriteLine($"You entered {intValidInteger}. Please enter a number between 5 and 10.");
            bolValidEntry = false;
        }
        else if (intValidInteger >= 5 && intValidInteger <= 10 && bolValidEntry == true) 
        { 
            Console.WriteLine($"Your input value ({intValidInteger}) has been accepted."); 
            bolValidEntry = true; 
            break; 
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
            bolValidEntry = false;
        }
    }
}while(bolValidEntry == false);

