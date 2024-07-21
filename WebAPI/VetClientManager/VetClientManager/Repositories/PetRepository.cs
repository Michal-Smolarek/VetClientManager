using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using VetClientManager.Models;

namespace VetClientManager.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public PetRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Pet>> GetPetsAsync()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<Pet>("SELECT * FROM Pets");
            }
        }

        public async Task<Pet> GetPetByIdAsync(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryFirstOrDefaultAsync<Pet>("SELECT * FROM Pets WHERE Id = @Id", new { Id = id });
            }
        }

        public async Task<int> AddPetAsync(Pet pet)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "INSERT INTO Pets (Name, Type, BirthDate, ClientId) VALUES (@Name, @Type, @BirthDate, @ClientId); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await db.QuerySingleAsync<int>(sql, new { pet.Name, pet.Type, pet.BirthDate, pet.ClientId });
            }
        }

        public async Task<int> UpdatePetAsync(Pet pet)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "UPDATE Pets SET Name = @Name, Type = @Type, BirthDate = @BirthDate, ClientId = @ClientId WHERE Id = @Id";
                return await db.ExecuteAsync(sql, new { pet.Name, pet.Type, pet.BirthDate, pet.ClientId, pet.Id });
            }
        }

        public async Task<int> DeletePetAsync(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "DELETE FROM Pets WHERE Id = @Id";
                return await db.ExecuteAsync(sql, new { Id = id });
            }
        }
    }
}
