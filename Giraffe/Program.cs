using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //            string characterName = "Tom";
            //            string characterName2 = "Mike";
            //            int characterAge = 25;

            //            Console.WriteLine("Er was eens een man genaamd" + " " + characterName);
            //            Console.WriteLine("Hij was" + " " + characterAge + " jaar oud. ");
            //            Console.WriteLine("Er was eens een man genaamd " + characterName2);
            //            Console.WriteLine( characterName + " and " + characterName2 + " zijn collega`s");
            //            Console.ReadLine();

            //            Console.WriteLine("   /|");
            //            Console.WriteLine("  / |");
            //            Console.WriteLine(" /  |");
            //            Console.WriteLine("/___|");
            //            Console.ReadLine();

            //            //Data Types

            //            //string phrase = "Giraffe Academy";
            //            //char grade = 'A';
            //            //int age = 30;
            //            //double gpa = 3.3;
            //            //bool isMale = true;

            //            //Console.WriteLine(false);
            //            //Console.ReadLine();


            //            //Working with strings

            //            //dit is een variabele. variabel is just an container where you can store informaton
            //string phrase = "Giraffe academy";

            //            Console.WriteLine("Giraffe\nAcademy");
            //            Console.ReadLine();

            //            Console.WriteLine("Giraffe\"Academy");
            //            Console.ReadLine();

            //            //concatenation is the process of taking one string and then appending another string onto the end of it
            //string phrase1 = ("Giraffe Academy" + " is cool");

            //            Console.WriteLine(phrase1);
            //            Console.ReadLine();

            //            Console.WriteLine(phrase1.Length);
            //            Console.ReadLine();

            //            // dit is een method
            //            Console.WriteLine(phrase.ToUpper());
            //            Console.ReadLine();

            //            Console.WriteLine(phrase.ToLower());
            //            Console.ReadLine();

            //            Console.WriteLine(phrase.Contains("c"));
            //            Console.ReadLine();
            //            Console.WriteLine(phrase.Contains("academies"));
            //            Console.ReadLine();

            //            // dit is een parameter. Im gonna give this contained method, a piece of information
            //            Console.WriteLine(phrase.Contains("academy"));
            //            Console.ReadLine();

            //            Console.WriteLine(phrase[1]);
            //            Console.ReadLine();
            //            Console.WriteLine(phrase1[0]);
            //            Console.ReadLine();

            //Console.WriteLine(phrase1.IndexOf('i'));
            //Console.ReadLine();

            //Console.WriteLine(phrase1.Substring(8));
            //Console.ReadLine();
            //Console.WriteLine(phrase1.Substring(8, 12));
            //Console.ReadLine();

            //Console.WriteLine("Hello World");
            //Console.ReadLine();

            //Working with numbers, integers, double, float, decimal

            //Console.WriteLine(-5.874 + 53.315);
            //Console.ReadLine();
            //Console.WriteLine(5 + 8);
            //Console.ReadLine();
            //Console.WriteLine(5 / 2);
            //Console.ReadLine();
            //Console.WriteLine( 5 % 2);
            //Console.ReadLine();
            //Console.WriteLine( 4 + 2 * 3);
            //Console.ReadLine();
            //Console.WriteLine( (4 + 2) * 3);
            //Console.ReadLine();

            //Console.WriteLine( 5.0 + 8.1);
            //Console.ReadLine();

            //Console.WriteLine( 5 + 8.1);
            //Console.ReadLine();

            //Console.WriteLine( 5 / 2);
            //Console.ReadLine();
            //Console.WriteLine( 5 / 2.0);
            //Console.ReadLine();

            //int num = 6;
            //num++;

            //Console.WriteLine(num);
            //Console.ReadLine();

            //int NUM = 6;
            //NUM--;
            //Console.WriteLine(NUM);
            //Console.ReadLine();

            //Console.WriteLine(Math.Abs(-40));
            //Console.ReadLine();
            //Console.WriteLine(Math.Pow(3, 2));
            //Console.ReadLine();
            //Console.WriteLine(Math.Pow(3.8, 2));
            //Console.ReadLine();
            //Console.WriteLine(Math.Sqrt(36));
            //Console.ReadLine();
            //Console.WriteLine(Math.Max(4 , 90));
            //Console.ReadLine();
            //Console.WriteLine(Math.Min(4, 90));
            //Console.ReadLine();
            //Console.WriteLine(Math.Round(8.2));
            //Console.ReadLine();
            //Console.WriteLine(Math.PI);
            //Console.ReadLine();
            //Console.WriteLine(Math.Acos(2.151545));
            //Console.ReadLine();
            //Console.WriteLine(phrase1.Equals(phrase));
            //Console.ReadLine();


            //getting users input
            //Console.Write("Enter you name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter you age: ");
            //string age = Console.ReadLine();// we store console line into a variable
            //Console.Write("Enter you gender: ");
            //string gender = Console.ReadLine();
            //string Gender2 = gender;

            //if (Gender2 == "M")
            //{
            //    Gender2 = " de heer ";// code block to be executed when if condition evaluates to true
            //}
            //else Gender2 = " mevrouw ";
            //Console.WriteLine("Hello" + Gender2 + name + "\nYou are " + age + " years old");
            //Console.ReadLine();

            // building a calculator

            //int num = Convert.ToInt32("45");
            //Console.WriteLine("43" + "56");
            //Console.ReadLine();
            //Console.WriteLine( num + 6);
            //Console.ReadLine();

            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a secocnd number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("and the answer is...." + (num1 + num2));
            //Console.ReadLine();

            //System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            //customCulture.NumberFormat.NumberDecimalSeparator = ".";

            //System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            //Console.Write("Enter a number: ");
            //string numA = Console.ReadLine();
            //double num1 = Convert.ToDouble(numA);
            //double num1a = Double.Parse(numA);
            //Console.Write("Enter a second number: ");
            //string numB = Console.ReadLine(); ;
            //double num2 = Convert.ToDouble(numB); ;
            //double num2b = Double.Parse(numB);
            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1a + num2b);
            //Console.ReadLine();

            //Building a mad libs game;

            //Console.WriteLine("Roses are Red");
            //Console.WriteLine("Violets are blue");
            //Console.WriteLine("I love you");

            //string color, pluralNoun, celebrity;
            //Console.WriteLine("Enter a color: ");
            //color = Console.ReadLine();

            //Console.WriteLine("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.WriteLine("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine( pluralNoun + " is blue");
            //Console.WriteLine("I love " + celebrity);

            //Console.ReadLine();

            //Arrays

            //int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int friends = luckyNumbers.Length;
            //luckyNumbers[1] = 900;
            //luckyNumbers[10] = 45;
            //luckyNumbers[7] = 59;
            //luckyNumbers[4] = 800;
            //Console.WriteLine(luckyNumbers[2]);
            //Console.ReadLine();

            //string[] friends2 = new string[5];
            //friends2[0] = "Jim";
            //friends2[1] = "Kelly";

            //Console.WriteLine(friends2[1]);

            //Console.ReadLine();

            ////calling my method and returns to continue the Main method
            //SayHi();
            ////Console.ReadLine();
            //SayHi2("Mikel ", 2, "Bergweg", "0104660499");
            //SayHi2("John ", 35, "", "");
            //SayHi2("Tom ", 30, "", "");
            //WriteSquares();
            ////WriteSquares2();
            //Console.ReadLine();
            //Console.WriteLine($"{5} x {5} = {25}");
            //Console.ReadLine();
            //WriteSquares3();
            //Console.ReadLine();        }

            //Create my own method
            //        static void SayHi()
            //        {
            //            Console.WriteLine("Hello User");
            //        }
            //        static void SayHi1(string name)// give this method information. This is called parameter or argument
            //        {
            //            Console.WriteLine("Hello " + name);
            //        }
            //        static void SayHi2(string name, int age, string address, string numb)// give this method information. This is called parameter or argument
            //        {

            //            Console.WriteLine("Hello " + name + " you are " + age + " years old And you live in " + address + " number " + numb);
            //        }

            //        public static void WriteSquares()
            //        {
            //            int i = 0;
            //            int j;
            //            while (i < 10)
            //            {
            //                j = i * i;
            //                Console.WriteLine($"{i} x {i} = {j}");
            //                i++;
            //            }
            //        }

            //        public static void WriteSquares3()
            //        {
            //            int i = 0;
            //            int j;
            //            int counterRows = 0;
            //            string strContent = "";
            //            int counterColumns = 0;

            //            while (i < 10)
            //            {
            //                while (i < 10)
            //                {

            //                    j = i * i;
            //                    Console.WriteLine($"{strContent} x {strContent} = {j}");
            //                    i++;
            //                }
            //                Console.WriteLine($"{strContent}");
            //                counterColumns = 0;
            //                strContent = "";
            //                counterRows++;

            //            }
            //        }
            //    }
            //}


            //        public static void WriteSquares2()
            //        {
            //            int counterRows = 0;
            //            int counterColumns = 0;
            //            string strContent = "";
            //            while (counterRows < 10)
            //            {
            //                while (counterColumns < 10)
            //                {
            //                    strContent = strContent + "||";

            //                    counterColumns++;
            //                }
            //                Console.WriteLine($"{strContent}");
            //                counterColumns = 0;
            //                strContent = "";
            //                counterRows++;
            //            }

            //Console.ReadLine();

            //Console.WriteLine(cube(5));//a way to get information back from a method. Extremly important
            //Console.ReadLine();

            //int cubedNumber = cube(15);// setting this variable equal to cube five
            //Console.WriteLine(cubedNumber);//a way to get information back from a method
            //Console.ReadLine();

            //bool isMale = true;//"true" is the variable

            //if (isMale) //we have created aprpgram that is able to respond to the value of a variable
            //{
            //    Console.WriteLine("You are male");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male");
            //}

            //Console.ReadLine();

            //bool isMale1 = true;//"true" is the variable
            //bool isTall = false;

            //if (isMale1 && isTall) //we have created aprpgram that is able to respond to the value of a variable. && = AND operator allows me to use two conditions in the same condition block
            //{
            //    Console.WriteLine("You are tall male");
            //}
            //else
            //{
            //    Console.WriteLine("You are either not male or not tall or both");
            //}

            //Console.ReadLine();

            //if (isMale1 || isTall) //|| = OR operator. Difference between AND operator is allows me to use two conditions in the same condition block. But this time only one of these conditions has to be true
            //{
            //    Console.WriteLine("You are tall male");
            //}
            //else
            //{
            //    Console.WriteLine("You are either not male or not tall or both");
            //}

            //Console.ReadLine();

            //if (isMale1 && isTall)
            //{
            //    Console.WriteLine("You are tall male");
            //}
            //else if (isMale1 && !isTall) // ! operator = is NOT
            //{
            //    Console.WriteLine("You are a short male");
            //}
            //else if (!isMale1 && isTall)
            //{
            //    Console.WriteLine("You are a not a male but you`re tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are either not male or not tall");
            //}

            //Console.WriteLine(GetMax(254640, 13540, 1015));

            //Console.WriteLine("Enter a number: ");// get the all information from the user 
            //double num1 = Convert.ToDouble(Console.ReadLine());// store users number in a variable. In this case insidse a double. Gives us a string back.Thats why we use convert

            //Console.Write("Enter Operator: ");
            //string operatorrr = Console.ReadLine();

            //Console.WriteLine("Enter a second number: ");// get the all information from the user 
            //double num2 = Convert.ToDouble(Console.ReadLine());// store users number in a variable. In this case insidse a double. console readline Gives us a string back.Thats why we use convert

            //if (operatorrr == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (operatorrr == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (operatorrr == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else if (operatorrr == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Operator");
            //}

            //Console.WriteLine(GetDay(80));

            //int index = 1;
            //while (index <= 5)// We have a condition, as long as that condition is true, we are gonna keep we are keep executing the code
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            //Console.ReadLine();

            //int index1 = 6;
            //do //difference: do while loop will execute the code inside of the loop before it checks the condition. Will loops are more usefull.
            //{
            //    Console.WriteLine(index1);
            //    index1++;
            //} while (index1 <= 5);

            //string secretWord = "giraffe: ";//variable
            //string guess = "";//variable
            //int guessCount = 0;// count variable
            //int guessLimit = 3;// count limit
            //bool outoffGuesses = false;// whether or not the guess is run out of guesses

            //while (guess != secretWord && !outoffGuesses) // this loop gonna keep asking the user to guess if either conditions are true 
            //{
            //    if (guessCount < guessLimit)// 
            //    {
            //        Console.Write("Enter guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else 
            //    {
            //        outoffGuesses = true;//Called a boolean flags
            //    }
            //}
            //if (outoffGuesses)// if we breaking out of the loop, there are two situations. You won or you lose
            //{
            //    Console.Write("You Lose");
            //}
            //else
            //{
            //    Console.Write("You Win!");
            //}

            // Console.ReadLine();

            int i = 1;
            while (i <= 5)
            { 
                Console.WriteLine(i);
                i++;            
            }
            Console.ReadLine();
            //first thing we do is create a variable and we give it an initial value. The second thing we do is we check this condition. Ifits true than all the code inside the for loop. If that happens we increment j.
            for (int j = 1; j <=5; j++)// this for loop doing exactly what that for loop was doing.Only its a lot more compact and easier to manage
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();

            int[] luckyNumbers = { 4, 8, 16, 23, 42 };

            for (int l = 0; l < luckyNumbers.Length; l++)
            {
                Console.WriteLine(luckyNumbers[l]);
            }
            Console.ReadLine();


            int[] luckyNumbers2 = { 4, 8, 16, 23, 42 };

            for (int k = 0; k < luckyNumbers2.Length; k++)
            {
                Console.WriteLine(luckyNumbers2[k]);
            }
            Console.ReadLine();

        }

        // Return Statement
        //static int cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}

        // If statements. It begins with true??? Its a special structure in our program wich allow the prog to respond to different situations. Program becomes smarter
        //It allows programs to make decisions and to do different things, when different conditions are met
        // I wake up
        // If I`m hungry 
        //I eat breakfast

        //I look at my phone
        //If its about to die
        //I charge it

        //I leave my house
        //if it`s cloudy 
        // I bring an umbrella
        // otherwise 
        // I bring sunglasses

        //Comparisons
        //static int GetMax(int num1, int num2)
        //{
        //    int result;

        //    if (num1>num2)
        //    {
        //        result = num1; 
        //    }
        //    else { result = num2; }

        //    return result;

        //}

        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;
        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        result=num1;
        //    } 
        //    else if (num2 >=num1 && num2 >= num3) 
        //    { 
        //        result = num2;
        //    }
        //    else 
        //    { 
        //        result = num3; 
        //    }

        //    return result;

        //}
        //static int GetMax1(int num1, int num2)//hoe krijg ik een if van chararcters???
        //{
        //    int result;

        //    if ('c' != 'c' && num1 >= num2)
        //    {
        //        result = num1;
        //    }
        //    else { result = num2; }

        //    return result;

        //}


        // Switch statements is basically just a special type of IF statement where we can check a bunch of different really easily

        //static string GetDay(int dayNum) 
        //{
        //    string dayName;// variable 

        //    switch (dayNum) // Figure out what the dayNum is and depending on what it us do different stuff   //the switch statement needs one piece of info inside, it basically needs a value. We can a pass in a value and see/check if that value is equal to bunch of different stuff.  
        //    {
        //        case 0:
        //            dayName = "Sunday";// in the case dayNum is 0 I want to do this
        //            break;//reserved word in c# wich says that we want to break out of the structure that we are currently in.
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;//reserved word in c# wich says that we want to break out of the structure that we are currently in.
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;//reserved word in c# wich says that we want to break out of the structure that we are currently in.
        //        default:
        //            dayName = "Invalid Day Number";
        //            break;

        //    }

        //    // Special structure --> switch statement. Goal is to populate this dayName variable with the correct value thats gonna correspond to the dayNum that gets passed in

        //    return dayName;//Goal is to return dayname
        //


    }
}