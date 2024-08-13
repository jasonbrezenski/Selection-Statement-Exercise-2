namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            SchoolSubject();
        }

        public static void SchoolSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is cool because it's all about solving problems!");
                    break;

                case "science":
                    Console.WriteLine("Science is all around us in real-world applications.");
                    break;

                case "art":
                    Console.WriteLine("Art is a fun class to do!");
                    break;

                case "social studies":
                    Console.WriteLine("Social Studies is great if you like history.");
                    break;

                case "accounting":
                    Console.WriteLine("Accounting is my favorite subject also!");
                    break;

                default:
                    Console.WriteLine("Interesting choice! What do you like about it ?");
                    break;
            }
        }

    }
}