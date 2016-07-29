using System;
using Personal;

using static System.Console;

namespace HelloWorld
{
    public class MainCls
    {

        #region Variables.
        private const string HeaderDoubleDash = "======================================================================================================";
        private const string HeaderSingleDash = "------------------------------------------------------------------------------------------------------";
        #endregion

        public static void Main(string[] args)
        {
            var color = args.Length > 0 ? args[0] : "Cyan";
            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);

            var person1 = new Person();
            DisplayOutput("Person Information:", person1.ToString());

            WriteLine("\n\nPress ENTER key ...");
            ReadLine();
        }

        private static void DisplayOutput(string titile, string outputData)
        {
            WriteLine(HeaderDoubleDash);
            WriteLine(titile);
            WriteLine(HeaderSingleDash);
            WriteLine(outputData);
            WriteLine(HeaderDoubleDash);
        }
    }

}
