// // Random value = new Random();
// // int result = value.Next(1,7);
// // Console.WriteLine(result);

// //if statement
// // int maxValue = 600;
// // int minValue = 300;

// // int largerValue;

// // largerValue =System.Math.Max(maxValue,minValue);
// // System.Console.WriteLine(largerValue);

// // string message = "The quick brown fox jumps over the lazy dog.";

// // if (message.Contains("cat"))
// // {
// //     System.Console.WriteLine("the message contains a dog");
// // }else
// // {
    
// // System.Console.WriteLine("it does not");
// // }

// // Random dice = new Random();

// // int row1 = dice.Next(0,10);
// // int row2 = dice.Next(2,50);
// // int row3 = dice.Next(0,20);

// // int total = row1 + row2 + row3;

// // if (row1 == row2 || row2 == row3)
// // {
// //     total += 2;
// // }
// // else{
// //     total -= 2;
// // }
// // if (total < 15)
// // {
// //     System.Console.WriteLine("you win");
// // }
// // else
// // {
// //     System.Console.WriteLine("you lose");
// // }

// // Random days = new Random();
// // int daysUntilExpiration = days.Next(12);
// // //int discountPercentage = 0;

// // if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
// // {
// //     System.Console.WriteLine("Your subscription will expire soon. Renew now!");
// // }
// // else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
// // {
// //     System.Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
// // }
// // else if (daysUntilExpiration == 1)
// // {
// //     System.Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
    
// // }
// // else if (daysUntilExpiration == 0)
// // {
// //     System.Console.WriteLine("Your subscription has expired.");
// // }
// // else
// // {
// //     System.Console.WriteLine("");
// // }

// //array

// // string[] fraudulentOrderIds = new string[3];
// // fraudulentOrderIds[0] = "A123";
// // fraudulentOrderIds[1] = "B456";
// // fraudulentOrderIds[2] = "C789";

// // System.Console.WriteLine(fraudulentOrderIds[2]);



// // string[] fraudulentOrderIdss = {"a","b","c"};
// // foreach (string item in fraudulentOrderIdss)
// // {
// //     System.Console.WriteLine(item);   
// // }

// // int length = fraudulentOrderIds.Length;
// // System.Console.WriteLine(length);


// // int[] inventory = { 200, 450, 700, 175, 250 };
// // int sum = 0;
// // foreach (int item in inventory)
// // {
// //     sum += item;
// // }

// // System.Console.WriteLine($"the total items in the inventory is {sum}");

// // string[] fraudulentOrderID = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

// // foreach (string fraudulentId in fraudulentOrderID)
// // {
// //     if (fraudulentId.StartsWith("B"))
// //     {
// //         System.Console.WriteLine($"here are a list of fraudulent ids {fraudulentId}");   
// //     }
// // }

// // object[] tests = {6, "one",true, 9.9};
// // foreach (var test in tests)
// // {
// //     System.Console.WriteLine(test);
// // }

// string message = "the quick fox jumped over the lion";

// // convert the string to an array of character
// char[] messageChar = message.ToCharArray();

// // reverse array character
// Array.Reverse(messageChar);

// // int numberOfO = 0;

// // foreach(char letter in messageChar){
// //     if (letter == 'o')
// //     {
// //         numberOfO++;
// //     }
// // }
// //convert the chararcter to a string
// // string stringValue = new string(messageChar);
// // System.Console.WriteLine(stringValue);

// // System.Console.WriteLine($"the letter o appears {numberOfO} times");

// int[] sophieScores = {90,86,87,98,100};

// int[] andrewScores = {92, 89, 81, 96, 90};

// int[] emmaScores = { 90, 85, 87, 98, 68 };

// int[] loganScores = { 90, 95, 87, 88, 96 };

// // string[] studentNames = {"sophie","andrew","emma","logan"};
// System.Console.WriteLine("enter your name");
// string fullName = Console.ReadLine().ToLower();

// if (fullName == "sophie")
// {
// int sophieSum = 0;
// foreach(int score in sophieScores){
//     sophieSum += score; 
// }
// decimal average_grade = sophieSum/sophieScores.Length;

// if (average_grade <= 59)
// {
//     System.Console.WriteLine($"your grade is F");
// }

