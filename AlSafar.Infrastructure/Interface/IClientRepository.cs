using AlSafar.Domain.Models.Client;

namespace AlSafar.Infrastructure.Interface;

public interface IClientRepository
{
    Task<Client> AddClientAsync(Client client);
    Task<Client> GetClientByIdAsync(int id);
    IQueryable<Client> GetAllClients();
    Task<Client> RemoveClientAsync(Client client);
    Task<Client> UpdateClientAsync(int id, Client client);
}