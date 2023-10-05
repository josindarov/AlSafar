package com.joblack.alsafar.services;

import com.joblack.alsafar.entities.Client;
import com.joblack.alsafar.repository.ClientRepository;
import org.antlr.v4.runtime.misc.NotNull;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ClientService {

    private ClientRepository clientRepository;

    @Autowired
    public ClientService(ClientRepository clientRepository){
        this.clientRepository = clientRepository;
    }

    public Client createClient(Client client){
        return clientRepository.save(client);
    }

    public Client getClientById(Long id){
        return clientRepository.findById(id).orElse(null);
    }

    public List<Client> getListOfClients(){
        return clientRepository.findAll();
    }

    public String deleteClient(Long id){
        clientRepository.deleteById(id);
        return "Client succesfully deleted";
    }

    public Client updateClient(Long id, Client client){
        Client client1 = getClientById(id);
        client1.setAge(client.getAge());
        client1.setName(client.getName());
        client1.setEmail(client.getEmail());

        return client1;
    }



}
