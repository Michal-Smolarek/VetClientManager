using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using VetClientManager.Models;

namespace VetClientManager.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public AppointmentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsAsync()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<Appointment>("SELECT * FROM Appointments");
            }
        }

        public async Task<Appointment> GetAppointmentByIdAsync(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryFirstOrDefaultAsync<Appointment>("SELECT * FROM Appointments WHERE Id = @Id", new { Id = id });
            }
        }

        public async Task<int> AddAppointmentAsync(Appointment appointment)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "INSERT INTO Appointments (Date, Reason, PetId) VALUES (@Date, @Reason, @PetId); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await db.QuerySingleAsync<int>(sql, new { appointment.Date, appointment.Reason, appointment.PetId });
            }
        }

        public async Task<int> UpdateAppointmentAsync(Appointment appointment)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "UPDATE Appointments SET Date = @Date, Reason = @Reason, PetId = @PetId WHERE Id = @Id";
                return await db.ExecuteAsync(sql, new { appointment.Date, appointment.Reason, appointment.PetId, appointment.Id });
            }
        }

        public async Task<int> DeleteAppointmentAsync(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = "DELETE FROM Appointments WHERE Id = @Id";
                return await db.ExecuteAsync(sql, new { Id = id });
            }
        }
    }
}
