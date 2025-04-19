

using Microsoft.Data.SqlClient;

namespace Presentation.Database
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public T Execute<T>(Func<SqlConnection, T> action)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return action(connection);
            }
        }

        public void Execute(Action<SqlConnection> action)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                action(connection);
            }
        }

    }
}
