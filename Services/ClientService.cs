using InternalManagement.Models;

public class ClientService : IClientService
{
    public async Task<List<Client>> GetClients()
    {
        return new List<Client>{
            new Client{
            Id = 1,
            Name = "a",
            Mail="a",
            Surname = "bv",
            Phone = "123"
        }
        };
    }
    public async Task<Client> GetClientById(int idClient)
    {
        return new Client{
            Id = idClient,
            Name = "a",
            Mail="a",
            Surname = "bv",
            Phone = "123"
        };
    }

    public async Task CreateNewClient(Client client)
    {
        //Crear clientne
    }

    public async Task UpdateClient(Client client)
    {
        
    }

    public async Task DeleteClient(int id)
    {
        
    }
}
