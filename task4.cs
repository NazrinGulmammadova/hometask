﻿int month = 10;
       switch (month)
{
       case 12:
       case 1:
       case 2:
        Console.WriteLine("it is winter");
        break;
       case 3:
       case 4:
       case 5:
        Console.WriteLine("it is spring");
        break;
       case 6:
       case 7:
       case 8:
        Console.WriteLine("it is summer");
        break;
       case 9:
       case 10:
       case 11:
        Console.WriteLine("it is autumn");
        break;
       default:
        Console.WriteLine("this answer is wrong");
        break;
}