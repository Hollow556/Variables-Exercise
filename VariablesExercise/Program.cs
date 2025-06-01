namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Brandon";
            int age = 39;
            char middleInitial = 'L';
            bool isEmployed = true;
            double salary = 40000.00;
            Decimal totalSavings = 259.74m;

            Console.WriteLine($"My name is {firstName} {middleInitial}. I am {age} years old. " +
                              $"I am currently employed: {isEmployed}. My salary is {salary:C}. " +
                              $"I have a total savings of {totalSavings:C}.");
        }
    }
}
