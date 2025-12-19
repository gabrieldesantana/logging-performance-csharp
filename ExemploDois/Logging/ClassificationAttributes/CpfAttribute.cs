using Microsoft.Extensions.Compliance.Classification;

namespace Code.Parts.Api.ExemploDois.Logging.ClassificationAttributes;

public class CpfAttribute : DataClassificationAttribute
{
    public CpfAttribute()
        : base(InformationClassifications.Cpf)
    {
    }
}
