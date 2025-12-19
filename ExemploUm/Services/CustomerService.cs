using Code.Parts.Api.Commons.Entities;
using Code.Parts.Api.ExemploUm.Extensions;

namespace Code.Parts.Api.ExemploUm.Services;

public class CustomerService(ILogger<CustomerService> logger)
    : Code.Parts.Api.ExemploUm.Interfaces.ICustomerService
{
    private readonly ILogger<CustomerService> _logger = logger;

    public Task ObterClientePorCpf(string cpf)
    {
        Customer customer = new("João da Silva", "1234567890123456", "123.456.789-00");

        var message = $"Processando pagamento do Cliente: {customer.FullName} - Cpf: {customer.Cpf.MascararCpf()} com Cartão: {customer.CreditCardNumber.MascararCartao()}";
        _logger.LogInformation(message);
        return Task.FromResult(true);
    }
}