// else if (average_grade >= 60 && average_grade <= 62 )
// {
//         System.Console.WriteLine($"your grade is D-");
// }
// else if (average_grade >= 63 && average_grade <= 66 )
// {
//         System.Console.WriteLine($"your grade is D");
// }
// else if (average_grade >= 67 && average_grade <= 69 )
// {
//         System.Console.WriteLine($"your grade is D+");
// }
// else if (average_grade >= 70 && average_grade <= 72 )
// {
//         System.Console.WriteLine($"your grade is C-");
// }
// else if (average_grade >= 73 && average_grade <= 76 )
// {
//         System.Console.WriteLine($"your grade is C");
// }
// else if (average_grade >= 77 && average_grade <= 79 )
// {
//         System.Console.WriteLine($"your grade is C+");
// }
// else if (average_grade >= 80 && average_grade <= 82 )
// {
//         System.Console.WriteLine($"your grade is B-");
// }
// else if (average_grade >= 83 && average_grade <= 86 )
// {
//         System.Console.WriteLine($"your grade is B");
// }
// else if (average_grade >= 87 && average_grade <= 89 )
// {
//         System.Console.WriteLine($"your grade is B+");
// }
// else if (average_grade >= 90 && average_grade <= 92 )
// {
//         System.Console.WriteLine($"your grade is A-");
// }
// else if (average_grade >= 93 && average_grade <= 96 )
// {
//         System.Console.WriteLine($"your grade is A");
// }
// else if (average_grade >= 97 && average_grade <= 100 )
// {
//         System.Console.WriteLine($"your grade is A+");
// }
// else{
//     System.Console.WriteLine("wrong entry");
// }
    
// }
// else if (fullName == "emma")
// {
//    int emmaSum = 0;
// foreach(int score in emmaScores){
//     emmaSum += score; 
// }
// decimal average_grade = emmaSum/emmaScores.Length;

// if (average_grade <= 59)
// {
//     System.Console.WriteLine($"your grade is F");
// }

// else if (average_grade >= 60 && average_grade <= 62 )
// {
//         System.Console.WriteLine($"your grade is D-");
// }
// else if (average_grade >= 63 && average_grade <= 66 )
// {
//         System.Console.WriteLine($"your grade is D");
// }
// else if (average_grade >= 67 && average_grade <= 69 )
// {
//         System.Console.WriteLine($"your grade is D+");
// }
// else if (average_grade >= 70 && average_grade <= 72 )
// {
//         System.Console.WriteLine($"your grade is C-");
// }
// else if (average_grade >= 73 && average_grade <= 76 )
// {
//         System.Console.WriteLine($"your grade is C");
// }
// else if (average_grade >= 77 && average_grade <= 79 )
// {
//         System.Console.WriteLine($"your grade is C+");
// }
// else if (average_grade >= 80 && average_grade <= 82 )
// {
//         System.Console.WriteLine($"your grade is B-");
// }
// else if (average_grade >= 83 && average_grade <= 86 )
// {
//         System.Console.WriteLine($"your grade is B");
// }
// else if (average_grade >= 87 && average_grade <= 89 )
// {
//         System.Console.WriteLine($"your grade is B+");
// }
// else if (average_grade >= 90 && average_grade <= 92 )
// {
//         System.Console.WriteLine($"your grade is A-");
// }
// else if (average_grade >= 93 && average_grade <= 96 )
// {
//         System.Console.WriteLine($"your grade is A");
// }
// else if (average_grade >= 97 && average_grade <= 100 )
// {
//         System.Console.WriteLine($"your grade is A+");
// }
// else{
//     System.Console.WriteLine("wrong entry");
// } 
// }


// string a = "a";
// string b = " a".Trim();


// System.Console.WriteLine(a==b);

// System.Console.WriteLine("enter amount");
// string amount = Console.ReadLine();
// int conAmount;
// if (amount != null && int.TryParse(amount, out conAmount))

// {


// int cost = 1000;

// int eligible = conAmount > cost ? conAmount - 100: conAmount - 50;
// System.Console.WriteLine(eligible);
        
// }
// else
// {
//         System.Console.WriteLine("amount cannot be null or NAN");
// }


//coin flip
// Random random = new Random();
// int value = random.Next(0,2);
// System.Console.WriteLine(value == 0 ? "Head": "Tail");

// System.Console.WriteLine("enter your role as an Admin or Manager");
// string permission = Console.ReadLine().ToLower();
// System.Console.WriteLine("enter your corresponding level");
// string level = Console.ReadLine();
// int ConvertedLevel;
// int.TryParse(level, out ConvertedLevel);

// if (permission != null)
// {
        
// if (permission.Contains("admin") && ConvertedLevel > 55)
// {
//         System.Console.WriteLine("Welcome, Super Admin user.");
        
