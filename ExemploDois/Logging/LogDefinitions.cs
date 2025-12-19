using Code.Parts.Api.ExemploDois.Logging.ClassificationAttributes;

namespace Code.Parts.Api.Utils;

public static partial class LoggingDefinitions
{
    [LoggerMessage(
        EventId = 1, Level = LogLevel.Information,
        Message = "Processando pagamento do Cliente: {FullName} - Cpf: {Cpf} com Cartão: {CreditCardNumber}")]
    public static partial void LogInformacoesCliente(
        this ILogger logger, 
        string fullName,
        [CartaoCredito] string creditCardNumber,
        [Cpf] string cpf);
}