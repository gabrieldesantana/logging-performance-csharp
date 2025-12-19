namespace Code.Parts.Api.ExemploUm.Interfaces;

public interface ICustomerService
{
    Task ObterClientePorCpf(string cpf);
}
