namespace Code.Parts.Api.ExemploDois.Interfaces;

public interface ICustomerService
{
    Task ObterClientePorCpf(string cpf);
}
