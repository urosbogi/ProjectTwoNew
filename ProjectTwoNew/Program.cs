
namespace ProjectTwoNew;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input your paragraph.");
        string paragraph = Console.ReadLine();
        string[] words = paragraph.Split();
        int wordCount = 0;
        Console.WriteLine($"The word count is {wordCount = words.Length} ");

        int letterNumber = 0;
        foreach (string word in words)
        {
            int templetterNumber = word.Length;
            letterNumber = templetterNumber + letterNumber;
        }
        Console.WriteLine($"test number: {letterNumber}");

        // Console.WriteLine("testing to see the results: {1}", paragraph, paragraph.Length);
        
    }
}
