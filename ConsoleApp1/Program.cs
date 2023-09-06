// See https://aka.ms/new-console-template for more information
Console.WriteLine("INPUT/OUTPUT");
Console.WriteLine("What is your name?");
string myName = Console.ReadLine();
Console.WriteLine("Hello " + myName);
Console.WriteLine("\n");
Console.WriteLine("NUMERIC TYPES");
Console.WriteLine("What is the length of the rectangle");
int lengthRectangle = int.Parse(Console.ReadLine());
Console.WriteLine("Rectangle Length: " + lengthRectangle);
Console.WriteLine("\n");
Console.WriteLine("What is the width of the rectangle?");
int widthRectangle = int.Parse(Console.ReadLine());
Console.WriteLine("Rectangle Width: " + widthRectangle);
Console.WriteLine("\n");
Console.WriteLine("Area of Rectangle: " + widthRectangle * lengthRectangle);
Console.WriteLine("\n");
Console.WriteLine("MORE ON NUMERIC TYPES");
Console.WriteLine("Number of Miles Driven?");
int milesDriven = int.Parse(Console.ReadLine());
Console.WriteLine("\n");
Console.WriteLine("Amount of Gas Consumed?");
int gasConsumed = int.Parse(Console.ReadLine());
Console.WriteLine("\n");
int milesPerGallon = milesDriven / gasConsumed;
Console.WriteLine("\n");
Console.WriteLine("Your miles-per-gallon: " + milesPerGallon + "mpg");
Console.WriteLine("\n");
Console.WriteLine("STRINGS");
string opening = @"Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
Console.WriteLine("What term would you like to search for?");
string searchTerm = Console.ReadLine();
string compSearchTerm = searchTerm.ToLower();
string compOpening = opening.ToLower();

if (compOpening.IndexOf(compSearchTerm, 0) != -1)
{
    Console.Write("true");
}
else
{
    Console.WriteLine("false");
};



