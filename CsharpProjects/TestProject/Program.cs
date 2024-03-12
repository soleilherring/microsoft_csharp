// Random dice = new Random();

// int roll1 = dice.Next(1,7);
// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);

// int total = roll1 + roll2 + roll3; 

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// // if statement practice
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 ==roll3))
// {
//     Console.WriteLine("You rolled Doubles! +2 bonus to total!");
//     total +=2;
// }

// if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total");
//     total+=6;
// }

// if (total >= 15) 
// {
//     Console.WriteLine("You Win!");
// }

// if (total < 15) 
// {
//     Console.WriteLine("Sorry, you lose!");
// }

// if statement 

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Your code goes here
// if (daysUntilExpiration == 0) 
// {
//     Console.WriteLine("Your subscription has expired. ");
// }

// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day! Renew now and save 20%");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration  <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}");
// }

// Calling different kinds of methods .Net
// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// stateless or stateful?
// Random dice = new Random();
// int roll = dice.Next();

// To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.
// When calling a stateless method, you don't need to create a new instance of its class first.
// When calling a stateful method, you need to create an instance of the class, and access the method on the object.
// Use the new operator to create a new instance of a class.
// An instance of a class is called an object.

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50,101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// Discover and Implement a call:

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue) ;

// Console.WriteLine(largerValue);

// // Discover and implement a method call 
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

// store and iterate through sequences of data using Arrays and foreach

// string[] fraudulentOrderIDS = new string[3];

// fraudulentOrderIDS[0] = "A123";
// fraudulentOrderIDS[1] = "B456";
// fraudulentOrderIDS[2] = "C789";

// initialize array:
// string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

// Console.WriteLine($"first {fraudulentOrderIDs[0]}");
// Console.WriteLine($"second {fraudulentOrderIDs[1]}");
// Console.WriteLine($"third {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// foreach
// string[] names = {"Rowena", "Robin", "Bao"};
// foreach (string name in names) 
// {
//     Console.WriteLine(name);
// }

// // how to sum 
// int[] inventory = { 200, 450, 700, 175, 250 };


// int bin = 0;
// int sum = 0;
// foreach (int items in inventory) 
// {
//     sum += items;
//     bin++; //shortcut for bin = bin + 1
//     Console.WriteLine($"Bin {bin} = {items} items in inventory (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");


//Challenge activity for nested iteration and selection statements
// string[] fraudulentOrderIDs = 
// {"B123", 
// "C234", 
// "A345",
// "C15",
// "B177",
// "G3003",
// "C235",
// "B179"};

// string name = "Bob";
// foreach (string id in fraudulentOrderIDs)
// {
//     if (id.StartsWith("B"))
//     {
//         Console.WriteLine($"This ID starts with 'B' {id}");
//     }
// }

// leaving comments

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }
//Block comments use a /* at the beginning of the code and a */ at the end. Using a block comment is the quickest and easiest way to disable three or more lines of code.

//whitespace
// Example 1:
// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;

// // Example 2:
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6; 
//     } 
//     else 
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

/* 
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage) { if (i == 'o') { x++; } }

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");