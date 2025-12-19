using Microsoft.Extensions.Compliance.Classification;

namespace Code.Parts.Api.ExemploDois.Logging.ClassificationAttributes;

public class CartaoCreditoAttribute : DataClassificationAttribute
{
    public CartaoCreditoAttribute() 
        : base(InformationClassifications.CartaoCredito)
    {
    }
}