// }
// else if (permission.Contains("admin") && ConvertedLevel <= 55 )
// {
//         System.Console.WriteLine("Welcome, Admin user.");
// }
// else if (permission.Contains("manager") && ConvertedLevel >= 20)
// {
//         System.Console.WriteLine("Contact an Admin for access.");
// }
// else if (permission.Contains("manager") && ConvertedLevel < 20)
// {
//         System.Console.WriteLine("You do not have sufficient privileges.");
// }
// else if (!permission.Contains("admin") || !permission.Contains("manager"))
// {
//         System.Console.WriteLine("You do not have sufficient privileges.");        
// }
// else
// {
//         System.Console.WriteLine("role not found");
// }
// }
// else
// {
//         System.Console.WriteLine("you must enter your role.");
// }

//int value = 5;

// if (value > 0)
// {       
//         int num = 6;
//         System.Console.WriteLine(value);
//         value += num;
//         System.Console.WriteLine(value);
// }

// System.Console.WriteLine(value);



// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// int sum = 0;
// bool found = false;
// foreach (int number in numbers)
// {
//         sum += number;

//         if (number == 42)
//         {
//                 found = true;
//         }
// }

// if (found)
// {
//         System.Console.WriteLine($"the set contains 42");
// }
// System.Console.WriteLine($"total: {sum}");


//switch statement
// Console.WriteLine("enter a fruit");
// string fruit = Console.ReadLine();
// // string fruit = "apple";

// switch (fruit)
// {
//         case "apple":
//         System.Console.WriteLine("apple is grown in the north");
//         break;

//         case "cucumber":
//         System.Console.WriteLine("cucumber is planted in the middlebelt");
//         break;

//         case "orange":
//         System.Console.WriteLine("orange is grown in the south");
//         break;

//         case "pineapple":
//         System.Console.WriteLine("pineapple is grown in the east");
//         break;

//         default:
//         System.Console.WriteLine("fruit does not exist");
//         break;
// }
// Console.WriteLine("enter your level");

// int employeeLevel;
// string levelString = Console.ReadLine();
// int.TryParse(levelString, out employeeLevel);
// string name = "john";
// string description = "";

// switch (employeeLevel)
// {
//         case 100:
//         case 200:
//         description = "graduate";
//         break;

//         case 300:
//         description = "associate";
//         break;

//         case 400:
//         description = "management";
//         break;

//         default:
//         description = "director";
//         break;
// }

// System.Console.WriteLine($"{name} is a {description} in the company");

// string sku = "01-MN-L";

// string[] product = sku.Split("-");

// string type = "";
// string color = "";
// string size = "";
// switch (product[0])
// {
//         case "01":
//         type = "sweat shirt";
//         break;

//         case "02":
//         type = "T-Shirt";
//         break;

//         case "03":
//         type = "Sweat pants";
//         break;

//         default:
//         type = "others";
//         break;
        
// }

// switch (product[1])
// {
//         case "BL":
//         color = "black";
//         break;

//         case "MN":
//         color = "Maroon";
//         break;

//         default:
//         color = "white";
//         break;
// }

// switch (product[2])
// {
//         case "S":
//         size = "small";
//         break;

//         case "M":
//         size = "medium";
//         break;

//         case "L":
//         size = "large";
//         break;
        
//         default:
//         size = "x-large";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");


//for loop

// for (int i = 0; i < 10; i++)
// {
//         System.Console.WriteLine(i);
// }


// for (int i = 10; i >= 0; i--)
// {
//         System.Console.WriteLine(i);
// }


// for (int i = 0; i < 10; i+=3)
// {
//         System.Console.WriteLine(i);
// }


// for (int i = 0; i < 10; i++)
// {
//         if (i == 8)
//         {
//                 break;
//         }
//         System.Console.WriteLine(i);
// }

// string[] names = {"Michael", "David", "Eddie", "Alex"};

// for (int i = 0; i < names.Length; i++)
// {
//         System.Console.WriteLine(names[i]);
// }

// string[] names = {"Michael", "David", "Eddie", "Alex"};

// for (int i = 0; i < names.Length; i++)
// {
//         if (names[i] == "David")
//         {
//                 names[i] = "xxxx";
//         }

//         System.Console.WriteLine(names[i]);
// }

// for (int i = 1; i <= 100 ; i++)
// {
//         if ( i % 3 == 0 && i % 5 == 0)
//         {
//                 System.Console.WriteLine($"{i} - FizzBuzz");
//         }
//         else if (i % 3 == 0)
//         {
//                 System.Console.WriteLine($"{i} - Fizz");
//         }
//         else if (i % 5 == 0)
//         {
//                 System.Console.WriteLine($"{i} - Buzz");
//         }
//         else
//         {
//                 System.Console.WriteLine($"{i}");
//         }
// }

