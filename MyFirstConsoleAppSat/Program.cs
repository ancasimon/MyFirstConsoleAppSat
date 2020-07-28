using System;
using System.Drawing;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml;

namespace MyFirstConsoleAppSat
{
    class Program
    {
        static void Main(string[] args)
            //above: void means it doesn't return anything; Main is a function; string[] is the argument to the function --this is how you would declare an array of strings;
        {
            const int theNumberFive = 5;  
            //theNumberFive = 12; --doesn't work; you cnanot assign a new value to a constant!!!

            //explicit variable declaration: no value assigned on the right-hand side;
            int myFirstInteger; // by default this will be an int32; if you want something different, you have to specify it!
            myFirstInteger = 12;
            //int is a C# primitive variable type
            //these are related to the following .Net Core immutable value types:
            //short: Int16 
            //long: Int64
            //these .Net types define the size / how long a variable can be

            //if you want to track decimal places:
            decimal money = 12.50m;
            double moreDecimalStuff = 12.50; //these are the default!
            float floatingPoint = 12.50f;
            //decimal goo d for money; doubles and floats are good for science-y and math-y stuff

            //implicit variable declaration; type is based on the value specified on the right-hand side
            var myFirstBoolean = true;
            //bool myFirstBoolean = true;
            myFirstBoolean = false;

            var myFirstString = "This is a string";
            //myFirstString = true; --this would not work / you could not change the string variable to a boolean!! this variable is still statically typed!!!
             
            char oneCharacter = 'c';

            DateTime today = DateTime.Now;
            //there are some specific helper DateTime values that give you the time or date needed. The IDE also has access to a number of properties about the DateTime because it will alwas be a DateTime static type!!
            today.AddDays(12);

            //Color codes:
            //blue text = C# keywords;
            //light blue = types defined outside of C# (by you or by .Net for example)

            //line terminations - if you want to include line breask in a longer string: you use string concatenation:
            var poem1 = "Roses are red, violets are blue, csharp is great, and so are you.";
            var poem2 = "Roses are red, " +
                "violets are blue, " +
                "csharp is great, " + 
                "and so are you.";
            //@ allows you to say it is a string literal:
            var poem3 = @"Roses are red,
                violets are blue,
                csharp is great,
                and so are you.";

            var name = "Nathan";
            var age = 34;
            //string interpolation: we START with the $ character!!! then still use {} around variable names!
            var greeting = $"My name is {name} and I am {age} years old.";

            //you can combine string literal and string interpolations: BUT the sequence of special characters is important!!! @ must come first!!
            var greeting2 = @$"My name is {name} 
                            and I'm {age} years old.";

            //reference type
            //if this is an object -> then we CAN change the type of the object!!! myObject below is an object everywhere - and everything can be an object;
            //do NOT do this!! ALWAYS use the PROPER types!!
            object myNumber = 1; // this is an example of boxing: where you take a value type and store it inside of a reference type > one of the least efficient things you can do in C# programming - you want to avoid it!
            myNumber = "stuff";
            
            //everything is an object in C#!!!
            //Creating an Anonymous Type: -- which means it is creating a specific type of object with a specific set of properties on it - which we cna then reference later. !!a very basic way to create something that has properties!!!
            var steve = new { Name = "steve" };
            greeting = $"My name is {steve.Name} and I am {age} years old.";

            //new + string[] is what declares an array of objects!!! ALSO: the compiler needs to know how many things you plan to put in the array. 
            //declare a new array with 3 empty slots:
            var names = new string[3];
            //declare an implicit array declaration with 3 full slots:
            var names2 = new string[3] { "John", "Anca", "Michele" };
            //to console the first name in the names array:
            Console.WriteLine(names[0]);
            //to change a name:
            names[1] = "Todd";
            //if you try to add a fourth item in an array you said would have 3 items, you get an exception error:
            //names[3] = "Anca";

            Console.WriteLine(greeting2);

            var shouldExecute = true;

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"{name} was in the name variable." );

            }

            switch (oneCharacter)
            {
                case 'a' :
                case 'b' : 
                    Console.WriteLine("It's the letter a");
                    break;
                    //break means stop executing in this block of code; find the closest set of curly braces and leave them;
                case 'c' :
                    Console.WriteLine("It's the letter C");
                    break;
                default :
                    Console.WriteLine("It wasn't a or c");
                    break;
            }

            for (int i = 0; i < names.Length; i++)
            {
                if ( i < 3)
                {
                    //this says: loop from i=0 to this array's length and if the i of the item is less than 3, then continue/ which means skip the current iteration and do the next iteration of the loop; aka: we are done with this iteration / go to the next one!
                    continue;
                    //continue versus break: continue says stay in the loop but exit this iteration; break says stop this iteration;
                }
                Console.WriteLine($"The current name is {names[i]}.");
            }

            //foreach loop will loop over each thing in the array you specify and it will put it in the item variable.
            foreach (var thing in names)
            {
                Console.WriteLine($"The current name is {thing}.");
            } 

            while (true)
            {
                if (DateTime.Now > new DateTime(2020,7,27,19,24,15))
                {
                    break;
                }
            }


            Console.WriteLine("please enter your name"); //this will prompt the user to write their name!
            var input = Console.ReadLine(); //when the user hits the Enter key, that's when we get the value from them!! to store that input value, we create a variable!!

            Console.WriteLine($"Hello, { input }");

            Console.WriteLine("please enter a comma-separated list of numbers"); 
            var inputNumbers = Console.ReadLine();

            var numbers = inputNumbers.Split(',');
            //split allows you to take a string and identify a character to use to separate the string!

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
