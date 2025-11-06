
namespace ProjectTwoNew;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input your paragraph.");
        string paragraph = Console.ReadLine();
        string[] words = paragraph.Split();
        int wordCount = 0;
        /* for (int i=0; i<words.Length; i++)
        {
            Console.WriteLine(words[i]); 
        }*/

        //avoid empty spaces

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                wordCount++;

            }
        }
        Console.WriteLine($"The word count is {wordCount} ");
        //count char number

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
