using Code.Parts.Api.ExemploDois.Logging.Redactors;
using Code.Parts.Api.ExemploDois.Logging;
using Microsoft.Extensions.Compliance.Classification;
using Microsoft.Extensions.Compliance.Redaction;

namespace Code.Parts.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddLogging(builder =>
            {
                builder.EnableRedaction();
            });

            services.AddRedaction(cfg =>
            {
                cfg.SetRedactor<CreditCardRedactor>(new DataClassificationSet(InformationClassifications.CartaoCredito));
                cfg.SetRedactor<CpfRedactor>(new DataClassificationSet(InformationClassifications.Cpf));
                cfg.SetFallbackRedactor<ErasingRedactor>();
            });

            services.AddScoped<Code.Parts.Api.ExemploUm.Interfaces.ICustomerService, Code.Parts.Api.ExemploUm.Services.CustomerService>();

            services.AddScoped<Code.Parts.Api.ExemploDois.Interfaces.ICustomerService, Code.Parts.Api.ExemploDois.Services.CustomerService>();

            services.AddSingleton<CreditCardRedactor>();
        }
    }
}
