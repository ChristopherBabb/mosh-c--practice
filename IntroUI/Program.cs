// See https://aka.ms/new-console-template for more information
// using IntroLibrary;
// using System;

// while (true)
// {
//     System.Console.WriteLine("Enter a num between 1 and 10");

//     var user_value = Int32.Parse(s: Console.ReadLine());

//     if (user_value > 0 && user_value < 11)
//     {
//         System.Console.WriteLine("Valid");
//         break;
//     }

// }

// while (true)
// {
//     System.Console.WriteLine("Enter Two Nums");
//     var user_value1 = Int32.Parse(s: Console.ReadLine());
//     var user_value2 = Int32.Parse(s: Console.ReadLine());

//     if (user_value1 > user_value2)
//     {
//         System.Console.WriteLine(String.Format("{0} Is bigger than {1}", user_value1, user_value2));
//         break;
//     }
//     else if (user_value1 < user_value2)
//     {
//         System.Console.WriteLine(String.Format("{0} Is bigger than {1}", user_value2, user_value1));
//         break;
//     }
//     else
//     {
//         System.Console.WriteLine("The numbers are equal");
//         break;
//     }
// }

// while (true)
// {
//     System.Console.WriteLine("Enter width and height of picture");
//     var user_value1 = Int32.Parse(s: Console.ReadLine());
//     var user_value2 = Int32.Parse(s: Console.ReadLine());

//     if (user_value1 > user_value2)
//     {
//         System.Console.WriteLine("Picture is landcape");
//         break;
//     }
//     else if (user_value1 < user_value2)
//     {
//         System.Console.WriteLine("Picture is portrait");
//         break;
//     }
//     else
//     {
//         System.Console.WriteLine("Picture is a square");
//         break;
//     }
// }

// while (true)
// {
//     int limit = 50;
//     System.Console.WriteLine("Enter speed");
//     var user_value = Int32.Parse(s: Console.ReadLine());

//     if (user_value <= 50)
//     {
//         System.Console.WriteLine("Speed is fine");
//         break;
//     }
//     else if (user_value <= 56)
//     {
//         System.Console.WriteLine("1 Demerit");
//         break;
//     }
//     else if (user_value <= 61)
//     {
//         System.Console.WriteLine("2 Demerits");
//         break;
//     }
//     else
//     {
//         System.Console.WriteLine("License Suspended");
//     }


// }

// while (true)
// {
//     var count = 0;

//     for (int i = 0; i <= 100; i++)
//     {
//         if ((i % 3) == 0)
//         {
//             count++;
//         }
//     }

//     System.Console.WriteLine(count);
//     break;
// }

// var count = 0;

// while (true)
// {

//     System.Console.WriteLine("Enter a number or ok to exit");
//     var input = Console.ReadLine();

//     if (input == "ok")
//     {
//         break;
//     }

//     count = count + Int32.Parse(input);

// }

// System.Console.WriteLine(count);

// System.Console.WriteLine("Enter a number");
// var input = Int32.Parse(Console.ReadLine());
// double result = 1;

// while (input != 1)
// {
//     result = result * input;
//     input--;
// }

// System.Console.WriteLine(result);

// int trys = 4;
// Random rnd = new Random();
// int secret = rnd.Next(1, 10);

// while (trys > 0)
// {
//     System.Console.WriteLine(String.Format("you now have {0} chances to guess the number. Enter one now", trys));
//     int input = Int32.Parse(Console.ReadLine());
//     if (input == secret)
//     {
//         System.Console.WriteLine("That's Correct!");
//         break;
//     }

//     System.Console.WriteLine("Try Again");
//     trys--;

// }

// System.Console.WriteLine("Enter a series of CSV numbers");
// string input = Console.ReadLine();
// int largest_number = 0;

// foreach (char c in input)
// {
//     string digit = c.ToString();
//     if (digit != "," && Int32.Parse(digit) > largest_number)
//     {
//         largest_number = Int32.Parse(digit);
//     }
// }

// // System.Console.WriteLine(largest_number);

// List<string> names = new List<string>();
// while (true)
// {
// System.Console.WriteLine("Keep entering names or press Enter to exit");
// var name = Console.ReadLine();

