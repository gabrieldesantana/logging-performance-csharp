using Microsoft.Extensions.Compliance.Redaction;

namespace Code.Parts.Api.ExemploDois.Logging.Redactors;

public class CpfRedactor : Redactor
{
    // O formato final é sempre 14 caracteres: 123.XXX.XXX-12
    public override int GetRedactedLength(ReadOnlySpan<char> input) => 14;

    public override int Redact(ReadOnlySpan<char> source, Span<char> destination)
    {
        int separatorIndex = source.IndexOf(':');
        int lengthToProcess = separatorIndex == -1 ? source.Length : separatorIndex;
        var actualData = source.Slice(0, lengthToProcess);

        Span<char> digits = stackalloc char[32]; 
        int digitCount = 0;

        for (int i = 0; i < actualData.Length && digitCount < digits.Length; i++)
        {
            if (char.IsDigit(actualData[i]))
            {
                digits[digitCount++] = actualData[i];
            }
        }

        if (digitCount != 11)
        {
            destination.Fill('*');
            return destination.Length;
        }

        // Primeiros 3
        destination[0] = digits[0];
        destination[1] = digits[1];
        destination[2] = digits[2];

        // Ponto e Máscara
        destination[3] = '.';
        destination[4] = 'X';
        destination[5] = 'X';
        destination[6] = 'X';
        destination[7] = '.';
        destination[8] = 'X';
        destination[9] = 'X';
        destination[10] = 'X';
        destination[11] = '-';

        // Últimos 2
        destination[12] = digits[9];
        destination[13] = digits[10];

        // Retorna 14 (tamanho fixo da máscara)
        return 14;
    }
}