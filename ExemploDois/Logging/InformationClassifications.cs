using Microsoft.Extensions.Compliance.Classification;

namespace Code.Parts.Api.ExemploDois.Logging;

public static class InformationClassifications
{
    public static string Name = "DadosSensiveis";

    public static DataClassification CartaoCredito
        = new(Name, nameof(CartaoCredito));

    public static DataClassification Cpf
        = new(Name, nameof(Cpf));
}
