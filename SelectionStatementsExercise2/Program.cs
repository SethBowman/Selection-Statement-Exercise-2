namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("what is your favorite subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I dislike math");
                    break;
                case "science":
                    Console.WriteLine("Science rules");
                    break;
                case "pe":
                case "p.e.":
                    Console.WriteLine("P.E. is awesome");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite");
                    break;
                default:
                    Console.WriteLine("I forgot about that one");
                    break;
            }
        }
    }
}