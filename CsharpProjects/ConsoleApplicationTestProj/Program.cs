
/// Decision logic Challenge 
string permission = "Admin|Manager";
int level = 55;

permission = "Dog";
level = 20;


if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin User.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin User.");
}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (permission.Contains("Manager") && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else if (!permission.Contains("Admin") || !permission.Contains("Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");

}

//// Probably a better solution 


// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }



////////// NOTES 
/// 
/// 
/// 
/// 
/// 
// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

////////////////////////////////////////////

// Random rand = new();
// int[] coin = [1, 2];
// int result = rand.Next(coin.Length);
// Console.WriteLine($"Coin Flip Result: {(result == 1 ? "Heads" : "Tails")}");

/////////////////// Better solution would have been 

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

