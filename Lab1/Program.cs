using Lab1.Ex1;
using Lab1.Ex2;
using Lab1.Ex3;
/*------EXERCISE 1------*/
Exercise1 obj1, obj2;

obj1 = new Exercise1();
obj2 = new Exercise1();

Console.WriteLine("/*------EXERCISE 1------*/");
Console.WriteLine(obj1);
Console.WriteLine(obj2);
Console.WriteLine("/*----------------------*/");

/*----------------------*/

/*------EXERCISE 2------*/
Console.WriteLine("/*------EXERCISE 2------*/");
var posNum = new PositiveNumber();
try
{
    posNum.Value = 10; // This should work fine
    Console.WriteLine($"PositiveNumber set to: {posNum.Value}");
    posNum.Value = -5; // This should throw an exception
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

// Test for Range
var range = new CustomRange();
try
{
    range.Min = 10; // This should work fine
    range.Max = 90; // This should work fine
    Console.WriteLine($"Range set to: Min = {range.Min}, Max = {range.Max}");

    range.Min = 95; // This should throw an exception because Min > Max
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    range.Max = 85; // This should work fine
    range.Min = 80; // This should work fine
    Console.WriteLine($"Range updated to: Min = {range.Min}, Max = {range.Max}");

    range.Max = 75; // This should throw an exception because Max < Min
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("/*----------------------*/");
/*----------------------*/

/*------EXERCISE 3------*/
Console.WriteLine("/*------EXERCISE 3------*/");
new Trumpet().Play();
Console.WriteLine("/*----------------------*/");
/*----------------------*/
