using System.Text;

namespace Diamond.Core;

public class DiamondKata : IDiamondKata
{
    public string GetDiamondKata(string input)
    {
        if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || input[0] < 'A' || input[0] > 'Z')
        {
            return string.Empty;
        }

        var letter = input[0];

        var result = new StringBuilder();

        var depth = letter - 'A';
        var directionI = 1;
        for (int i = 0; i >= 0; i += directionI)
        {
            var rawLetter = (char)('A' + i);

            var directionJ = 1;
            for (int j = 0; j >= 0; j += directionJ)
            {
                if (j == depth - i)
                {
                    result.Append(rawLetter);
                }
                else
                {
                    result.Append(' ');
                }

                if (j == depth)
                {
                    directionJ = -directionJ;
                }
            }

            result.AppendLine();

            if (i == depth)
            {
                directionI = -directionI;
            }
        }
        return result.ToString();
    }
}