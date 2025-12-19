using Microsoft.Extensions.Compliance.Redaction;

namespace Code.Parts.Api.ExemploDois.Logging.Redactors;

public class CreditCardRedactor : Redactor
{
    public override int GetRedactedLength(ReadOnlySpan<char> input) => input.Length;

    public override int Redact(ReadOnlySpan<char> source, Span<char> destination)
    {
        int separatorIndex = source.IndexOf(':');

        int numberLength = separatorIndex == -1 ? source.Length : separatorIndex;

        if (numberLength <= 4)
        {
            for (int i = 0; i < numberLength; i++) destination[i] = '*';
            return numberLength;
        }

        int safeZoneStartIndex = numberLength - 4;

        for (int i = 0; i < numberLength; i++)
        {
            if (i < safeZoneStartIndex)
            {
                destination[i] = '*';
            }
            else
            {
                destination[i] = source[i];
            }
        }

        return numberLength;
    }
}
