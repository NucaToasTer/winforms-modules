namespace placeholder;

using Dapper;

public class Product
{
    public int ID { get; set; }
    public string? Product_Name { get; set; }
    public string? Category { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    private static readonly Database _db = new();

    public static IEnumerable<Product> All()
    {
        using var conn = _db.Connect();
        return conn.Query<Product>("""
            SELECT product_id AS ID, product_name AS Product_Name,
                   product_category AS Category, product_price AS Price,
                   product_instock AS Stock
            FROM products ORDER BY product_id
            """);
    }

    public static Product? FindById(int id)
    {
        using var conn = _db.Connect();
        return conn.QueryFirstOrDefault<Product>(
            "SELECT product_id AS ID, product_name AS Product_Name, product_category AS Category, product_price AS Price, product_instock AS Stock FROM products WHERE product_id = @id",
            new { id });
    }

    public static void Insert(string name, string category, decimal price, int stock)
    {
        using var conn = _db.Connect();
        conn.Execute(
            "INSERT INTO products (product_name, product_category, product_price, product_instock) VALUES (@name, @category, @price, @stock)",
            new { name, category, price, stock });
    }

    public static void Edit(int id, string name, string category, decimal price, int stock)
    {
        using var conn = _db.Connect();
        conn.Execute(
            "UPDATE products SET product_name=@name, product_category=@category, product_price=@price, product_instock=@stock WHERE product_id=@id",
            new { id, name, category, price, stock });
    }

    public static void Delete(int id)
    {
        using var conn = _db.Connect();
        conn.Execute("DELETE FROM products WHERE product_id = @id", new { id });
    }
}