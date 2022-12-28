
void Array3Symbols(string[] cities, string[] cities2)
{
    int count = 0;
    for (int i = 0; i < cities.Length; i++)
    {
    if(cities[i].Length <= 3)
        {
        cities2[count] = cities[i];
        count++;
        }
    }
}
void PrintArray(string[] cities)
{
    for (int i = 0; i < cities.Length; i++)
    {
        Console.Write($"{cities[i]}, ");
    }
    Console.WriteLine();
}


Console.Clear();

string[] cities = { "Bam", "Bra", "Ami", "Moskow" };
string[] cities2 = new string[cities.Length];
Array3Symbols(cities, cities2);
PrintArray(cities2);