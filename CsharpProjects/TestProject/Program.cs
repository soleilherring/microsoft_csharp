﻿// Random dice = new Random();

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

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if (daysUntilExpiration == 0) 
{
    Console.WriteLine("Your subscription has expired. ");
}

else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day! Renew now and save 20%");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
    discountPercentage = 10;
}
else if (daysUntilExpiration  <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}");
}