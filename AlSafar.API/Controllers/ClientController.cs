using AlSafar.Domain.Models.Client;
using AlSafar.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AlSafar.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientRepository _clientRepository;

    public ClientController(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    [HttpGet]
    public List<Client> GetAllClients()
    {
        return _clientRepository.GetAllClients().ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> GetClientByIdAsync(int id)
    {
        Client client = await _clientRepository.GetClientByIdAsync(id);
        return Ok(client);
    }

    [HttpPost]
    public async Task<ActionResult<Client>> PostClientAsync(Client client)
    {
        Client addedClient = await _clientRepository.AddClientAsync(client);
        return Ok(addedClient);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Client>> RemoveClientAsync(int id)
    {
        Client client = await _clientRepository.GetClientByIdAsync(id);
        return await _clientRepository.RemoveClientAsync(client);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Client>> UpdateClientAsync(int id, Client client)
    {
        Client updatedClient = await _clientRepository.UpdateClientAsync(id, client);
        return Ok(updatedClient);
    }
    
}