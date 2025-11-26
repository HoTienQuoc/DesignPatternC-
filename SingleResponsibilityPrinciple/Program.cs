namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today.");
            journal.AddEntry("I ate a bug.");

            Console.WriteLine(journal);

            var p = new Persistence();
            var filename = "journal.txt";
            p.SaveToFile(journal, filename, true);

        }
    }
}