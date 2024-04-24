using AlSafar.Domain.Models.Client;
using AlSafar.Infrastructure.Interface;

namespace AlSafar.Infrastructure.Repository;

public class ClientRepository : IClientRepository
{
    public async Task<Client> AddClientAsync(Task task)
    {
        throw new NotImplementedException();
    }

    public async Task<Client> GetClientByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Client> GetAllClients()
    {
        throw new NotImplementedException();
    }

    public async Task<Client> RemoveClientAsync(Client client)
    {
        throw new NotImplementedException();
    }

    public async Task<Client> UpdateClientAsync(Client client)
    {
        throw new NotImplementedException();
    }
}