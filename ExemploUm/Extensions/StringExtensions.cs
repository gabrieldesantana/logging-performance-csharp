namespace Code.Parts.Api.ExemploUm.Extensions;

public static class StringExtensions
{
    public static string MascararCartao(this string cardNumber)
    {
        var digits = new string(cardNumber.Where(char.IsDigit).ToArray());
        if (digits.Length < 4) return cardNumber;

        return new string('*', digits.Length - 4) + digits[^4..];
    }

    public static string MascararCpf(this string cpf)
    {
        if (string.IsNullOrEmpty(cpf)) return string.Empty;

        string apenasDigitos = new string(cpf.Where(char.IsDigit).ToArray());

        if (apenasDigitos.Length != 11)
        {
            return cpf;
        }

        return $"{apenasDigitos.Substring(0, 3)}.XXX.XXX-{apenasDigitos.Substring(9, 2)}";
    }
}
