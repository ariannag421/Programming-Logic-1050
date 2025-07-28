/*
  Name: Arianna Garrett
  Title: IT-1050 - Lab 1
*/

// Step 1: Display a greeting message to the user
Console.WriteLine("Welcome to IT-1050 Lab 1!");

// Step 2: Print your name and course title
Console.WriteLine("Name: Arianna Garrett");
Console.WriteLine("Course: IT-1050");

// Step 3: Prompt the user to enter their name
Console.Write("Please enter your name: ");
string userName = Console.ReadLine();

// Step 4: Prompt the user to enter their age and convert it to int
Console.Write("Please enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());

// Step 5: Greet the user personally with fixed name and age
Console.WriteLine("Hello, James! You are 21 years old. Nice to meet you.");

// Step 6: Declare and display variables

// Declare an int variable for your favorite number
int favoriteNumber = 21;
Console.WriteLine("My favorite number is " + favoriteNumber + ".");

// Declare a string variable for your favorite programming language
string favoriteLanguage = "C#";
Console.WriteLine("My favorite programming language is " + favoriteLanguage + ".");

// Declare a double variable for the number of programs written
double programsWritten = 5;
Console.WriteLine("I have written " + programsWritten + " programs before this in my IT 2310 class.");

// Declare a bool variable for programming experience
bool hasExperience = true;
Console.WriteLine("Do I have programming experience? " + hasExperience);

// Step 7: Declare and display a constant string for your school name
const string schoolName = "Cuyahoga Community College";
Console.WriteLine("School Name: " + schoolName);

// Step 8: Demonstrate casting and Convert class usage

// Create a double variable with decimal places
double doubleValue = 9.78;
Console.WriteLine("double: " + doubleValue);

// Explicitly cast the double to an int (this will truncate the decimal part)
int intFromDouble = (int)doubleValue;
Console.WriteLine("int (from double): " + intFromDouble);

// Convert int to string using Convert class
string intToString = Convert.ToString(intFromDouble);
Console.WriteLine("int to string: " + intToString);

// Convert bool to string using Convert class
string boolToString = Convert.ToString(hasExperience);
Console.WriteLine("bool to string: " + boolToString);

// Step 9: Arithmetic operations starting at 0
int value = 0;
Console.WriteLine("\nStarting value: " + value);

value = value + 10;
Console.WriteLine("After addition (0 + 10): " + value);

value = value - 2;
Console.WriteLine("After subtraction (10 - 2): " + value);

value = value * 3;
Console.WriteLine("After multiplication (8 * 3): " + value);

value = value / 2;
Console.WriteLine("After division (24 / 2): " + value);

value = value % 2;
Console.WriteLine("After modulus (12 % 2): " + value);

// Step 10: Increment and decrement operations

// Declare int variable for increment/decrement demo
int number = 10;
Console.WriteLine("\nInitial number value: " + number);

// Increment the value by 1
number++;
Console.WriteLine("After increment (++): " + number);

// Decrement the value by 1
number--;
Console.WriteLine("After decrement (--): " + number);

// Step 11: Demonstrate difference in precision between float and double

// Declare a float variable (single precision)
float floatValue = 1.123456789f;

// Declare a double variable (double precision)
double doublePrecisionValue = 1.123456789;

// Print both values
Console.WriteLine("\nFloat value: " + floatValue);
Console.WriteLine("Double value: " + doublePrecisionValue);

// Step 12: End the program with a closing message
Console.WriteLine("\nThank you for a great semester! Goodbye!");
