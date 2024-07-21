using System.Collections.Generic;
using System.Threading.Tasks;
using VetClientManager.Models;

namespace VetClientManager.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClientsAsync();
        Task<Client> GetClientByIdAsync(int id);
        Task<Client> GetClientByEmailAsync(string email);
        Task<int> AddClientAsync(Client client);
        Task<int> UpdateClientAsync(Client client);
        Task<int> DeleteClientAsync(int id);
    }
}