// if (string.IsNullOrEmpty(name))
// break;
// else
// names.Add(name);

// if (names.Count() <= 3)
// System.Console.WriteLine(String.Join(", ", names));
// else
// {
// List<string> three_names = new List<string>();
// three_names = names.GetRange(0, 3);
// System.Console.WriteLine(String.Join(", ", three_names) + " ...and more");
// }

// }

// System.Console.WriteLine("Enter your name");
// string name = System.Console.ReadLine();
// int name_length = name.Count();
// char[] characters;

// characters = name.ToCharArray(0, name_length);

// Array.Reverse(characters, 0, name_length);
// System.Console.WriteLine(String.Join("", characters));

// System.Console.WriteLine("Enter 5 nums");
// List<int> nums = new List<int>();

// while (true)
// {
//     System.Console.WriteLine(String.Format("Count: {0}", nums.Count()));
//     int num = Convert.ToInt32(Console.ReadLine());

//     if (nums.Contains(num))
//     {
//         System.Console.WriteLine("You have already added this number, try again");
//         continue;
//     }

//     nums.Add(num);

//     if (nums.Count() == 5)
//     {
//         break;
//     }
// }

// nums.Sort();

// System.Console.WriteLine(String.Join("", nums));

// System.Console.WriteLine("Enter a list of number");
// List<int> nums = new List<int>();

// while (true)
// {
//     System.Console.WriteLine(String.Format("Count: {0}", nums.Count()));
//     string value = Console.ReadLine();

//     if (value.ToLower() == "quit")
//     {
//         System.Console.WriteLine(String.Join(" ", nums));
//         System.Environment.Exit(0);
//     }

//     int num = Convert.ToInt32(value);

//     if (!nums.Contains(num))
//     {
//         nums.Add(num);
//     }
// }




// System.Console.WriteLine("Enter a list of numbers");

// while (true)
// {
//     string value = Console.ReadLine();

//     string[] values = value.Split(',');
//     List<int> int_values = new List<int>();

//     foreach (string number in values)
//     {
//         int num = Convert.ToInt32(number);
//         int_values.Add(num);
//     }

//     if (int_values.Count() <= 3)
//     {
//         System.Console.WriteLine("Try again, this time with 5 or more numbers");
//         continue;
//     }

//     int_values.Sort();
//     List<int> number_list = int_values.GetRange(0, 3);
//     System.Console.WriteLine(String.Join(",", number_list));

//     break;
// }


// System.Console.WriteLine("Enter a list of numbers separated by a hyphen");
// string value = "3-5-4-7";
// string[] values = value.Split('-');
// List<int> int_values = new List<int>();

// foreach (string number in values)
// {
//     int num = Convert.ToInt32(number);
//     int_values.Add(num);
// }

// List<int> sorted_values = new List<int>(int_values);
// sorted_values.Sort();

// if (int_values == sorted_values)
//     System.Console.WriteLine("Consecutive");
// else
//     System.Console.WriteLine("Non Consecutive");

// System.Console.WriteLine("Enter a list of numbers separated by a hyphen");
// string value = "";
// try
// {
//     value = Console.ReadLine();
// }
// catch
// {
//     System.Environment.Exit(0);
// }

// string[] values = value.Split('-');
// List<string> new_values = new List<string>();

// foreach (string entry in values)
// {
//     if (new_values.Contains(entry))
//         System.Console.WriteLine("Duplicate");
//     else
//         new_values.Add(entry);
// }


using System.Globalization;

// System.Console.WriteLine("Enter a 24hr time value");
// string value = "";

// try
// {
//     value = Console.ReadLine();
// }
// catch
// {
//     System.Environment.Exit(0);
// }
// DateTime date = new DateTime();

// try
// {
//     date = DateTime.Parse(value);

//     System.Console.WriteLine("OK");
// }
// catch
// {
//     System.Console.WriteLine(value + " is invalid");
// }


// var yourString = Console.ReadLine().ToLower().Replace("_", " ");
// TextInfo info = CultureInfo.CurrentCulture.TextInfo;
// yourString = info.ToTitleCase(yourString).Replace(" ", string.Empty);
// Console.WriteLine(yourString);