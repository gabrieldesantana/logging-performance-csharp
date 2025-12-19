using Code.Parts.Api.ExemploDois.Logging.ClassificationAttributes;

namespace Code.Parts.Api.Commons.Entities;

public record Customer(
    string FullName,
    [CartaoCredito] 
    string CreditCardNumber,
    [Cpf]
    string Cpf);
