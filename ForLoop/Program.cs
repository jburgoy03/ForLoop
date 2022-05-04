//var total = 0;


//for(var idx = 1; idx <= 50; idx++)
//{
//    if (idx % 5 == 0 || idx % 7 == 0)
//    { total = total + idx; }
//}

//Console.WriteLine(total)



//string[] names = { "Ann", "Bob", "Chris", "Darlene", "Ed" };

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//} ;



//int[] nbrs =
//   { 754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
//187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
//460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
//690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
//435, 643, 809, 874, 906, 620, 328, 369, 426, 561
//};

//var high = 0;
//var low = 500;

//foreach (var nbr in nbrs)
//{
//    if (nbr > high)
//        { high = nbr; }
//    if (nbr < low)
//        { low = nbr; }
//}
//Console.WriteLine($"Highest is {high}; lowest is {low}");  

//var nbr = 1;
//    while(nbr <= 25)
//{
//    var cubic = nbr * nbr * nbr;
//    Console.Write(cubic);
//    nbr += 2;  
//}

//for (var i = 1; i <= 30; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//          { Console.WriteLine("Fizzbuzz"); }
//    else if (i % 3 == 0)
//          { Console.WriteLine("Fizz"); }
//    else if (i % 5 == 0)
//          { Console.WriteLine("Buzz"); }
//    else 
//          { Console.WriteLine(i); };
//}


Console.WriteLine("enter the integer: ");
var answer = Console.ReadLine();
var number = Convert.ToInt32(answer);

while (number != 0)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Even");
    }
   else  Console.WriteLine("ODD");
    
    Console.WriteLine("enter the integer: ");
    answer = Console.ReadLine();
    number = Convert.ToInt32(answer);

}  