//         Random num = new Random();
//         int val = 0;
// do
// {
//         val = num.Next(1,11);
//         System.Console.WriteLine(val);
// } while (val != 7);

// Random num = new Random();
// int val = num.Next(1,11);
// while (val == 7)
// {
//         break;
// }

// Random val = new Random();
// int x= val.Next(1,11);
// while (x >= 8)
// {
//         System.Console.WriteLine(x);
//         x = val.Next(1, 11);
        
// }
// System.Console.WriteLine(x);


// int heroHealth = 10;
// int monsterHealth = 10; 

// while (heroHealth > 0 && monsterHealth > 0)
// {
//     Random heroAttack = new Random();
//     int heroAttackValue = heroAttack.Next(1,11);
//     monsterHealth -= heroAttackValue;

//     System.Console.WriteLine($"Monster was damaged and lost {heroAttackValue} health and now has {monsterHealth} health left");


//     Random monsterAttack = new Random();
//     int monsterAttackValue = monsterAttack.Next(1,11);
//     heroHealth -= monsterAttackValue;

//     System.Console.WriteLine($"Hero was damaged and lost {monsterAttackValue} health and now has {heroHealth} health left");


// }

// string winner = heroHealth > monsterHealth ? "Hero wins" : "Monster wins";
// System.Console.WriteLine(winner);


//the loop should stop  running when a user enter a string length greater than or equal to 3 otherwise, should continue.
// Console.WriteLine("enter a word");
// do
// {
// string? sentence = Console.ReadLine();
//     if (sentence.Length >= 3)
//     {
//         break;
//     }
//     else
//     {
//         System.Console.WriteLine("invalid entry");
//     }
// } while (true);

// string? value;
// bool validity = false;
// do
// {
//     System.Console.WriteLine("playing with my toy");
//     System.Console.WriteLine("do you want to continue: yes/no");
//     value = Console.ReadLine().ToLower();
//     if (value == "no")
//     {
//         validity = true;
//     }
//     else
//     {
//         System.Console.WriteLine("you've entered a wrong word, try again");
//     }
    
// } while (validity == false);
// System.Console.WriteLine("game over");

// Console.WriteLine("enter a value between 5-10");
// bool validity = false;
// do
// {
//     int number;
//     string? inputValue = Console.ReadLine();
//     int.TryParse(inputValue, out number);

//     if (number >= 5 && number <= 10)
//     {
//         System.Console.WriteLine($"the number entered is {number} and it is valid");
//         validity = true;
//     }
//     else
//     {
//         System.Console.WriteLine("enter a value between 5-10");
//         System.Console.WriteLine("try again");
//     }
    
// } while (validity == false);

// System.Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// bool validity = false;
// do
// {
//     string? role = Console.ReadLine().Trim();
//     role = char.ToUpper(role[0]) + role.Substring(1);
//     if (role == "Administrator" || role == "Manager" || role == "User")
//     {
//         System.Console.WriteLine($"Your input value ({role}) has been accepted.");
//         validity = true; 
//     }
//     else
//     {
//         System.Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//     }
    
// } while (validity == false);


// string[] myStrings = {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// int periodLocation;
// foreach(string myString in myStrings){
//     periodLocation = myString.IndexOf(".");

//     while (periodLocation > 1)
//     {
//         string mySentence = myString.Remove(periodLocation);
//         mySentence.Substring(periodLocation + 1);
//         System.Console.WriteLine(mySentence);
//     }
    
    
// }

// Console.WriteLine("enter your name");
// string fullName =  Console.ReadLine();

// string result = "Hi "+ fullName;
// System.Console.WriteLine(result);

// add two numbers
// Console.Write("enter a number ");

// int x;
// string number_1 = Console.ReadLine();
// int.TryParse(number_1, out x);

// Console.Write("enter a second number ");
// int y;
// string number_2 = Console.ReadLine();
// int.TryParse(number_2, out y);

// int res = x + y;
// Console.WriteLine($"the sum of {x} and {y} is {res}");

// convert string to int

// int number = Convert.ToInt32("45");
// int number2 = Convert.ToInt32("50");
// Console.WriteLine(number + number2);

// convert string to double

// double cgpa = Convert.ToDouble(Console.ReadLine());

// madlib
// Console.Write("enter a color: ");
// string color = Console.ReadLine();

// Console.Write("enter a Plural noun: ");
// string pluralNoun = Console.ReadLine();

