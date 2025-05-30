//Commented out when starting on Decision and Iteration Statements segment of tutorial
/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

Console.WriteLine("Please enter your name: ");
string name = Console.ReadLine();

int monthlyWage = 1234;

//variables can be declared on the same line
int months = 12, bonus = 1000;

bool isActive = true;

double rating = 99.25;

//byte is a data type that can hold values from 0 to 255
byte numberOfEmployees = 255;

int hoursWorked;
hoursWorked = 40;

//const is a keyword that defines a constant variable that cannot be changed
const double interestRate = 0.07;

string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";

double ratePerHour = 15.50;
int numberOfHoursWorked = 40;

long veryLongWeek = numberOfHoursWorked;

double currentWeekWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine($"Hello {name}, your monthly wage is {currentWeekWage}.");

ratePerHour += 3;

if (currentWeekWage > 1000)
    Console.WriteLine("You are a high earner.");

numberOfEmployees--;

DateTime hireDate = new DateTime(2025, 03, 28, 14, 30, 00);
//Constructor syntax in year, month, day, hour, minute, second

DateTime exitDate = new DateTime(2075, 03, 28);

DateTime startDate = hireDate.AddDays(15);
Console.WriteLine(startDate);

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 0, 0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine(startHour.ToLongDateString());
Console.WriteLine(endHour.ToShortDateString());

Console.ReadLine();

*/

//int age = 23;

//bool a = age == 23;

//Console.WriteLine("Age is 23: " + a);

//bool b = age >= 23;
//Console.WriteLine("Age is greater than or equal to 23: " + b);

//bool c = (age >= 18) && (age <= 65);
//Console.WriteLine("Age is between 18 and 65: " + c);

//Console.WriteLine("Enter the age of the new candidate: ");
//int age = int.Parse(Console.ReadLine());

//if (age < 18)
//{
//    Console.WriteLine("Candidate is too young.");
//}
//else if (age <= 65)
//{
//    Console.WriteLine("Candidate is eligible for the job.");
//}
//else
//{
//    Console.WriteLine("Candidate is too old.");
//}

//DateTime today = DateTime.Now;
//bool endOfMonthPaymentStarted = false;

//if(today.Date.Day == 20)
//{
//    Console.WriteLine("Please start end-of-month employee payments.");
//}
//else if(today.Date.Day >= 25 && !endOfMonthPaymentStarted)
//{
//    Console.WriteLine("Payments will be late.");
//}


//switch(age)
//{
//    case < 18:
//        Console.WriteLine("Candidate is too young.");
//        break;
//    case > 65:
//        Console.WriteLine("Candidate is too old.");
//        break;
//    case 23:
//        Console.WriteLine("That is exactly the age we are looking for!");
//        break;
//    default:
//        Console.WriteLine("Great, you can now start with the application!");
//        break;
//}


//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());
//int i = 0;

//while(i < max)
//{
//    Console.WriteLine("Current value: " + i);
//    i++;
//}

//Console.WriteLine("Loop finished. Final value: " + i);


//for(int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        Console.WriteLine("Skipping value 5.");
//        continue; // Skip the rest of the loop for this iteration
//    }

//    if (i == 8)
//    {
//        Console.WriteLine("Breaking at value 8.");
//        break; // Exit the loop entirely
//    }

//    Console.WriteLine("Current value: " + i);
//}

using BethanyPieShopHRM;

int amount = 1234;
int months = 12;

int yearlyWage = Utilities.CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();



