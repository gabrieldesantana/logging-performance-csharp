using Code.Parts.Api.ExemploDois.Interfaces;
using Code.Parts.Api.Commons.Entities;
using Code.Parts.Api.Utils;

namespace Code.Parts.Api.ExemploDois.Services;

public class CustomerService : ICustomerService
{
    private readonly ILogger<CustomerService> _logger;
    public CustomerService(ILogger<CustomerService> logger)
    {
        _logger = logger;
    }
    public Task ObterClientePorCpf(string cpf)
    {
        Customer customer = new("João da Silva", "1234567890123456", cpf);

        _logger.LogInformacoesCliente(customer.FullName, customer.CreditCardNumber, customer.Cpf);
        return Task.FromResult(true);
    }
}
