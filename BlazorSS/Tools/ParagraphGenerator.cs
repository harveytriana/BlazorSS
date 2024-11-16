using System.Text;

namespace Tools;

public class ParagraphGenerator
{
    public static string GenerateParagraph(int numberOfWords)
    {
        string[] words = {
            "Lorem", "ipsum", "dolor", "sit", "amet",
            "consectetur", "adipiscing", "elit", "sed",
            "do", "eiusmod", "tempor", "incididunt", "ut",
            "labore", "et", "dolore", "magna", "aliqua"
        };

        StringBuilder paragraph = new();

        for(int i = 0; i < numberOfWords; i++) {
            int index = Random.Shared.Next(words.Length);
            paragraph.Append(words[index]);
            paragraph.Append(' ');
        }
        return paragraph.ToString().Trim();
    }

    public static string GenerateParagraph(int minNumberOfWords = 2, int maxNumberOfWords = 20)
    {
        // filter
        if(minNumberOfWords < 0) { minNumberOfWords = 2; }
        if(maxNumberOfWords > 200) { maxNumberOfWords = 200; }
        if(minNumberOfWords > maxNumberOfWords) { return string.Empty; }

        var n = Random.Shared.Next(minValue: minNumberOfWords, maxValue: maxNumberOfWords);
        return GenerateParagraph(n);
    }
}
