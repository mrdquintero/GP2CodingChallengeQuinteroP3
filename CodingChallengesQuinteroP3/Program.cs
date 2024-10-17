using System;

class Challenges
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different funtions you will \nhave to choose from. Please pick one");

        Console.WriteLine("Today we are going to use the number adder function called SUM. Please input two numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a 2nd number");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);


        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to:" + Sum(number1int, number2int));

        Console.WriteLine("Lets try converting minutes to seconds.\nGive me a number to convert from minutes to seconds");

        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);

        Console.WriteLine(number3 + " Minutes converted to seconds is: " + Convert(number3int) + " seconds");
    }


    public static int Sum(int number1, int number2)
    { 
        return number1 + number2; 
    }

    public static int Convert(int number)
    {
        return number * 60;
    }



}
