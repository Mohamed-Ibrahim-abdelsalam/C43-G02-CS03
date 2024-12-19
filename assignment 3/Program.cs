namespace assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1 Write a program that allows the user to enter a number then print it.

            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();


            Console.WriteLine("You entered: " + input);
            #endregion


            #region Q2 Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen



            string input1 = "123abc";

            try
            {

                int numbers = int.Parse(input1);
                Console.WriteLine("Conversion succeeded: " + numbers);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: The input contains non-numeric characters and cannot be converted to an integer.");
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
            }


            #endregion


            #region Q3 Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen


            float number1 = 5.5f;
            float number2 = 2.2f;

            float sum = number1 + number2;
            float difference = number1 - number2;
            float product = number1 * number2;
            float quotient = number1 / number2;

            Console.WriteLine("Number1: " + number1);
            Console.WriteLine("Number2: " + number2);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);


            #endregion


            #region Q4  Write C# program that Extract a substring from a given string.


            string input2 = "Hello, welcome to C# programming!";


            int startIndex = 7;
            int length = 7;


            if (startIndex >= 0 && startIndex + length <= input2.Length)
            {

                string substring = input2.Substring(startIndex, length);
                Console.WriteLine("Original String: " + input2);
                Console.WriteLine("Extracted Substring: " + substring);
            }
            else
            {
                Console.WriteLine("Invalid range for substring extraction.");
            }
            #endregion


            #region Q5 Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


            int num1 = 10;
            int num2 = num1;

            Console.WriteLine("Before modification:");
            Console.WriteLine("Number1: " + num1);
            Console.WriteLine("Number2: " + num2);

            number1 = 20;

            Console.WriteLine("\nAfter modifying Number1:");
            Console.WriteLine("Number1: " + num1);
            Console.WriteLine("Number2: " + num2);


            #endregion

            #region Q6 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            string str1 = "Hello";
            string str2 = str1;

            str2 = "Goodbye";

            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"str2: {str2}");


            #endregion


            #region Q7 Write C# program that take two string variables and print them as one variable 


            Console.Write("Enter the first string: ");
            string string1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string string2 = Console.ReadLine();

            // Concatenate the two strings
            string result = string1 + string2;

            // Print the concatenated result
            Console.WriteLine("\nThe combined string is: " + result);



            #endregion


            #region Q8 Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 


            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rate of interest (in %): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double interest = (principal * rate * time) / 100;


            Console.WriteLine("\nThe Simple Interest is: " + interest);

            #endregion


            #region Q9 Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 


            Console.Write("Enter weight (in kilograms): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);


            Console.WriteLine("\nThe Body Mass Index (BMI) is: " + bmi);

            #endregion


            #region Q10  Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 

            Console.Write("Enter the temperature in degrees: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            string result1 = (temperature < 10) ? "Just Cold" :
                            (temperature > 30) ? "Just Hot" :
                            "Just Good";

            Console.WriteLine("\nThe temperature is: " + result1);

            #endregion


            #region Q11 Write a program that takes the date from the user and displays it in various formats using string interpolation.


            Console.Write("Enter today's date (dd, MM, yyyy): ");
            string input3 = Console.ReadLine();


            DateTime date;
            if (DateTime.TryParseExact(input, "dd, MM, yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {

                Console.WriteLine($"\nToday's date : {date:dd , MM , yyyy}");
                Console.WriteLine($"Today's date : {date:dd / MM / yyyy}");
                Console.WriteLine($"Today's date : {date:dd – MM – yyyy}");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
            #endregion


            #region Q12 Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            #endregion

            #region Q13 Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.


            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }


            #endregion

            #region Q14 Write a program that takes 3 integers from the user then prints the max element and the min element.

            Console.Write("Enter the first number: ");
            int numb1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(numb1, Math.Max(numb2, num3));
            int min = Math.Min(numb1, Math.Min(numb2, num3));


            Console.WriteLine($"\nMax element = {max}");
            Console.WriteLine($"Min element = {min}");

            #endregion


            #region Q15  Write a program that allows the user to insert an integer number then check If a number is even or odd.

            Console.Write("Enter an integer: ");
            int numb3 = Convert.ToInt32(Console.ReadLine());

            if (numb3 % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            #endregion

            #region Q16 Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            Console.Write("Enter a character: ");
            char character = Convert.ToChar(Console.ReadLine().ToLower());

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }


            #endregion

            #region Q17 Write a program to input the month number and print the number of days in that month.

            Console.Write("Enter the month number (1 to 12): ");
            int month = Convert.ToInt32(Console.ReadLine());


            int days;
            switch (month)
            {
                case 1:  // January
                case 3:  // March
                case 5:  // May
                case 7:  // July
                case 8:  // August
                case 10: // October
                case 12: // December
                    days = 31;
                    break;
                case 4:  // April
                case 6:  // June
                case 9:  // September
                case 11: // November
                    days = 30;
                    break;
                case 2:  // February
                    Console.Write("Enter the year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    // Check for leap year
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        days = 29; // Leap year
                    }
                    else
                    {
                        days = 28; // Non-leap year
                    }
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    return;
            }

            // Print the number of days in the month
            Console.WriteLine($"Days in Month: {days}");




            #endregion


        }
    }
}
