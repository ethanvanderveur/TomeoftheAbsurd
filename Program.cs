// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

List<string> textFromFile = File.ReadAllLines("Numbers.txt").ToList();


string number;
string input;
string finalNum = "";
int cutNumber = 10;//how many times it tries to add all of the numbers together before halving it
//phylum
number = "";
Console.WriteLine("Phylum:");
input = Console.ReadLine();
int counterNum = 0;
for (int counter = 0; counter < input.Length; counter++)
{
    number += (int)input[counter];
}
Console.WriteLine(number);
while (number.Length > 1)
{
    int temperNum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        temperNum += int.Parse(number[i].ToString());
    }
    number = temperNum.ToString();
    counterNum++;
    if (counterNum > cutNumber)
    {
        number = (Int32.Parse(number) / 2).ToString();
        counterNum = 0;
    }
}
finalNum += number;
Console.WriteLine(number);
//class
number = "";
Console.WriteLine("Class:");
input = Console.ReadLine();
counterNum = 0;
for (int counter = 0; counter < input.Length; counter++)
{
    number += (int)input[counter];
}
Console.WriteLine(number);
while (number.Length > 1)
{
    int temperNum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        temperNum += int.Parse(number[i].ToString());
    }
    number = temperNum.ToString();
    counterNum++;
    if (counterNum > cutNumber)
    {
        number = (Int32.Parse(number) / 2).ToString();
        counterNum = 0;
    }
}
finalNum += number;
Console.WriteLine(number);
//order
number = "";
Console.WriteLine("Order:");
input = Console.ReadLine();
counterNum = 0;
for (int counter = 0; counter < input.Length; counter++)
{
    number += (int)input[counter];
}
Console.WriteLine(number);
while (number.Length > 1)
{
    int temperNum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        temperNum += int.Parse(number[i].ToString());
    }
    number = temperNum.ToString();
    counterNum++;
    if (counterNum > cutNumber)
    {
        number = (Int32.Parse(number) / 2).ToString();
        counterNum = 0;
    }
}
finalNum += number;
Console.WriteLine(number);
//Family
number = "";
Console.WriteLine("Family:");
input = Console.ReadLine();
counterNum = 0;
for (int counter = 0; counter < input.Length; counter++)
{
    number += (int)input[counter];
}
Console.WriteLine(number);
while (number.Length > 1)
{
    int temperNum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        temperNum += int.Parse(number[i].ToString());
    }
    number = temperNum.ToString();
    counterNum++;
    if (counterNum > cutNumber)
    {
        number = (Int32.Parse(number) / 2).ToString();
        counterNum = 0;
    }
}
finalNum += number;
Console.WriteLine(number);
//Genus
number = "";
Console.WriteLine("Genus:");
input = Console.ReadLine();
counterNum = 0;
for (int counter = 0; counter < input.Length; counter++)
{
    number += (int)input[counter];
}
Console.WriteLine(number);
while (number.Length > 1)
{
    int temperNum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        temperNum += int.Parse(number[i].ToString());
    }
    number = temperNum.ToString();
    counterNum++;
    if (counterNum > cutNumber)
    {
        number = (Int32.Parse(number) / 2).ToString();
        counterNum = 0;
    }
}
finalNum += number;
Console.WriteLine(number);
//Species
number = "";
Console.WriteLine("Species:");
input = Console.ReadLine();
counterNum = 0;
for (int counter = 0; counter < input.Length; counter++)
{
    number += (int)input[counter];
}
Console.WriteLine(number);
while (number.Length > 1)
{
    int temperNum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        temperNum += int.Parse(number[i].ToString());
    }
    number = temperNum.ToString();
    counterNum++;
    if (counterNum > cutNumber)
    {
        number = (Int32.Parse(number) / 2).ToString();
        counterNum = 0;
    }
}
finalNum += number;
Console.WriteLine(number);

foreach (string line in textFromFile)
{
    //Console.WriteLine(line);
}
int l = 0;
while (l < textFromFile.Count)
{
    if (String.Equals(textFromFile[l], finalNum))
    {
        Console.WriteLine("Number exists, adding...");
        int tempFinal = Int32.Parse(finalNum);
        Random random = new Random();
        tempFinal += random.Next(1,10);
        finalNum = tempFinal.ToString();
        l = 0;
    }
    l++;
}
textFromFile.Add(finalNum);
foreach (string line in textFromFile)
{
    Console.WriteLine(line);
}
string[] array = textFromFile.ToArray();
File.WriteAllLines("Numbers.txt", array);
//Console.WriteLine(finalNum);