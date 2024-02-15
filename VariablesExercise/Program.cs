namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Bryan Durushia";

            int myAge = 29;

            char myFirstInitial = 'B';
            char myLastInitial = 'D';

            bool isMarried = false;

            decimal cash = 76.54m;
            double exactAge = 29.53;

            Console.WriteLine($"My name is {myName}.\nI am {myAge} years old, but my exact age is {exactAge}.\nMy initials are {myFirstInitial}{myLastInitial}.");
            Console.WriteLine($"If you'd assume that I am married, that is {isMarried}.\nI have ${cash} in my wallet.");
        }
    }
}