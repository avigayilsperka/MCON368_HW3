/*
 * Avigayil Sperka
 * T00386137
 * HW3 Extra Credit
 */

//collect length of rectangle 
Console.WriteLine("Enter the length of the rectangle:");
var length = Int64.Parse(Console.ReadLine());

//validate length
if (length < 1)
{
    length = 1;
}

if (length > 15)
{
    length = 15;
}

//collect width of rectangle
Console.WriteLine("Enter the width of the rectangle:");
var width = Int64.Parse(Console.ReadLine());

//validate width
if (width < 1)
{
    width = 1;
}

if (width > 10)
{
    width = 10;
}

//loop to display rectangle
for (var i = 0; i < width; i++)
{
    for (var j = 0; j < length; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}