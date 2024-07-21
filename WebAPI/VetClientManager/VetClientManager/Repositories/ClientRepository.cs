using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using VetClientManager.Models;

namespace VetClientManager.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ClientRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<Client>("SELECT * FROM Clients");
            }
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryFirstOrDefaultAsync<Client>("SELECT * FROM Clients WHERE Id = @Id", new { Id = id });
            }
        }

        public async Task<Client> GetClientByEmailAsync(string email)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryFirstOrDefaultAsync<Client>("SELECT * FROM Clients WHERE Email = @Email", new { Email = email });
            }
        }

        public async Task<int> AddClientAsync(Client client)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "INSERT INTO Clients (Name, Email, Role, PasswordHash) VALUES (@Name, @Email, @Role, @PasswordHash); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await db.QuerySingleAsync<int>(sql, new { client.Name, client.Email, client.Role, client.PasswordHash });
            }
        }

        public async Task<int> UpdateClientAsync(Client client)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "UPDATE Clients SET Name = @Name, Email = @Email, Role = @Role, PasswordHash = @PasswordHash WHERE Id = @Id";
                return await db.ExecuteAsync(sql, new { client.Name, client.Email, client.Role, client.PasswordHash, client.Id });
            }
        }

        public async Task<int> DeleteClientAsync(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "DELETE FROM Clients WHERE Id = @Id";
                return await db.ExecuteAsync(sql, new { Id = id });
            }
        }
    }
}
