using AlSafar.Domain.Models.Client;
using AlSafar.Infrastructure.DbContext;
using AlSafar.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace AlSafar.Infrastructure.Repository;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _dbContext;

    public ClientRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Client> AddClientAsync(Client client)
    {
        var result = await _dbContext.Clients.AddAsync(client);
        return result.Entity;
    }

    public async Task<Client> GetClientByIdAsync(int id)
    {
        Client? client = await _dbContext.Clients
            .FirstOrDefaultAsync(o => o.Id == id);

        return client;
    }

    public IQueryable<Client> GetAllClients()
    {
        return _dbContext.Clients;
    }

    public async Task<Client> RemoveClientAsync(Client client)
    {
        _dbContext.Clients.Remove(client);
        return client;
    }

    public async Task<Client> UpdateClientAsync(int id, Client client)
    {
        Client? updatedClient = await _dbContext.Clients
            .FirstOrDefaultAsync(o => o.Id == id);

        if (updatedClient != null)
        {
            updatedClient.Name = client.Name;
            updatedClient.Age = client.Age;
            updatedClient.Email = client.Email;
            updatedClient.PassportId = client.PassportId;
            updatedClient.PhoneNumber = client.PhoneNumber;
            updatedClient.Verified = client.Verified;

            return updatedClient;
        }

        return null;
    }
}