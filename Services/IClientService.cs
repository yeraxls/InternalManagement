using InternalManagement.Models;

public interface IClientService
{
    Task<List<Client>> GetClients();
    Task<Client> GetClientById(int idClient);
    Task CreateNewClient(Client client);
    Task UpdateClient(Client client);
    Task DeleteClient(int id);
}