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
Answer Code
*/
/*
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
        else if (intValidInteger > 5 && intValidInteger < 10 && bolValidEntry == true) 
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
*/

/*
Code Project 1 - write code that validates integer input
Sugested Code
*/
/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();

*/


/*
Code Project 2 - write code that validates string input
Answer Code
*/
/*
string? strReadResult;
bool bolValidEntry = false;

string[] arrStrRoles = {"administrator","manager","user"};

do {
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    strReadResult = Console.ReadLine();

    if (strReadResult != null)
    {
        strReadResult = strReadResult.Trim().ToLower();

        bool bolFound = Array.Exists(arrStrRoles, delegate(string strRole)
        {
            return strRole.Equals(strReadResult, StringComparison.OrdinalIgnoreCase);
        });

        strReadResult = char.ToUpper(strReadResult[0]) + strReadResult.Substring(1);

        if (bolFound)
        {
            strReadResult = "Your input value (" + strReadResult + ") has been accepted.";
            bolValidEntry = true;
        }
        else
        {
            strReadResult = "The role name that you entered, \"" + strReadResult + "\" is not valid.";
        }

        Console.WriteLine(strReadResult);
    }
} while(bolValidEntry == false);
*/

/*
Code Project 2 - write code that validates string input
Proposed Posible Code Solution
*/
/*
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
*/


/*
Code Project 3 - Write code that processes the contents of a string array.
Answer Code
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    
    if (periodLocation > 0)
    {
        int intStartPosition = 0;
        int intEndPosition = 0;
        string strCurrentString = myString;
        string strDisplayString = "";
        string strTrimString = "";
        string strCleanString = "";

        do
        {
            intEndPosition = strCurrentString.IndexOf(".");

            strDisplayString = strCurrentString.Substring(intStartPosition,intEndPosition);
            strTrimString = strCurrentString.Remove(intStartPosition,intEndPosition);
            strCleanString = strTrimString.TrimStart('.',' ');
            strCurrentString = strCleanString;
            intEndPosition = strCurrentString.IndexOf(".");

            Console.WriteLine($"{strDisplayString}");

            if(intEndPosition < 0)
            {
                Console.WriteLine($"{strCurrentString}");
            }
        }
        while(intEndPosition > 0);
    }
    else
    {
        Console.WriteLine($"{myString}");
    }
}


/*
Code Project 3 - Write code that processes the contents of a string array.
Proposed Posible Code Solution
*/
/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/