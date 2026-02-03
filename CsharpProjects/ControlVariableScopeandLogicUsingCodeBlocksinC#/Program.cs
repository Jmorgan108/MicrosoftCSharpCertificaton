
////// Unit 4 Challenge

int[] numbers = { 4, 8, 15, 16, 23, 42 };

var found = false;
var total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");


Console.WriteLine($"Total: {total}");


////// Unit 3

// bool flag = true;
// if (flag)
//     Console.WriteLine(flag);

// bool flag = true;
// if (flag) Console.WriteLine(flag);

// // string name = "steve";
// // if (name == "bob") Console.WriteLine("Found Bob");
// // else if (name == "steve") Console.WriteLine("Found Steve");
// // else Console.WriteLine("Found Chuck");

// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve")
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");


////// Unit 2 

// bool flag = true;
// int value = 0;

// if (flag)
// {

//     Console.WriteLine($"Inside the code block {value}");
// }

// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

