using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                " and of having nothing to do: once or twice she had peeped into the book her sister was reading," +
                " but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice ' without pictures " +
                "or conversation?";
            Console.WriteLine("Please provide term to search:");
            string userSearchTerm = Console.ReadLine();
            int termFound = firstSentence.ToLower().IndexOf(userSearchTerm.ToLower());
            if (termFound >= 0)
            {
                Console.WriteLine("Search term found. First index within sentence is " + termFound + " and has a length of " + userSearchTerm.Length + ".");
                firstSentence = firstSentence.Remove(termFound, userSearchTerm.Length);
                Console.WriteLine(firstSentence);
            } else
            {
                Console.WriteLine("Search term not found.");
            }
        }
    }
}
