Console.WriteLine("N\tN^2\tN^3\tN^2 + N^3");

for (var counter = 10; counter < 60; counter += 10)
{
    Console.WriteLine($"{counter}\t{Math.Pow(counter,2)}\t{Math.Pow(counter,3)}\t{Math.Pow(counter,2)+Math.Pow(counter,3)}");
}