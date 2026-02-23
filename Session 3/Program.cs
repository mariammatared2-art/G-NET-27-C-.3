namespace Session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region QUESTION 1
            //    1.What will this print and explain what happens ?

            //     double d = 9.99;
            //    int x = (int)d;
            //    Console.WriteLine(x);

            //Output: 9
            //     Explanation: Casting a double to an int.

            #endregion

            #region QUESTION 2
            //2. This code doesn’t compile. Fix it with the smallest change?
            // int n = 5;
            // double d2 = n / 2;
            // Console.WriteLine(d2);

            // int n = 5;
            // double d2 = n / 2.0;
            // Console.WriteLine(d2);
            #endregion

            #region QUESTION 3
            //3. You read a number from user input .. Write the correct line to get age as int.

            //  int age = int.Parse(Console.ReadLine());
            #endregion

            #region QUESTION 4
            //4. What happens here and why?
            //string s = "12a";
            // int x = int.Parse(s);
            // Console.WriteLine(x);

            // Result: FormatException (Runtime Error).
            // Why: int.Parse expects only numeric characters; "a" is invalid.

            #endregion

            #region QUESTION 5
            /*5. Complete the code from the previous question so it prints
            Invalid if conversion into int fails, otherwise prints the number*/
            // string s = "12a";
            // if (int.TryParse(s, out int result)) Console.WriteLine(result);
            // else Console.WriteLine("Invalid");
            #endregion

            #region QUESTION 6
            //6. What will this print and explain why ?
            // object o = 10;
            // int a = (int)o;
            // Console.WriteLine(a + 1);

            // Output: 11
            // Why: This is unboxing. The object 'o' holds an int, it is cast back to an int, 
            // and then 1 is added to the value.
            #endregion

            #region QUESTION 7
            //7. What will this print and explain why and if there is a problem handle it ?
            //object o = 10;
            //long x = (long)o;
            //Console.WriteLine(x);

            // Result: InvalidCastException.
            // Why: Unboxing requires the exact type stored (int). You cannot unbox an int directly to a long.

            // object o = 10;
            // long x = (long)(int)o;
            // Console.WriteLine(x);
            #endregion


        }
    }
}
