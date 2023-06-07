using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammedGufran.Merchant.BDAT1004PS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine ("Hello Mono World");

            //==================================================
            Console.WriteLine("\n =================Question 1:=========================== \n");
            Console.WriteLine("\n Qusetion 1: What data type is each of the following? \n");
            //Qusetion 1:What data type is each of the following? 

            Console.WriteLine("\n =================Answer 1:=========================== \n");
            //=========Answer 1:================================

            Console.WriteLine("5: Integer");
            Console.WriteLine("5.0: Double");
            Console.WriteLine("5 > 1: Boolean");
            Console.WriteLine("'5': Character");
            Console.WriteLine("5 * 2: Integer");
            Console.WriteLine("'5' * 2: This operation is not valid in C#.");
            Console.WriteLine("'5' + '2': This operation is not valid in C#.");
            Console.WriteLine("5 / 2: Integer");
            Console.WriteLine("5 % 2: Integer");
            Console.WriteLine("{5, 2, 1}: Array (int[])");
            Console.WriteLine("5 == 3: Boolean");
            Console.WriteLine("Pi (the number): In C#, you would typically use the Math.PI constant, which is a Double data type.");

            
            //=====================================================
            Console.WriteLine("\n =================Question 2:===========================\n ");
            Console.WriteLine("\n Question 2: Write (and evaluate) C# expressions that answer these questions: a. How many letters are there in 'Supercalifragilisticexpialidocious'? b. Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring? c. To determine the longest word among 'Supercalifragilisticexpialidocious', 'Honorificabilitudinitatibus', and 'Bababadalgharaghtakamminarronnkonn': d. To determine the composer that comes first and the one that comes last in the given list: \n");

            //=================Answer 2:===========================
            Console.WriteLine("\n =================Answer 2:=========================== \n");
            // a. To determine the number of letters in the string 'Supercalifragilisticexpialidocious':

            string word = "Supercalifragilisticexpialidocious";
            int letterCounter = word.Length;
            Console.WriteLine("a. Number of letters: " + letterCounter);

            //b. To check if the string 'Supercalifragilisticexpialidocious' contains 'ice' as a substring:

            bool containsIce = word.Contains("ice");
            Console.WriteLine("b. Contains 'ice': " + containsIce);

            //c. To determine the longest word among 'Supercalifragilisticexpialidocious', 'Honorificabilitudinitatibus', and 'Bababadalgharaghtakamminarronnkonn':

            //string wd1 = "Supercalifragilisticexpialidocious";
            //string wd2 = "Honorificabilitudinitatibus";
            //string wd3 = "Bababadalgharaghtakamminarronnkonn";

            //string longestWord = "";

            //if (wd1.Length > wd2.Length && wd1.Length > wd3.Length)
            //longestWord = wd1;
            //else if (wd2.Length > wd1.Length && wd2.Length > wd3.Length)
            //longestWord = wd2;
            //else if (wd3.Length > wd1.Length && wd3.Length > wd2.Length)
            //longestWord = wd3;

            //Console.WriteLine($"Longest word: {longestWord}");

            string word1 = "Supercalifragilisticexpialidocious";
            string word2 = "Honorificabilitudinitatibus";
            string word3 = "Bababadalgharaghtakamminarronnkonn";

            List<string> longestWords = new List<string>();

            int maxLength = 0;

            if (word1.Length >= maxLength)
            {
                if (word1.Length > maxLength)
                {
                    maxLength = word1.Length;
                    longestWords.Clear();
                }
                longestWords.Add(word1);
            }

            if (word2.Length >= maxLength)
            {
                if (word2.Length > maxLength)
                {
                    maxLength = word2.Length;
                    longestWords.Clear();
                }
                longestWords.Add(word2);
            }

            if (word3.Length >= maxLength)
            {
                if (word3.Length > maxLength)
                {
                    maxLength = word3.Length;
                    longestWords.Clear();
                }
                longestWords.Add(word3);
            }

            Console.WriteLine("c. Longest words:");
            foreach (string words in longestWords)
            {
                Console.WriteLine(words);
            }

            //d. To determine the composer that comes first and the one that comes last in the given list:

            string[] composers = { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };

            Array.Sort(composers);

            string firstComposer = composers[0];
            string lastComposer = composers[composers.Length - 1];

            Console.WriteLine("d. First composer & Last composer: ");
            Console.WriteLine("First composer: " + firstComposer);
            Console.WriteLine("Last composer: " + lastComposer);


            Console.WriteLine("\n =================Question 3:===========================\n ");
            Console.WriteLine("\n Implement function triangleArea(a,b,c) that takes as input the lengths of the 3 sides of a triangle and returns the area of the triangle. By Heron's formula, the area of a triangle with side lengths a, b, and c is s(s − a)(s − b)(s − c), where s = (a + b + c)/2. \n");

            //Implement function triangleArea(a,b,c) that takes as input the lengths of the 3 sides of a triangle and returns the area of the triangle. By Heron's formula, the area of a triangle with side lengths a, b, and c is s(s − a)(s − b)(s − c), where s = (a + b + c)/2. 

            Console.WriteLine("\n ==============================Answer 3:================================ \n");

            Console.WriteLine("Enter the length of side a:");
            string inputA = Console.ReadLine();
            int a;

            Console.WriteLine("Enter the length of side b:");
            string inputB = Console.ReadLine();
            int b;

            Console.WriteLine("Enter the length of side c:");
            string inputC = Console.ReadLine();
            int c;

            if (int.TryParse(inputA, out a) && int.TryParse(inputB, out b) && int.TryParse(inputC, out c))
            {
                double area = TriangleArea(a, b, c);
                Console.WriteLine("The area of the triangle is: " + area);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integer values for the sides of the triangle.");
            }

            //Question 4
            Console.Write("\n =================== Question 4:================== \n");
            Console.Write("\n Write a program in C# Sharp to separate odd and even integers in separate arrays. \n");

            Console.Write("\n ===================== Answer 4:================== \n");


            Console.Write("\n Input the number of elements to be stored in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int[] evenArray = new int[n];
            int[] oddArray = new int[n];
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine($"Input {n} elements in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] % 2 == 0)
                {
                    evenArray[evenCount] = arr[i];
                    evenCount++;
                }
                else
                {
                    oddArray[oddCount] = arr[i];
                    oddCount++;
                }
            }

            Console.Write("The Even elements are: ");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write(evenArray[i] + " ");
            }

            Console.Write("\nThe Odd elements are: ");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write(oddArray[i] + " ");
            }
            Console.WriteLine();

            Console.Write("\n =================== Question 5:================== \n");
            Console.Write("\n a. Write a function inside(x,y,x1,y1,x2,y2) that returns True or False depending on whether the point (x,y) lies in the rectangle with lower left corner (x1,y1) and upper right corner (x2,y2). \n");

            Console.Write("\n =================== Answer 5.a:================== \n");

            Console.WriteLine($" inside(1,1,0,0,2,3): {Inside(1, 1, 0, 0, 2, 3)}");    // True
            Console.WriteLine($" inside(-1,-1,0,0,2,3) : {Inside(-1, -1, 0, 0, 2, 3)}");  // False

            Console.Write("\n b. Use function inside() from part a. to write an expression that tests whether the point (1,1) lies in both of the following rectangles: one with lower left corner (0.3, 0.5) and upper right corner (1.1, 0.7) and the other with lower left corner (0.5, 0.2) and upper right corner (1.1, 2). \n");

            Console.Write("\n =================== Answer 5.b:================== \n");

            Console.WriteLine($" point (1,1) lies in both of the following rectangles: {Inside(1, 1, 0.3, 0.5, 1.1, 0.7) && Inside(1, 1, 0.5, 0.2, 1.1, 2)}");


        }

        public static double TriangleArea(int a, int b, int c)
        {
            double s = (a + b + c) / 2.0;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static bool Inside(int x, int y, double x1, double y1, double x2, double y2)
        {
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

        
}
