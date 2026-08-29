namespace Assign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true. Use the && operator.
            int pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
                Console.WriteLine("You can borrow this book.");
            #endregion

            #region 2. Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great Choice");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

            }
            #endregion

            #region 3. Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel (same rule as question 6: long if pages > 300).
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region 4. Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1. Clean Code.
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
                Console.WriteLine($" {i + 1}. {books[i]}");
            #endregion

            #region 5. Using the same books array, use a while loop to print every book title.
            int j = 0;
            while (j < books.Length)
            {
                Console.WriteLine($"{books[j]}");
                j++;
            }
            #endregion


            #region 6. Write a do-while loop that prints "Checking book..." exactly 3 times.
            int k = 0;
            do
            {
                Console.WriteLine("Checking book...");
                k++;
            } while (k < 3);
            #endregion

            #region 7. Using the same books array, use a foreach loop to print every book title.
            foreach (string b in books)
            {
                Console.WriteLine(b);
            } 
            #endregion

        }
    }
}
