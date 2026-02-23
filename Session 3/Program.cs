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
        }
    }
}
