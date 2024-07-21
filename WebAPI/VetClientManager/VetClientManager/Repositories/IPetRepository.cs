using System.Collections.Generic;
using System.Threading.Tasks;
using VetClientManager.Models;

namespace VetClientManager.Repositories
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> GetPetsAsync();
        Task<Pet> GetPetByIdAsync(int id);
        Task<int> AddPetAsync(Pet pet);
        Task<int> UpdatePetAsync(Pet pet);
        Task<int> DeletePetAsync(int id);
    }
}