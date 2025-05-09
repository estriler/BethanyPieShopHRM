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

double currentWeekWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine($"Hello {name}, your monthly wage is {currentWeekWage}.");

ratePerHour += 3;

if (currentWeekWage > 1000)
    Console.WriteLine("You are a high earner.");

numberOfEmployees--;


