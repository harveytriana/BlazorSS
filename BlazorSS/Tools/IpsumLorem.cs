using System.Text;

namespace Tools;

public class IpsumLorem
{
    static readonly string[] words = [
        "lorem", "ipsum", "dolor", "sit", "amet", "consectetur",
        "adipiscing", "elit", "sed", "do", "eiusmod", "tempor",
        "incididunt", "ut", "labore", "et", "dolore", "magna",
        "aliqua", "enim", "ad", "minim", "veniam", "quis",
        "nostrud", "exercitation", "ullamco", "laboris", "nisi",
        "ut", "aliquip", "ex", "ea", "commodo", "consequat"
    ];

    static readonly Random random = new(DateTime.Now.Millisecond);

    public static string GenerateParagraph(int numberOfWords, bool endBlankLine = false)
    {
        StringBuilder paragraph = new();

        for(int i = 0; i < numberOfWords; i++) {
            int index = random.Next(words.Length);
            paragraph.Append(words[index]);
            paragraph.Append(' ');
        }
        return paragraph.ToString().Trim() + (endBlankLine ? "\n" : "");
    }
}
