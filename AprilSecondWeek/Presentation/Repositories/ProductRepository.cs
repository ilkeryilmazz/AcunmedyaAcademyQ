using Microsoft.Data.SqlClient;
using Presentation.Database;
using Presentation.Models;

namespace Presentation.Repositories
{
    public class ProductRepository
    {
        private readonly DatabaseHelper _db;
        public ProductRepository(DatabaseHelper db)
        {
            _db = db;
        }

        public List<Product> GetAll()
        {
            return _db.Execute(connection =>
            {
                var productList = new List<Product>();
                var command = new SqlCommand("SELECT * FROM Products", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productList.Add(new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"])
                        });
                    }
                }
                return productList;
            });
        }
        public Product? GetById(int id)
        {
            return _db.Execute(connection =>
            {
                var command = new SqlCommand("SELECT * FROM Products WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"])
                        };
                    }
                }
                return null;
            });
        }
        public void Add(Product product)
        {
            _db.Execute(connection =>
            {
                var command = new SqlCommand("INSERT INTO Products (Name, Price, Stock) VALUES (@name, @price, @stock)", connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                command.ExecuteNonQuery();
            });
        }
        public void Update(int id, Product product)
        {
            _db.Execute(connection =>
            {
                var command = new SqlCommand("UPDATE Products SET Name=@name, Price=@price, Stock=@stock WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                command.ExecuteNonQuery();
            });
        }
        public void Delete(int id)
        {
            _db.Execute(connection =>
            {
                var command = new SqlCommand("DELETE FROM Products WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            });
        }
    }
}
