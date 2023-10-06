namespace Prog_122_Lecture_6_Example_CSReview
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userNumber = Console.ReadLine();
            // How do we parse in c#
            // type.Parse(string stringWeAreTryingToConvert);
            // casting is trying to turn something into a different related type
            int convertedNumber = (int)5.4854;
            // - 100 to 100
            // -100.000000 to 100.0000

            Console.WriteLine(convertedNumber + convertedNumber);

            

            // Loops
            // Conditions
            // Operations
            // Arrays
            // Scope
            // Methods


        } // Main

        public static void DebuggingAndMethodExample()
        {
            Console.WriteLine("Greetings Class");
            // Calling A Method
            SayHello();
            Console.WriteLine("Goodbye Class");
            // Discussing Debugging
            // Breakpoint

        } // DebuggingAndMethodExample()

        // Create a new method
        public static void SayHello()
        {
            // cw tab is the shortcut for console writeline
            Console.WriteLine("Hello, World");

            VariableNotes();

        }


        // To create a method
        // public static void Name()
        public static void VariableNotes()
        {
            // Variables
            // C# is strongly typed language
            // we DECLARE the TYPE when we FIRST INITIALIZE
            // string, int, double, bool
            // String - a collection of characters
            //  - character : single symbol surround by single quotes
            // 'a'
            // int - whole numbers
            // double - decimal numbers
            // bool - true or false

            // Declare and Initialize
            // DECLARE is where you first give your variable a type and name
            // INITILAIZE is the first time you assign a value to your variable
            string name = "Will";
            char singleLetter = 'C';

            // int number
            // number = 3

            // Whole Number - Integral
            // int and double
            int wholeNumber;
            //sbyte range = 128;
            byte unsigned = 255;

            // Decimal is called a Floating Point
            double numbersWithDecimalPoints = 0;


            // HOw to comment out a line hotkey
            // Ctrl + K, Ctrl + C
            // Uncomment is 
            // Ctrl + K, Ctrl + U

            // Copy is Ctrl + C
            // Paste is Ctrl + V
            // Cut is Ctrl + X
            // Undo is Ctrl + Z
            // Save the current file is Ctrl + S

            string iWantToCutThisLine = "This Line";


        } // VariableNotes()

    } // class

} // namespace