// Console.Write("enter a celebrity: ");
// string celebrity = Console.ReadLine();

// Console.WriteLine($"Roses are {color}");
// Console.WriteLine($"{pluralNoun} are blue");
// Console.WriteLine($"I love {celebrity}");

// arrays

// int [] luckyNumbers = {2,4,5,6,8,9};
// int firstNumber = luckyNumbers[0];

// luckyNumbers[3] = 100;
// System.Console.WriteLine(luckyNumbers[3]);

// // another way to declare arrays

// string [] friends = new string[5];
// friends[0] = "jim";
// friends[1] = "john";
// friends[2] = "jane";

// methods

class Program
{
    static void Main(string[] args)
    {
        // SayHi("mike", 27);

        // System.Console.WriteLine(cube(2,3));
        // Console.WriteLine(MaxNumber(7,7));

        // Console.WriteLine(Math.Pow(2,3));

        //Console.WriteLine(AddTwoNumbers());
        // Console.WriteLine(MultiplyTwoNumbers());
        // Console.Write("enter a number: ");
        // int e = Convert.ToInt32(Console.ReadLine());

        // Console.Write("enter an operator: ");
        // string op = Console.ReadLine(); 

        // Console.Write("enter a second number:");
        // int f = Convert.ToInt32(Console.ReadLine());

        // switch (op)
        // {
        //     case "+":
        //         System.Console.WriteLine(e + f);
        //         break;

        //     case "-":
        //         System.Console.WriteLine(e - f);
        //         break;

        //     case "*":
        //         System.Console.WriteLine(e * f);
        //         break;

        //     case "/":
        //         System.Console.WriteLine(e / f);
        //         break;

        //     default:
        //         System.Console.WriteLine("invalid operator");
        //         break;
        // }

        // if (op == "+")
        // {
        //     Console.WriteLine(e + f);
        // }
        // else if (op == "*")
        // {
        //     Console.WriteLine(e * f);
        // }
        // else if (op == "/")
        // {
        //     Console.WriteLine(e / f);
        // }
        // else if (op == "-")
        // {
        //     Console.WriteLine(e - f);
        // }
        // else
        // {
        //     Console.WriteLine("enter a valid operator");
        // }

// while loop
        // int x = 10;
        // while (x >= 1)
        // {
        //     System.Console.WriteLine(x);
        //     x--;
        // }

        // guessing game
        // int guess_number = 10;
        // int guess_start = 0;
        // int guess_end = 3;

        // while (guess_start < guess_end)
        // {
        //     System.Console.Write("enter a number: ");
        //     int guess =(int) Convert.ToInt32(Console.ReadLine());
            
        //     if (guess == guess_number)
        //     {
        //         System.Console.WriteLine("correct!!");
        //         break;
        //     }
        //     else if(guess != guess_number)
        //     {
        //         System.Console.WriteLine("wrong, guess again");
        //     }
        //     guess_start++;

        //     if (guess_start >= guess_end)
        //     {
                
        //         System.Console.WriteLine("u lose");
        //         break;
        //     }

            
        // }
        
        // do-while

        // int index = 1;

        // do
        // {
        //     System.Console.WriteLine(index);
        //     index++;
        // } while (index < 6);

    // another guessing game




    }

    // static string AddTwoNumbers()
    // {
    //     Console.Write("enter a number: ");
    //     int x = Convert.ToInt32(Console.ReadLine());
    //     Console.Write("enter a second number:");
    //     int y = Convert.ToInt32(Console.ReadLine());
    //     int z = x + y;
    //     return $"the sum of {x} and {y} is {z}";
    // }

    // static string MultiplyTwoNumbers()
    // {
    //     Console.Write("enter a number: ");
    //     int a = Convert.ToInt32(Console.ReadLine());
    //     Console.Write("enter a second number:");
    //     int b = Convert.ToInt32(Console.ReadLine());
    //     int c = a * b;
    //     return $"the product of {a} and {b} is {c}";        
    // }

    // static void SayHi(string name, int age)
    // {
    //     System.Console.WriteLine($"hello {name}, you are {age} years old.");
    // }

    // static int cube(int x, int y)
    // {
    //    int result = Convert.ToInt32(Math.Pow(x,y));
    //    return result;
    // }

    // static string MaxNumber(int x, int y)
    // {
    //     if (x > y)
    //     {
    //         return $"{x} is greater than {y}";
    //     }
    //     else if (y > x)
    //     {
    //         return $"{y} is greater than {x}";
    //     }
    //     else
    //     {
    //         return $"{x} and {y} are equal";
    //     }
    // }



}