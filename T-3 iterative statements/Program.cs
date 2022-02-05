//Brian Cantor
//ISM 4300
//Assignment: T-3 Using Iterative Statments

//Retrieve input value from user and convert to integer
Console.WriteLine("Enter a value between 5 and 200 to see conversions");
    string input = Console.ReadLine();
    int inputValue = int.Parse(input);
//if loop used to determine if value is between 5 and 25, as stated in assignment instructions
if ((inputValue > 5) && (inputValue < 25))
{
    //start every table with o for both CAD and USD
    Console.WriteLine("CAD = 0" + " " + "USD = 0");
    //while loop used to create a table displaying values all the way up to 200 and to never exceed 200
    while (inputValue <= 200)
    {
        double usValue = inputValue * 0.792367;
        Console.WriteLine("CAD =" + inputValue.ToString() + "USD =" + usValue);
        inputValue += 10;
    }
}
else { 
    Console.WriteLine("Enter a valid number"); 
}

