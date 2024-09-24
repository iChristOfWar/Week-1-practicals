//Task 1: Processing user input

Console.WriteLine("Please enter your name followed by the enter key: ");
string name = Convert.ToString(Console.ReadLine());

Console.WriteLine("Please enter your age followed by the enter key: ");
int age = Convert.ToInt32(Console.ReadLine());

int plus = 5;

int result = (age + plus);

Console.WriteLine("Hello {0}, you will be {1} in 5 years", name, result);

//Task 2: Selection statements

Console.WriteLine("Please enter your age followed by the enter key: ");
int age2 = Convert.ToInt32(Console.ReadLine());
if (age2 < 0 || age > 110)
{
    Console.WriteLine("Not a valid age input.");
}
else if (age2 >= 0 && age2 < 13)
{
    Console.WriteLine("You are a child");
}
{
    if (age2 >= 13 && age2 <= 110)
        Console.WriteLine("You are an adult");
}

//Task 3: Logical operators

Console.WriteLine("Please enter an integer: ");
int eger = Convert.ToInt32(Console.ReadLine());
if (eger < 0)
{
    Console.WriteLine("This is a negative number.");
}
else if (eger >= 0)
{
    Console.WriteLine("This is a positive number");

}

//Task 4: Leap Year Checker

Console.WriteLine("Please enter an integer: ");
int year = Convert.ToInt32(Console.ReadLine());
if (year / 4 == 0 && year / 400 == 0)
{
    Console.WriteLine("{0} is a leap year.", year);
}
else
{
    Console.WriteLine("{0} is not a leap year", year);

    //Task 5: Even or Odd Checker

    Console.WriteLine("Please enter a positive number: ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a == 0)
    {
        Console.WriteLine("Please refresh and enter a number greater than zero");
    }
    {
        if (a <= 0)
            Console.WriteLine("Please rfresh and enter a numebr greater than 0");
    }
    {
        if (a > 0 && a / 2 == 0)
        {
            Console.WriteLine("{0} is an even number", a);
        }
        else
        {
            Console.WriteLine("{0} is an odd number", a);
        };
    }
}