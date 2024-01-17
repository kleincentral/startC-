// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

// BASE
//  Make a string
//  Make a number (what kind? There are multiple!)
//  Make a boolean
//  Make an if / else if / else block
//  Make a switch block
//  Make an array of strings
//  Make a for loop
//      Log each item
//  Use a foreach loop
//  Use a List instead of an array (HINT)

string myString = "STRINGY!";
int myNumber = 34;
bool myBoolean = true;

if (myNumber < 10)
{
    Console.WriteLine("Number is less than 10", myBoolean);
}
else if (myNumber < 20)
{
    Console.WriteLine("Number is less than 20");
}
else
{
    Console.WriteLine("My number is 20 or higher, its {0:D}", myString);
}

int switchNum = 3;

switch (switchNum)
{
    case 1:
        Console.WriteLine("Woo");
        break;
    case 2:
        Console.WriteLine("Wooer");
        break;
    case 3:
        Console.WriteLine("Wooest");
        break;
    default:
        Console.WriteLine("Wat");
        break;
}

string[] words = { "word1 haha", "word2 hehe", "word3 hoho" };

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("In for loop {0:D}", i);
    // Console.WriteLine(i);
}

foreach (string i in words)
{
    Console.WriteLine(i);
}

List<int> myInts = new List<int>();
myInts.Add(1);
myInts.Add(4);
myInts.Add(3);

for (int i = 0; i < myInts.Count; i++)
{
    Console.WriteLine(myInts[i]);
}

foreach (int i in myInts)
{
    Console.WriteLine("mylist looping:");
    Console.WriteLine(i);
}

// STRETCH
//  Make a class (object structure) its in Program2.cs
//      Instantiate a class (make a new object)
//  Make a method (a function inside a class)
//      Return a value
//      Call from instance of class
//  Make an array of objects
//  Loop over array of objects

Car mycar = new Car("blue", 1992);
Console.WriteLine(mycar.color);
Console.WriteLine(mycar.year);

Console.WriteLine(mycar.AddTwo(22, 3));

Object[,] objects = { { 1, 2 }, { "birds", "houses" }, { true, false } };

foreach (Object i in objects)
{
    Console.WriteLine(i);
}

int[,,] d3object = {
 { { 1, 2 }, { 2, 3 } }, { { 2, 3 }, { 3, 4 } }};

Console.WriteLine(d3object[0, 0, 0]);
Console.WriteLine(d3object[0, 0, 1]);
Console.WriteLine(d3object[0, 1, 1]);
Console.WriteLine(d3object[1, 1, 1]);

foreach (int i in d3object)
{
    Console.WriteLine(i);
}

int[,,,] d4object = {
    {{{1,1}, {1,1}}, {{1,1}, {1,1}}}, {{{2,2}, {2,2}}, {{2,2}, {2,2}}}
};

Console.WriteLine(d4object[0, 0, 0, 0]);

int[,,,,,] d6object = {
    {{{{{1}}}}}
};

// It just lets you make a 6th dimensional array of ints love it